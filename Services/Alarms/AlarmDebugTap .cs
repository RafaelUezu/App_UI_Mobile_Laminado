using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    public sealed class AlarmDebugTap : IDisposable
    {
        private readonly AlarmEngine _engine;
        private bool _listening;

        // Construtor “aleatório” que pega o AlarmEngine via Service Locator
        public AlarmDebugTap()
            : this(App.Services.GetRequiredService<AlarmEngine>()) { }

        // Construtor alternativo (se você quiser injetar o Engine via DI)
        public AlarmDebugTap(AlarmEngine engine)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        /// <summary>
        /// Imprime um snapshot completo do estado atual (uma vez).
        /// </summary>
        public void DumpOnce()
        {
            System.Diagnostics.Debug.WriteLine($"[Alarms] GeneralAlarm = {_engine.GeneralAlarm}");

            var all = _engine.GetAll();
            System.Diagnostics.Debug.WriteLine($"[Alarms] Total cadastrados: {all.Count}");

            foreach (var (def, state) in all)
            {
                System.Diagnostics.Debug.WriteLine(
                    $"[Alarms] Id={def.Id} Name='{def.Name}' Sev={def.Severity} Group='{def.Group}' " +
                    $"Active={state.IsActive} Ack={state.IsAcknowledged} Count={state.ActivationsCount} " +
                    $"LastChange={state.LastChangeUtc:O}");
            }
        }

        /// <summary>
        /// Começa a ouvir os eventos do motor e imprimir cada transição.
        /// </summary>
        public void StartListening()
        {
            if (_listening) return;
            _engine.AlarmChangedAsync += OnAlarmChangedAsync;
            _engine.GeneralAlarmChangedAsync += OnGeneralAlarmChangedAsync;
            _listening = true;
            System.Diagnostics.Debug.WriteLine("[Alarms] Listening started.");
        }

        /// <summary>
        /// Para de ouvir (remove assinaturas).
        /// </summary>
        public void StopListening()
        {
            if (!_listening) return;
            _engine.AlarmChangedAsync -= OnAlarmChangedAsync;
            _engine.GeneralAlarmChangedAsync -= OnGeneralAlarmChangedAsync;
            _listening = false;
            System.Diagnostics.Debug.WriteLine("[Alarms] Listening stopped.");
        }

        // Handler para mudanças individuais (Activated / Cleared / Acknowledged)
        private Task OnAlarmChangedAsync(object _, AlarmChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(
                $"[AlarmChanged] {e.TimestampUtc:O}  Id={e.Definition.Id}  Change={e.Change}  " +
                $"Active={e.State.IsActive} Ack={e.State.IsAcknowledged} Count={e.State.ActivationsCount}");
            return Task.CompletedTask;
        }

        // Handler para mudança do “alarme geral”
        private Task OnGeneralAlarmChangedAsync(object _, GeneralAlarmChangedEventArgs g)
        {
            System.Diagnostics.Debug.WriteLine($"[GeneralAlarm] {g.TimestampUtc:O}  {g.OldValue} -> {g.NewValue}");
            return Task.CompletedTask;
        }

        public void Dispose() => StopListening();
    }
}
