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
    // Define como ler o sinal e a política de latch
    public sealed class AlarmDefinition
    {
        public string Id { get; }
        public string DisplayName { get; }
        public Func<CancellationToken, ValueTask<bool?>> Reader { get; }
        public bool Latched { get; }

        public AlarmDefinition(string id, string displayName,
            Func<CancellationToken, ValueTask<bool?>> reader,
            bool latched = false)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            DisplayName = displayName ?? id;
            Reader = reader ?? throw new ArgumentNullException(nameof(reader));
            Latched = latched;
        }

        // Estado interno mutável do alarme
        public sealed class AlarmState
        {
            public bool IsActive { get; private set; }
            public bool IsAcknowledged { get; private set; }
            public int ActivationCount { get; private set; }
            public DateTimeOffset? FirstActiveUtc { get; private set; }
            public DateTimeOffset? LastActiveUtc { get; private set; }
            public DateTimeOffset LastChangeUtc { get; private set; } = DateTimeOffset.UtcNow;

            public void SetActive()
            {
                var now = DateTimeOffset.UtcNow;
                if (!IsActive)
                {
                    IsActive = true;
                    ActivationCount++;
                    FirstActiveUtc ??= now;
                    LastActiveUtc = now;
                    LastChangeUtc = now;
                    IsAcknowledged = false; // opcional: limpe ACK ao reativar
                }
                else
                {
                    // permanece ativo; atualize "última vez visto ativo"
                    LastActiveUtc = now;
                }
            }

            public void SetCleared()
            {
                if (IsActive)
                {
                    IsActive = false;
                    LastChangeUtc = DateTimeOffset.UtcNow;
                }
            }

            public void Acknowledge()
            {
                IsAcknowledged = true;
                LastChangeUtc = DateTimeOffset.UtcNow;
            }
        }
        // Snapshot somente-leitura para UI/servidor
        public sealed record AlarmSnapshot(
            string Id,
            string DisplayName,
            bool IsActive,
            bool IsAcknowledged,
            int ActivationCount,
            DateTimeOffset? FirstActiveUtc,
            DateTimeOffset? LastActiveUtc,
            DateTimeOffset LastChangeUtc
        );

        // Payload para eventos
        public sealed class AlarmChangedEventArgs : EventArgs
        {
            public AlarmSnapshot Snapshot { get; }
            public AlarmDefinition Definition { get; }
            public string ChangeKind { get; } // "Raised" | "Cleared" | "Acknowledged" | "Changed"

            public AlarmChangedEventArgs(AlarmSnapshot snapshot, AlarmDefinition definition, string changeKind)
            {
                Snapshot = snapshot;
                Definition = definition;
                ChangeKind = changeKind;
            }
        }
        // Sink opcional (persistência/histórico). No-op por padrão.
        public interface IAlarmSink
        {
            void Append(AlarmChangedEventArgs evt);
        }

        public sealed class NullAlarmSink : IAlarmSink
        {
            public void Append(AlarmChangedEventArgs evt) { /* no-op */ }
        }
    }
}

