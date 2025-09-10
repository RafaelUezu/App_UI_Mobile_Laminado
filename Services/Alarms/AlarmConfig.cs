using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Communication.Variable;
namespace App_UI_Mobile_Laminado.Services.Alarms
{
    public sealed class AlarmConfig
    {
        public IEnumerable<AlarmDefinition> GetDefinitions() => new[]
        {
        new AlarmDefinition("ALM_GERAL1",        "Alarme Geral PLC", severity: 1, group: "Linha"),
        new AlarmDefinition("ALM_FORNO_SUP_T1",  "Termopar Superior 1 quebrado", severity: 3, group: "Forno"),
        new AlarmDefinition("ALM_FORNO_INF_T2",  "Termopar Inferior 2 quebrado", severity: 3, group: "Forno"),
        // adicione o restante aqui
        };
        public Dictionary<string, Func<bool?>> BuildReaders() => new()
        {
            ["ALM_GERAL1"] = () => GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(1) ?? false,
            ["ALM_FORNO_SUP_T1"] = () => GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(2) ?? false,
            ["ALM_FORNO_INF_T2"] = () => GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(3) ?? false
        };
    }
}
