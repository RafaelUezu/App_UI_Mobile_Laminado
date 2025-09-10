using MAUI_Opcua.Services.Drivers.Opcua;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    public sealed class AlarmsSupervisory
    {
        public sealed class OpcUaAlarmAdapter : IDisposable
        {


            private readonly AlarmEngine _engine;
            private readonly Dictionary<string, Func<bool?>> _readers;

            
            public OpcUaAlarmAdapter(AlarmEngine engine, Dictionary<string, Func<bool?>> readers)
            {
                _engine = engine;
                _readers = readers;
                OpcUaEvents.LeituraFinalizadaAsync += OnLeituraFinalizadaAsync;
            }

            private async Task OnLeituraFinalizadaAsync()
            {
               

                var updates = new Dictionary<string, bool>(_readers.Count);

                foreach (var kv in _readers)
                {
                    bool value = kv.Value?.Invoke() ?? false; // null => false
                    updates[kv.Key] = value;
                }
                await _engine.BulkUpdateAsync(updates).ConfigureAwait(false);
            }
            

            public void Dispose()
            {
                MAUI_Opcua.Services.Drivers.Opcua.OpcUaEvents.LeituraFinalizadaAsync -= OnLeituraFinalizadaAsync;
            }
        }
    }
}
