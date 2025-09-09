using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace App_UI_Mobile_Laminado.Services.LogExporter
{
    public static class LogExporter
    {
        public static async Task<bool?> ShareLogAsync(string LogName)
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, $"AppLogs/{LogName}.txt");
            if (!File.Exists(path))
            {
                System.Diagnostics.Debug.WriteLine($"{LogName}.txt não encontrado.", LogName);
                return null;
            }

            // Copia para um arquivo temporário para evitar conflito com escrita em andamento
            var tmp = Path.Combine(FileSystem.CacheDirectory, $"log_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
            File.Copy(path, tmp, overwrite: true);

            await Share.Default.RequestAsync(new ShareFileRequest
            {
                Title = LogName,
                File = new ShareFile(tmp, "text/plain") // MIME type
            });
            return true;
        }
        public static async Task<List<string?>?> DataLogsNames()
        {
            var path = Path.Combine(FileSystem.AppDataDirectory) + "//AppLogs";
            if (!Directory.Exists(path))
            {
                System.Diagnostics.Debug.WriteLine($"Diretório de logs não encontrado.");
                return null;
            }
            var logFiles = Directory.GetFiles(path, "*.txt")
                                    .Select(f => Path.GetFileNameWithoutExtension(f))
                                    .ToList();
            if (logFiles.Count == 0)
            {
                System.Diagnostics.Debug.WriteLine("Nenhum arquivo de log encontrado.");
                return null;
            }
            else if (logFiles is null)
            {
                System.Diagnostics.Debug.WriteLine("Nenhum arquivo de log encontrado.");
                return null;
            }
            else
            {
                return logFiles;
            }
        }




    }
}
