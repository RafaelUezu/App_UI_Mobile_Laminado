using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.db.db_BaseClass
{
    public class db_BaseClass_Basic
    {
        /// <summary>
        /// Verifica a existência de um arquivo db.
        /// </summary>
        /// <param name="db_RecipeName">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool?> DropDatabaseIfExistsAsync(string db_RecipeName)
        {
            try
            {
                if (string.IsNullOrEmpty(db_RecipeName))
                {
                    return false;
                }
                string db_File = $"{db_RecipeName}.db";
                string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);

                return await Task.Run(() =>
                {
                    if (File.Exists(dbPath))
                    {
                        File.Delete(dbPath);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                });

            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Verifica a existência de um arquivo db.
        /// </summary>
        /// <param name="db_RecipeName">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool?> ExistDatabaseAsync(string db_RecipeName)
        {
            try
            {
                string db_File = $"{db_RecipeName}.db";
                string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                bool exists = await Task.Run(() => File.Exists(dbPath));

                if (exists)
                {
                    return true;
                }
                else if (!exists)
                {
                    return false;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error checking database existence: {ex.Message}");
                return null;
            }
        }

        public async Task<List<string?>?> AllListDatabaseAsync(string db_Name, string db_ColunmName)
        {
            try
            {
                if (string.IsNullOrEmpty(db_Name) || string.IsNullOrEmpty(db_ColunmName))
                {
                    return null;
                }
                else
                {
                    return await Task.Run(() =>
                    {
                        string db_file = $"{db_Name}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_file);
                        if (!File.Exists(dbPath))
                        {
                            return null;
                        }
                        else
                        {
                            List<string?>? resultados = new();
                            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                            {
                                connection.Open();
                                var command = connection.CreateCommand();
                                command.CommandText =
                                $@"
                                SELECT {db_ColunmName}
                                FROM {db_Name};";
                                using (var reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        var valor = reader.GetString(0);
                                        resultados.Add(valor);
                                    }
                                }
                            }
                            return resultados;
                        }
                        
                    });
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
