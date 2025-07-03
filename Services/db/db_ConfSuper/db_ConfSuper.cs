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
            using var stream = await FileSystem.OpenAppPackageFileAsync("Json_ConfSuper.json");
            using var reader = new StreamReader(stream);
            string jsonContent = await reader.ReadToEndAsync();
            var config = JsonSerializer.Deserialize<ConfSuperConfig>(jsonContent);

            GVL.ConfSuper.UrlOpcUa.ReadWrite = config?.UrlOpcUa ?? "opc.tcp://10.10.255.20:4840";
            GVL.ConfSuper.TimeOutPing.ReadWrite = config?.TimeOutPing ?? 1000;
            GVL.ConfSuper.TimeRequest.ReadWrite = config?.TimeRequest ?? 600;
            GVL.ConfSuper.MaxAgeOpcUa.ReadWrite = config?.MaxAgeOpcUa ?? 100;
            GVL.ConfSuper.MedAgeOpcUa.ReadWrite = config?.MaxAgeOpcUa ?? 50;
            GVL.ConfSuper.MinAgeOpcUa.ReadWrite = config?.MinAgeOpcUa ?? 10;
            GVL.ConfSuper.ZeroAgeOpcUa.ReadWrite = config?.ZeroAgeOpcUa ?? 0;
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
