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
        /// <param name="db_Name">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool?> DropDatabaseIfExistsAsync(string db_Name)
        {
            try
            {
                if (string.IsNullOrEmpty(db_Name))
                {
                    return false;
                }
                string db_File = $"{db_Name}.db";
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
        /// <param name="db_Name">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool?> ExistDatabaseAsync(string db_Name)
        {
            try
            {
                string db_File = $"{db_Name}.db";
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
        /// <summary>
        /// Deleta uma linha específica de uma tabela em um banco de dados SQLite.
        /// </summary>
        /// <param name="db_Name">Nome do banco de dados.</param>
        /// <param name="Table_Name">Nome da tabela.</param>
        /// <param name="Field_Name">Nome do campo.</param>
        /// <param name="Cell_Name">Valor da célula a ser deletada.</param>
        /// <returns>Retorna true se a exclusão for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool?> DeleteLineDatabaseAsync(string db_Name, string Table_Name, string Field_Name, string Cell_Name)
        {
            try
            {
                if (string.IsNullOrEmpty(db_Name) || string.IsNullOrEmpty(Table_Name) || string.IsNullOrEmpty(Field_Name) || string.IsNullOrEmpty(Cell_Name))
                {
                    return null;
                }
                else
                {
                    bool? Validade_DataBase = await ExistDatabaseAsync(db_Name);
                    if(Validade_DataBase != null && Validade_DataBase != false)
                    {
                        string db_File = $"{db_Name}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        if (!File.Exists(dbPath))
                        {
                            return null;
                        }
                        else
                        {
                            return await Task.Run(() =>
                            {
                                using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                                {
                                    connection.Open();
                                    using var command = connection.CreateCommand();
                                    command.CommandText =
                                    $@"
                                    DELETE FROM {Table_Name}
                                    WHERE {Field_Name} = @cell_Name;";

                                    command.Parameters.AddWithValue("@cell_Name", Cell_Name);

                                    command.ExecuteNonQuery();

                                }
                                return true;
                            });
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<string?>?> AllListDatabaseAsync(string db_Name, string Table_Name, string ColunmName)
        {
            try
            {
                if (string.IsNullOrEmpty(db_Name) || string.IsNullOrEmpty(Table_Name) || string.IsNullOrEmpty(ColunmName))
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
                                SELECT {ColunmName}
                                FROM {Table_Name};";
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
