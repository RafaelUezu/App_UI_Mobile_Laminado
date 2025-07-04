using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Communication.Variable;
using Microsoft.Maui.Storage;

namespace App_UI_Mobile_Laminado.Services.db.db_ConfSuper
{
    public class db_ConfSuper
    {
        public async Task LoadConfigAsync()
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("Json_ConfSuper.json");
                using var reader = new StreamReader(stream);
                string jsonContent = await reader.ReadToEndAsync();

                var config = JsonSerializer.Deserialize<ConfSuperConfig>(jsonContent);

                if (config is null)
                    throw new InvalidOperationException("Arquivo de configuração inválido.");

                GVL.ConfSuper.sUrlOpcUa.ReadWrite = config.UrlOpcUa ?? "opc.tcp://10.10.255.20:4840";
                GVL.ConfSuper.iTimeOutPing.ReadWrite = config.TimeOutPing ?? 1000;
                GVL.ConfSuper.iTimeRequest.ReadWrite = config.TimeRequest ?? 600;
                GVL.ConfSuper.iMaxAgeOpcUa.ReadWrite = config.MaxAgeOpcUa ?? 100;
                GVL.ConfSuper.iMedAgeOpcUa.ReadWrite = config.MedAgeOpcUa ?? 50;
                GVL.ConfSuper.iMinAgeOpcUa.ReadWrite = config.MinAgeOpcUa ?? 10;
                GVL.ConfSuper.iZeroAgeOpcUa.ReadWrite = config.ZeroAgeOpcUa ?? 0;
            }
            catch (Exception ex)
            {
                // Logar ou tratar exceção
                System.Diagnostics.Debug.WriteLine($"Erro ao carregar config: {ex.Message}");

                // Você decide: lançar novamente ou continuar com defaults
                // throw;
            }
        }

    }
    public class ConfSuperConfig
    {
        public string? UrlOpcUa { get; set; }
        public int? TimeOutPing { get; set; }
        public int? TimeRequest { get; set; }
        public int? MaxAgeOpcUa { get; set; }
        public int? MedAgeOpcUa { get; set; }
        public int? MinAgeOpcUa { get; set; }
        public int? ZeroAgeOpcUa { get; set; }
    }
}
