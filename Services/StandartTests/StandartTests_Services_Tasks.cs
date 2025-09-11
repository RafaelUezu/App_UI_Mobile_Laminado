using App_UI_Mobile_Laminado.Services.Alarms;
using MAUI_Opcua.Services.Communication.Variable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App_UI_Mobile_Laminado.Services.StandartTests
{
    public partial class StandartTests_Services
    {
        #region Instância de AlarmEngine e registro de alarmes
        private void RegisterAlarms()
        {
            // Alarme Geral 1 — lendo do seu GVL (bool? → bool)
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_WAR_UNID_VAC01_TROCA_OLEO",
                displayName: "Óleo da Bomba de Vácuo",
                

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ClpIhm.xAlarmeHorimetroB01.Read ?? false;
                    return new ValueTask<bool>(v);
                }));

            // Exemplos para você replicar (substitua pelos seus pontos reais):
            // Porta aberta
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_GERAL_2",
                displayName: "Porta aberta",
                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));

            // Sobretemperatura zona 1
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_GERAL_3",
                displayName: "Sobretemperatura Z1",
                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));

            // Dica: AddAlarm retorna bool (true = adicionado, false = ID duplicado).
            // Se quiser, teste o retorno e faça log quando houver duplicidade.
        }
        #endregion
        bool Ackall;

        private async Task DoWorkOnceAsync(CancellationToken ct)
        {
            await _alarmEngine.ScanOnceAsync(ct);
            var snapshot = _alarmEngine.Snapshot();
            var nowLocal = DateTimeOffset.Now;
            
            if (Ackall == true)
            {
                var whenUtc = DateTimeOffset.UtcNow;
                _ = _alarmEngine.Acknowledge("ALM_GERAL_1", whenUtc);
            }
            foreach (var a in snapshot)
            {
                var lastChangeLocal = a.LastChangeUtc?.ToLocalTime();
                var lastActLocal = a.LastActivatedUtc?.ToLocalTime();
                var lastClrLocal = a.LastClearedUtc?.ToLocalTime();
                var lastAckLocal = a.LastAcknowledgedUtc?.ToLocalTime();

                string since =
                    lastChangeLocal.HasValue
                        ? (nowLocal - lastChangeLocal.Value).ToString(@"hh\:mm\:ss\.fff")
                        : "-";

                string err = a.LastReadError is null ? "-" : a.LastReadError.Message;

                Debug.WriteLine(
                    $"[{DateTime.Now:HH:mm:ss.fff}] " +
                    $"Id={a.Id} | Nome={a.DisplayName} | Ativo={a.IsActive} | Ack={a.IsAcknowledged} | " +
                    $"UltMudanca={(lastChangeLocal?.ToString("HH:mm:ss.fff") ?? "-")} (+{since}) | " +
                    $"Subida={(lastActLocal?.ToString("HH:mm:ss.fff") ?? "-")} | " +
                    $"Descida={(lastClrLocal?.ToString("HH:mm:ss.fff") ?? "-")} | " +
                    $"AckTime={(lastAckLocal?.ToString("HH:mm:ss.fff") ?? "-")} | " +
                    $"Erro={err}"
                );
            }



        }
    }
}
