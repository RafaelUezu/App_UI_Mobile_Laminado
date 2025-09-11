using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    /// <summary>
    /// Motor passivo de alarmes: mantém a coleção de AlarmInput e realiza uma varredura por chamada.
    /// Os eventos são disparados durante a varredura de cada item.
    /// </summary>
    public sealed class AlarmEngine
    {
        // ----- Eventos -----
        public event Action<AlarmInput, DateTimeOffset>? AlarmActivated;
        public event Action<AlarmInput, DateTimeOffset>? AlarmCleared;
        public event Action<AlarmInput, Exception>? AlarmReadError;

        // ----- Coleção & sincronização -----
        private readonly List<AlarmInput> _alarms = new();
        private readonly object _gate = new();

        // ----- Gestão da coleção -----
        public bool AddAlarm(AlarmInput alarm)
        {
            if (alarm is null) throw new ArgumentNullException(nameof(alarm));
            lock (_gate)
            {
                if (_alarms.Any(a => a.Id == alarm.Id)) return false;
                _alarms.Add(alarm);
                return true;
            }
        }

        public bool RemoveAlarm(string alarmId)
        {
            if (string.IsNullOrWhiteSpace(alarmId)) return false;
            lock (_gate)
            {
                var idx = _alarms.FindIndex(a => a.Id == alarmId);
                if (idx < 0) return false;
                _alarms.RemoveAt(idx);
                return true;
            }
        }

        public bool TryGetAlarm(string alarmId, out AlarmInput? alarm)
        {
            if (string.IsNullOrWhiteSpace(alarmId))
            {
                alarm = null;
                return false;
            }
            lock (_gate)
            {
                alarm = _alarms.FirstOrDefault(a => a.Id == alarmId);
                return alarm is not null;
            }
        }

        /// <summary>Retorna uma cópia imutável do estado atual da coleção.</summary>
        public IReadOnlyList<AlarmInput> Snapshot()
        {
            lock (_gate)
            {
                return _alarms.ToArray();
            }
        }

        // ----- Varredura única (chamada pelo seu loop externo) -----
        public async Task ScanOnceAsync(CancellationToken ct)
        {
            List<AlarmInput> current;
            lock (_gate)
            {
                current = _alarms.ToList(); // snapshot para iterar sem segurar o lock
            }

            foreach (var alarm in current)
            {
                ct.ThrowIfCancellationRequested();

                try
                {
                    var transition = await alarm.PollAsync(ct).ConfigureAwait(false);

                    // Se houve erro na leitura, avisa
                    if (alarm.LastReadError is not null)
                        AlarmReadError?.Invoke(alarm, alarm.LastReadError);

                    // Publica transições
                    switch (transition)
                    {
                        case AlarmInput.Transition.Activated:
                            AlarmActivated?.Invoke(alarm, alarm.LastActivatedUtc ?? DateTimeOffset.UtcNow);
                            break;

                        case AlarmInput.Transition.Cleared:
                            AlarmCleared?.Invoke(alarm, alarm.LastClearedUtc ?? DateTimeOffset.UtcNow);
                            break;

                        case AlarmInput.Transition.None:
                        default:
                            break;
                    }
                }
                catch (OperationCanceledException)
                {
                    throw; // deixe o chamador encerrar o loop dele
                }
                catch (Exception ex)
                {
                    // Falha inesperada ao tratar este alarme
                    AlarmReadError?.Invoke(alarm, ex);
                }
            }
        }

        // ----- Utilidades de reconhecimento (ACK) -----
        public bool Acknowledge(string alarmId, DateTimeOffset? whenUtc = null)
        {
            if (TryGetAlarm(alarmId, out var alarm) && alarm is not null && alarm.IsActive)
            {
                alarm.Acknowledge(whenUtc);
                return true;
            }
            return false;
        }

        public int AcknowledgeAllActive(DateTimeOffset? whenUtc = null)
        {
            int count = 0;
            List<AlarmInput> current;
            lock (_gate)
            {
                current = _alarms.ToList();
            }

            foreach (var a in current)
            {
                if (a.IsActive && !a.IsAcknowledged)
                {
                    a.Acknowledge(whenUtc);
                    count++;
                }
            }
            return count;
        }
    }
}
