using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    /// <summary>
    /// Serviço separado que consome os eventos da AlarmEngine.
    /// Futuramente, aqui você persiste em DB/arquivo/telemetria.
    /// </summary>
    public sealed class AlarmPersistenceService
    {
        private readonly AlarmEngine _engine;
        private bool _attached;

        public AlarmPersistenceService(AlarmEngine engine)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
            _ = VisualizarResultadosLoopAsync();
        }
        public async Task VisualizarResultadosLoopAsync()
        {
            for (; ; )
            {
                // 1) Snapshot do estado atual dos alarmes
                var snapshot = _engine.Snapshot();
                var agoraLocal = DateTimeOffset.Now;

                // 2) Métricas rápidas
                int total = snapshot.Count;
                int ativos = snapshot.Count(a => a.IsActive);
                int naoAck = snapshot.Count(a => a.IsActive && !a.IsAcknowledged);

                System.Diagnostics.Debug.WriteLine(
                    $"[ALARM VIEW {agoraLocal:HH:mm:ss}] total={total} ativos={ativos} naoAck={naoAck}");

                // 3) Lista detalhada
                foreach (var a in snapshot)
                {
                    if (!a.IsActive) continue; // filtra só os ativos
                    var lastChange = a.LastChangeUtc?.ToLocalTime().ToString("HH:mm:ss.fff") ?? "-";
                    var lastAct = a.LastActivatedUtc?.ToLocalTime().ToString("HH:mm:ss.fff") ?? "-";
                    var lastClr = a.LastClearedUtc?.ToLocalTime().ToString("HH:mm:ss.fff") ?? "-";
                    var ackTime = a.LastAcknowledgedUtc?.ToLocalTime().ToString("HH:mm:ss.fff") ?? "-";
                    var errMsg = a.LastReadError?.Message ?? "-";

                    System.Diagnostics.Debug.WriteLine(
                        $"  • {a.Id} | \"{a.DisplayName}\" | Ativo={a.IsActive} | Ack={a.IsAcknowledged} | " +
                        $"UltMud={lastChange} | Subida={lastAct} | Descida={lastClr} | AckTime={ackTime} | Err={errMsg}");
                }

                // 4) Aguardar alguns segundos (teste/visualização)
                await Task.Delay(TimeSpan.FromSeconds(3));
            }
        }
        /// <summary>
        /// Conecta nos eventos (chame uma única vez na inicialização do app/sessão).
        /// </summary>
        public void Attach()
        {
            if (_attached) return;

            _engine.AlarmActivated += OnAlarmActivated;
            _engine.AlarmCleared += OnAlarmCleared;
            _engine.AlarmReadError += OnAlarmReadError;

            _attached = true;
            System.Diagnostics.Debug.WriteLine("[AlarmPersistence] Attached.");
        }

        // --- Handlers mínimos (próximo passo: trocar por persistência em DB) ---

        private void OnAlarmActivated(AlarmInput alarm, DateTimeOffset whenUtc)
        {
            System.Diagnostics.Debug.WriteLine(
                $"[DB] ACTIVATED  Id={alarm.Id}  Ativo={alarm.IsActive}  " +
                $"When(local)={whenUtc.ToLocalTime():HH:mm:ss.fff}");
            // TODO: Persistir em DB (próximo passo)
        }

        private void OnAlarmCleared(AlarmInput alarm, DateTimeOffset whenUtc)
        {
            System.Diagnostics.Debug.WriteLine(
                $"[DB] CLEARED    Id={alarm.Id}  Ativo={alarm.IsActive}  " +
                $"When(local)={whenUtc.ToLocalTime():HH:mm:ss.fff}");
            // TODO: Persistir em DB (próximo passo)
        }

        private void OnAlarmReadError(AlarmInput alarm, Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"[DB] READ_ERROR Id={alarm.Id}  Err={ex.Message}");
            // TODO: Persistir/telemetria (próximo passo)
        }
    }

}
