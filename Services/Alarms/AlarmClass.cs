using MAUI_Opcua.Services.Communication.Variable;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Drivers.Opcua;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    // 1) Que tipo de mudança ocorreu?
    public enum AlarmChangeKind
    {
        Activated,     // false -> true
        Cleared,       // true  -> false
        Acknowledged,  // reconhecimento do operador
        Updated        // reservado (não usamos aqui)
    }
    // 2) Definição estática do alarme (metadados)
    public sealed class AlarmDefinition
    {
        public string Id { get; }           // identificador único, ex: "ALM_FORNO_T1" (“ALM_{ÁREA}{EQUIP}{SINAL}”)
        public string Name { get; }         // nome legível
        public string? Description { get; } // opcional
        public bool Invert { get; }         // inverte semântica (para sinais NC/NF) 1 = ok, 0 = falha” (NF/NC)
        public int Severity { get; }        // 1..N (para priorização)
        public string? Group { get; }       // área, linha, máquina etc.

        public AlarmDefinition(
            string id,
            string name,
            string? description = null,
            bool invert = false,
            int severity = 1,
            string? group = null)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            Invert = invert;
            Severity = severity;
            Group = group;
        }
    }
    // 3) Estado dinâmico do alarme (muda a cada leitura)
    public sealed class AlarmState
    {
        public bool IsActive { get; internal set; }            // ativo agora?
        public bool IsAcknowledged { get; internal set; }      // reconhecido?
        public DateTime? LastActivatedUtc { get; internal set; }
        public DateTime? LastClearedUtc { get; internal set; }
        public DateTime? LastAcknowledgedUtc { get; internal set; }
        public long ActivationsCount { get; internal set; }
        public DateTime LastChangeUtc { get; internal set; } = DateTime.UtcNow;

        // Snapshot leve (evita expor o objeto interno por referência)
        internal AlarmState Clone() => (AlarmState)MemberwiseClone();
    }

    // 4) Args para evento "um alarme mudou"
    public sealed class AlarmChangedEventArgs : EventArgs
    {
        public AlarmDefinition Definition { get; }
        public AlarmState State { get; }     // estado após a mudança
        public AlarmChangeKind Change { get; }
        public DateTime TimestampUtc { get; }

        public AlarmChangedEventArgs(
            AlarmDefinition def,
            AlarmState state,
            AlarmChangeKind change,
            DateTime timestampUtc)
        {
            Definition = def;
            State = state;
            Change = change;
            TimestampUtc = timestampUtc;
        }
    }

    // 5) Args para evento "alarme geral mudou"
    public sealed class GeneralAlarmChangedEventArgs : EventArgs
    {
        public bool OldValue { get; }
        public bool NewValue { get; }
        public DateTime TimestampUtc { get; }

        public GeneralAlarmChangedEventArgs(bool oldValue, bool newValue, DateTime tsUtc)
        {
            OldValue = oldValue;
            NewValue = newValue;
            TimestampUtc = tsUtc;
        }
    }

    // 6) DTO para exportar snapshot a um servidor de alarmes
    public sealed record AlarmSnapshot(
        string Id,
        string Name,
        bool IsActive,
        bool IsAcknowledged,
        int Severity,
        string? Group,
        DateTime? LastActivatedUtc,
        DateTime? LastClearedUtc,
        DateTime? LastAcknowledgedUtc,
        long ActivationsCount,
        DateTime LastChangeUtc
    );

    // 7) O MOTOR DE ALARMES
    public sealed class AlarmEngine
    {
        private readonly object _gate = new();
        private readonly Dictionary<string, (AlarmDefinition def, AlarmState state)> _map = new();
        private bool _generalAlarm;

        /// <summary>Valor calculado: existe algum alarme ativo?</summary>
        public bool GeneralAlarm
        {
            get { lock (_gate) return _generalAlarm; }
        }

        /// <summary>Evento assíncrono: qualquer alarme individual mudou de estado.</summary>
        public event Func<object, AlarmChangedEventArgs, Task>? AlarmChangedAsync;

        /// <summary>Evento assíncrono: o "alarme geral" (qualquer ativo) mudou.</summary>
        public event Func<object, GeneralAlarmChangedEventArgs, Task>? GeneralAlarmChangedAsync;

        // --- Cadastro --------------------------------------------------------

        public void Register(AlarmDefinition def)
        {
            if (def is null) throw new ArgumentNullException(nameof(def));
            lock (_gate)
            {
                if (_map.ContainsKey(def.Id))
                    throw new InvalidOperationException($"Alarm '{def.Id}' already registered.");

                _map[def.Id] = (def, new AlarmState());
            }
        }

        public void RegisterMany(IEnumerable<AlarmDefinition> defs)
        {
            foreach (var d in defs) Register(d);
        }

        // --- Atualizações (vêm do campo/OPC) --------------------------------

        /// <summary>Atualiza um único ponto (boolean) e dispara eventos de transição.</summary>
        public async Task UpdateAsync(string id, bool rawValue, DateTime? timestampUtc = null)
        {
            timestampUtc ??= DateTime.UtcNow;
            List<AlarmChangedEventArgs>? changes = null;
            bool generalChanged = false;
            bool oldGeneral = false, newGeneral = false;

            lock (_gate)
            {
                if (!_map.TryGetValue(id, out var entry))
                    throw new KeyNotFoundException($"Alarm '{id}' is not registered.");

                var effective = entry.def.Invert ? !rawValue : rawValue;
                var s = entry.state;

                if (effective != s.IsActive)
                {
                    s.IsActive = effective;
                    s.LastChangeUtc = timestampUtc.Value;

                    if (effective)
                    {
                        s.LastActivatedUtc = timestampUtc.Value;
                        s.IsAcknowledged = false;
                        s.ActivationsCount++;
                        (changes ??= new()).Add(new AlarmChangedEventArgs(entry.def, s.Clone(), AlarmChangeKind.Activated, timestampUtc.Value));
                    }
                    else
                    {
                        s.LastClearedUtc = timestampUtc.Value;
                        (changes ??= new()).Add(new AlarmChangedEventArgs(entry.def, s.Clone(), AlarmChangeKind.Cleared, timestampUtc.Value));
                    }

                    oldGeneral = _generalAlarm;
                    newGeneral = _map.Values.Any(e => e.state.IsActive);
                    if (newGeneral != _generalAlarm)
                    {
                        _generalAlarm = newGeneral;
                        generalChanged = true;
                    }
                }
            }

            if (changes is not null && AlarmChangedAsync is not null)
                foreach (var e in changes)
                    await InvokeAsync(AlarmChangedAsync, e).ConfigureAwait(false);

            if (generalChanged && GeneralAlarmChangedAsync is not null)
                await InvokeAsync(GeneralAlarmChangedAsync, new GeneralAlarmChangedEventArgs(oldGeneral, newGeneral, timestampUtc.Value)).ConfigureAwait(false);
        }

        /// <summary>Atualização em lote (ideal após "LeituraFinalizada").</summary>
        public async Task BulkUpdateAsync(IReadOnlyDictionary<string, bool> rawValues, DateTime? timestampUtc = null)
        {
            timestampUtc ??= DateTime.UtcNow;
            var pending = new List<AlarmChangedEventArgs>();
            bool generalChanged = false;
            bool oldGeneral = false, newGeneral = false;

            lock (_gate)
            {
                foreach (var (id, raw) in rawValues)
                {
                    if (!_map.TryGetValue(id, out var entry))
                        continue; // ou lance se preferir estrito

                    var effective = entry.def.Invert ? !raw : raw;
                    var s = entry.state;

                    if (effective != s.IsActive)
                    {
                        s.IsActive = effective;
                        s.LastChangeUtc = timestampUtc.Value;

                        if (effective)
                        {
                            s.LastActivatedUtc = timestampUtc.Value;
                            s.IsAcknowledged = false;
                            s.ActivationsCount++;
                            pending.Add(new AlarmChangedEventArgs(entry.def, s.Clone(), AlarmChangeKind.Activated, timestampUtc.Value));
                        }
                        else
                        {
                            s.LastClearedUtc = timestampUtc.Value;
                            pending.Add(new AlarmChangedEventArgs(entry.def, s.Clone(), AlarmChangeKind.Cleared, timestampUtc.Value));
                        }
                    }
                }

                oldGeneral = _generalAlarm;
                newGeneral = _map.Values.Any(e => e.state.IsActive);
                if (newGeneral != _generalAlarm)
                {
                    _generalAlarm = newGeneral;
                    generalChanged = true;
                }
            }

            if (pending.Count > 0 && AlarmChangedAsync is not null)
                foreach (var e in pending)
                    await InvokeAsync(AlarmChangedAsync, e).ConfigureAwait(false);

            if (generalChanged && GeneralAlarmChangedAsync is not null)
                await InvokeAsync(GeneralAlarmChangedAsync, new GeneralAlarmChangedEventArgs(oldGeneral, newGeneral, timestampUtc.Value)).ConfigureAwait(false);
        }

        /// <summary>Reconhece um alarme ativo (não limpa; só marca acknowledge).</summary>
        public async Task AcknowledgeAsync(string id, DateTime? timestampUtc = null)
        {
            timestampUtc ??= DateTime.UtcNow;
            AlarmChangedEventArgs? change = null;

            lock (_gate)
            {
                if (!_map.TryGetValue(id, out var entry))
                    throw new KeyNotFoundException($"Alarm '{id}' is not registered.");

                var s = entry.state;
                if (s.IsActive && !s.IsAcknowledged)
                {
                    s.IsAcknowledged = true;
                    s.LastAcknowledgedUtc = timestampUtc.Value;
                    s.LastChangeUtc = timestampUtc.Value;
                    change = new AlarmChangedEventArgs(entry.def, s.Clone(), AlarmChangeKind.Acknowledged, timestampUtc.Value);
                }
            }

            if (change is not null && AlarmChangedAsync is not null)
                await InvokeAsync(AlarmChangedAsync, change).ConfigureAwait(false);
        }

        // --- Consulta (para UI/Servidor de alarmes) --------------------------

        public IReadOnlyList<(AlarmDefinition def, AlarmState state)> GetActive()
        {
            lock (_gate)
                return _map.Values.Where(e => e.state.IsActive).Select(e => (e.def, e.state.Clone())).ToList();
        }

        public (AlarmDefinition def, AlarmState state)? GetById(string id)
        {
            lock (_gate)
                return _map.TryGetValue(id, out var e) ? (e.def, e.state.Clone()) : null;
        }

        public IReadOnlyList<(AlarmDefinition def, AlarmState state)> GetAll()
        {
            lock (_gate)
                return _map.Values.Select(e => (e.def, e.state.Clone())).ToList();
        }

        public IReadOnlyList<AlarmSnapshot> Snapshot()
        {
            lock (_gate)
                return _map.Values
                    .Select(e => new AlarmSnapshot(
                        e.def.Id,
                        e.def.Name,
                        e.state.IsActive,
                        e.state.IsAcknowledged,
                        e.def.Severity,
                        e.def.Group,
                        e.state.LastActivatedUtc,
                        e.state.LastClearedUtc,
                        e.state.LastAcknowledgedUtc,
                        e.state.ActivationsCount,
                        e.state.LastChangeUtc))
                    .ToList();
        }

        // --- Infra: chamada segura de eventos assíncronos --------------------

        private async Task InvokeAsync<TEventArgs>(Func<object, TEventArgs, Task> evt, TEventArgs args)
        {
            var handlers = evt.GetInvocationList();
            foreach (Func<object, TEventArgs, Task> h in handlers)
                await h(this, args).ConfigureAwait(false);
        }
    }

    // 8) ADAPTADOR OPC UA -> MOTOR (escuta seu evento e injeta leituras)
    //    Você fornece o "mapa" id -> função que lê o bool? do seu GVL.
    public sealed class OpcUaAlarmAdapter : IDisposable
    {
        private readonly AlarmEngine _engine;
        private readonly Dictionary<string, Func<bool?>> _readers;

        public OpcUaAlarmAdapter(AlarmEngine engine,
                                    Dictionary<string, Func<bool?>> readers)
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
            _readers = readers ?? throw new ArgumentNullException(nameof(readers));

            // Evento ESTÁTICO (não é do Opcua_Client)
            OpcUaEvents.LeituraFinalizadaAsync += OnLeituraFinalizadaAsync;
        }

        // A assinatura do handler precisa bater com o evento: Func<Task>
        private async Task OnLeituraFinalizadaAsync()
        {
            var updates = new Dictionary<string, bool>(_readers.Count);

            foreach (var (id, reader) in _readers)
            {
                bool value = reader?.Invoke() ?? false; // null => false
                updates[id] = value;
            }

            await _engine.BulkUpdateAsync(updates).ConfigureAwait(false);
        }

        public void Dispose()
        {
            OpcUaEvents.LeituraFinalizadaAsync -= OnLeituraFinalizadaAsync;
        }
    }
}

