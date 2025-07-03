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
        public async Task LoadConfigurationAsync()
        {
            var packageDir = FileSystem.Current.AppPackageDirectory;
            var filePath = Path.Combine(basePath, "Services", "db", "db_ConfSuper", "Json_ConfSuper.json");

            if (File.Exists(filePath))
            {
                string jsonContent = await File.ReadAllTextAsync(filePath);
                var config = JsonSerializer.Deserialize<ConfSuperConfig>(jsonContent);

                if (config != null)
                {
   
                    // ... etc
                }
            }
        }

    }
}
