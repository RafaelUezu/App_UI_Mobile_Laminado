using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using App_UI_Mobile_Laminado.Services.Communication.Variables;
using Microsoft.Maui.Storage;

namespace App_UI_Mobile_Laminado.Services.db.db_ConfSuper
{
    public class db_ConfSuper
    {
        private const string FileName = "Json_ConfSuper.json";
        private readonly string _localPath;

        public ConfSuperConfig Config { get; private set; } = new();

        public db_ConfSuper()
        {
            _localPath = Path.Combine(FileSystem.AppDataDirectory, FileName);
        }

        /// <summary>
        /// Inicializa a configuração copiando o JSON do pacote se necessário
        /// </summary>
        /// 

        public async Task CopyFromPackageIfNotExistsAsync()
        {
            if (File.Exists(_localPath))
            {
                // Já existe no local, não copia
                return;
            }

            using var stream = await FileSystem.OpenAppPackageFileAsync(FileName);
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();

            await File.WriteAllTextAsync(_localPath, content);
        }

        public async Task ResetToDefaultAsync()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync(FileName);
            using var reader = new StreamReader(stream);
            var content = await reader.ReadToEndAsync();

            await File.WriteAllTextAsync(_localPath, content);

            await LoadConfigAsync();
        }

        /// <summary>
        /// Carrega o JSON local para o objeto Config
        /// </summary>
        public async Task<ConfSuperConfig> LoadConfigAsync()
        {
            if (!File.Exists(_localPath))
                throw new FileNotFoundException($"Config file not found at {_localPath}");

            var content = await File.ReadAllTextAsync(_localPath);

            Config = JsonSerializer.Deserialize<ConfSuperConfig>(content)
                     ?? new ConfSuperConfig();
            return Config;
        }

        /// <summary>
        /// Salva a configuração atual no arquivo JSON local
        /// </summary>
        public async Task SaveConfigAsync(ConfSuperConfig Config)
        {
            var content = JsonSerializer.Serialize(Config, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            await File.WriteAllTextAsync(_localPath, content);
        }
    }

    public class ConfSuperConfig
    {
        public string? sUrlOpcUa { get; set; }
        public int? iTimeOutPing { get; set; }
        public int? iTimeRequest { get; set; }
        public int? iMaxAgeOpcUa { get; set; }
        public int? iMedAgeOpcUa { get; set; }
        public int? iMinAgeOpcUa { get; set; }
        public int? iZeroAgeOpcUa { get; set; }
        public int? iMaxTempRecipe { get; set; }
        public int? iMinTempRecipe { get; set; }
        public int? iMaxTempOperation { get; set; }
        public int? iMinTempOperation { get; set; }
    }
}
