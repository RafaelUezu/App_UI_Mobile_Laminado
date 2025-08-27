using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using App_UI_Mobile_Laminado.Services.db.db_BaseClass;
namespace App_UI_Mobile_Laminado.Services.db.db_Recipe
{
    public class db_Recipe : db_BaseClass_Basic
    {
        /// <summary>
        /// Atualiza uma receita específica no banco de dados.
        /// </summary>
        /// <param name="db_Name">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        /// 
        public async Task<bool?> CreateTableIfNotExistsAsync(string db_Name, string Table_Name)
        {
            try
            {
                if (string.IsNullOrEmpty(db_Name))
                {
                    return false;
                }
                else
                {
                    await Task.Run(() =>
                    {
                        string db_File = $"{db_Name}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        
                        if (!File.Exists(dbPath))
                        {
                            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                            {
                                connection.Open();
                                var command = connection.CreateCommand();
                                command.CommandText =
                                $@"
                                CREATE TABLE IF NOT EXISTS {Table_Name} (
                                sName TEXT NOT NULL,
                                iMinutoRampa01 INTEGER NOT NULL,
                                rTemperaturaSP01 REAL NOT NULL,
                                iHoraPatamar01 INTEGER NOT NULL,
                                iMinutoPatamar01 INTEGER NOT NULL,
                                iMinutoRampa02 INTEGER NOT NULL,
                                rTemperaturaSP02 REAL NOT NULL,
                                iHoraPatamar02 INTEGER NOT NULL,
                                iMinutoPatamar02 INTEGER NOT NULL,
                                iMinutoRampa03 INTEGER NOT NULL,
                                rTemperaturaSP03 REAL NOT NULL,
                                iHoraPatamar03 INTEGER NOT NULL,
                                iMinutoPatamar03 INTEGER NOT NULL,
                                iMinutoRampa04 INTEGER NOT NULL,
                                rTemperaturaSP04 REAL NOT NULL,
                                iHoraPatamar04 INTEGER NOT NULL,
                                iMinutoPatamar04 INTEGER NOT NULL,
                                iMinutoRampa05 INTEGER NOT NULL,
                                rTemperaturaSP05 REAL NOT NULL,
                                iHoraPatamar05 INTEGER NOT NULL,
                                iMinutoPatamar05 INTEGER NOT NULL,
                                iMinutoRampa06 INTEGER NOT NULL,
                                rTemperaturaSP06 REAL NOT NULL,
                                iHoraPatamar06 INTEGER NOT NULL,
                                iMinutoPatamar06 INTEGER NOT NULL,
                                iMinutoRampa07 INTEGER NOT NULL,
                                rTemperaturaSP07 REAL NOT NULL,
                                iHoraPatamar07 INTEGER NOT NULL,
                                iMinutoPatamar07 INTEGER NOT NULL,
                                iMinutoRampa08 INTEGER NOT NULL,
                                rTemperaturaSP08 REAL NOT NULL,
                                iHoraPatamar08 INTEGER NOT NULL,
                                iMinutoPatamar08 INTEGER NOT NULL,
                                iBombaPatamar01 INTEGER NOT NULL,
                                iBombaPatamar02 INTEGER NOT NULL,
                                iBombaPatamar03 INTEGER NOT NULL,
                                iBombaPatamar04 INTEGER NOT NULL,
                                iBombaPatamar05 INTEGER NOT NULL,
                                iBombaPatamar06 INTEGER NOT NULL,
                                iBombaPatamar07 INTEGER NOT NULL,
                                iBombaPatamar08 INTEGER NOT NULL,
                                iTempoBombaFim INTEGER NOT NULL
                                );
                                ";
                                command.ExecuteNonQuery();
                            }
                        }
                    });
                    return true;
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Atualiza uma receita específica no banco de dados.
        /// </summary>
        /// <param name="recipe"> Objeto de Parâmetros </param>
        /// <param name="db_Name">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        /// 
        public async Task<bool?> InsertRecipeAsync(string db_Name, string table_Name)
        {
            try
            {
                if (string.IsNullOrEmpty(db_Name))
                {
                    return false;
                }
                else
                {
                    await Task.Run(() =>
                    {
                        string db_File = $"{db_Name}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        using var connection = new SqliteConnection($"Data Source={dbPath}");
                        connection.Open();
                        using var command = connection.CreateCommand();
                        command.CommandText =
                        $@"
                        INSERT INTO {table_Name} (
                        sName,
                        iMinutoRampa01,
                        rTemperaturaSP01,
                        iHoraPatamar01,
                        iMinutoPatamar01,
                        iMinutoRampa02,
                        rTemperaturaSP02,
                        iHoraPatamar02,
                        iMinutoPatamar02,
                        iMinutoRampa03,
                        rTemperaturaSP03,
                        iHoraPatamar03,
                        iMinutoPatamar03,
                        iMinutoRampa04,
                        rTemperaturaSP04,
                        iHoraPatamar04,
                        iMinutoPatamar04,
                        iMinutoRampa05,
                        rTemperaturaSP05,
                        iHoraPatamar05,
                        iMinutoPatamar05,
                        iMinutoRampa06,
                        rTemperaturaSP06,
                        iHoraPatamar06,
                        iMinutoPatamar06,
                        iMinutoRampa07,
                        rTemperaturaSP07,
                        iHoraPatamar07,
                        iMinutoPatamar07,
                        iMinutoRampa08,
                        rTemperaturaSP08,
                        iHoraPatamar08,
                        iMinutoPatamar08,
                        iBombaPatamar01,
                        iBombaPatamar02,
                        iBombaPatamar03,
                        iBombaPatamar04,
                        iBombaPatamar05,
                        iBombaPatamar06,
                        iBombaPatamar07,
                        iBombaPatamar08,
                        iTempoBombaFim
                        ) VALUES (
                        $sName,
                        $iMinutoRampa01,
                        $dTemperaturaSP01,
                        $iHoraPatamar01,
                        $iMinutoPatamar01,
                        $iMinutoRampa02,
                        $dTemperaturaSP02,
                        $iHoraPatamar02,
                        $iMinutoPatamar02,
                        $iMinutoRampa03,
                        $dTemperaturaSP03,
                        $iHoraPatamar03,
                        $iMinutoPatamar03,
                        $iMinutoRampa04,
                        $dTemperaturaSP04,
                        $iHoraPatamar04,
                        $iMinutoPatamar04,
                        $iMinutoRampa05,
                        $dTemperaturaSP05,
                        $iHoraPatamar05,
                        $iMinutoPatamar05,
                        $iMinutoRampa06,
                        $dTemperaturaSP06,
                        $iHoraPatamar06,
                        $iMinutoPatamar06,
                        $iMinutoRampa07,
                        $dTemperaturaSP07,
                        $iHoraPatamar07,
                        $iMinutoPatamar07,
                        $iMinutoRampa08,
                        $dTemperaturaSP08,
                        $iHoraPatamar08,
                        $iMinutoPatamar08,
                        $iBombaPatamar01,
                        $iBombaPatamar02,
                        $iBombaPatamar03,
                        $iBombaPatamar04,
                        $iBombaPatamar05,
                        $iBombaPatamar06,
                        $iBombaPatamar07,
                        $iBombaPatamar08,
                        $iTempoBombaFim);";
                        command.Parameters.AddWithValue("$sName", RecipeSup.sName);
                        command.Parameters.AddWithValue("$iMinutoRampa01", RecipeSup.iMinutoRampa01);
                        command.Parameters.AddWithValue("$dTemperaturaSP01", RecipeSup.dTemperaturaSP01);
                        command.Parameters.AddWithValue("$iHoraPatamar01", RecipeSup.iHoraPatamar01);
                        command.Parameters.AddWithValue("$iMinutoPatamar01", RecipeSup.iMinutoPatamar01);
                        command.Parameters.AddWithValue("$iMinutoRampa02", RecipeSup.iMinutoRampa02);
                        command.Parameters.AddWithValue("$dTemperaturaSP02", RecipeSup.dTemperaturaSP02);
                        command.Parameters.AddWithValue("$iHoraPatamar02", RecipeSup.iHoraPatamar02);
                        command.Parameters.AddWithValue("$iMinutoPatamar02", RecipeSup.iMinutoPatamar02);
                        command.Parameters.AddWithValue("$iMinutoRampa03", RecipeSup.iMinutoRampa03);
                        command.Parameters.AddWithValue("$dTemperaturaSP03", RecipeSup.dTemperaturaSP03);
                        command.Parameters.AddWithValue("$iHoraPatamar03", RecipeSup.iHoraPatamar03);
                        command.Parameters.AddWithValue("$iMinutoPatamar03", RecipeSup.iMinutoPatamar03);
                        command.Parameters.AddWithValue("$iMinutoRampa04", RecipeSup.iMinutoRampa04);
                        command.Parameters.AddWithValue("$dTemperaturaSP04", RecipeSup.dTemperaturaSP04);
                        command.Parameters.AddWithValue("$iHoraPatamar04", RecipeSup.iHoraPatamar04);
                        command.Parameters.AddWithValue("$iMinutoPatamar04", RecipeSup.iMinutoPatamar04);
                        command.Parameters.AddWithValue("$iMinutoRampa05", RecipeSup.iMinutoRampa05);
                        command.Parameters.AddWithValue("$dTemperaturaSP05", RecipeSup.dTemperaturaSP05);
                        command.Parameters.AddWithValue("$iHoraPatamar05", RecipeSup.iHoraPatamar05);
                        command.Parameters.AddWithValue("$iMinutoPatamar05", RecipeSup.iMinutoPatamar05);
                        command.Parameters.AddWithValue("$iMinutoRampa06", RecipeSup.iMinutoRampa06);
                        command.Parameters.AddWithValue("$dTemperaturaSP06", RecipeSup.dTemperaturaSP06);
                        command.Parameters.AddWithValue("$iHoraPatamar06", RecipeSup.iHoraPatamar06);
                        command.Parameters.AddWithValue("$iMinutoPatamar06", RecipeSup.iMinutoPatamar06);
                        command.Parameters.AddWithValue("$iMinutoRampa07", RecipeSup.iMinutoRampa07);
                        command.Parameters.AddWithValue("$dTemperaturaSP07", RecipeSup.dTemperaturaSP07);
                        command.Parameters.AddWithValue("$iHoraPatamar07", RecipeSup.iHoraPatamar07);
                        command.Parameters.AddWithValue("$iMinutoPatamar07", RecipeSup.iMinutoPatamar07);
                        command.Parameters.AddWithValue("$iMinutoRampa08", RecipeSup.iMinutoRampa08);
                        command.Parameters.AddWithValue("$dTemperaturaSP08", RecipeSup.dTemperaturaSP08);
                        command.Parameters.AddWithValue("$iHoraPatamar08", RecipeSup.iHoraPatamar08);
                        command.Parameters.AddWithValue("$iMinutoPatamar08", RecipeSup.iMinutoPatamar08);
                        command.Parameters.AddWithValue("$iBombaPatamar01", RecipeSup.iBombaPatamar01);
                        command.Parameters.AddWithValue("$iBombaPatamar02", RecipeSup.iBombaPatamar02);
                        command.Parameters.AddWithValue("$iBombaPatamar03", RecipeSup.iBombaPatamar03);
                        command.Parameters.AddWithValue("$iBombaPatamar04", RecipeSup.iBombaPatamar04);
                        command.Parameters.AddWithValue("$iBombaPatamar05", RecipeSup.iBombaPatamar05);
                        command.Parameters.AddWithValue("$iBombaPatamar06", RecipeSup.iBombaPatamar06);
                        command.Parameters.AddWithValue("$iBombaPatamar07", RecipeSup.iBombaPatamar07);
                        command.Parameters.AddWithValue("$iBombaPatamar08", RecipeSup.iBombaPatamar08);
                        command.Parameters.AddWithValue("$iTempoBombaFim", RecipeSup.iTempoBombaFim);

                        command.ExecuteNonQuery();
                    });
                    return true;
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Atualiza uma receita específica no banco de dados.
        /// </summary>
        /// <param name="RecipeName">Nome da Receita que sera deletada </param>
        /// <param name="db_RecipeName">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        ///

        public async Task<Data_RecipeSup?> SelectRecipeAsync(string RecipeName, string db_RecipeName)
        {
            try
            {
                return null;
            }
            catch
            {
                return null;
            }
        }


        public async Task<bool?> DeleteRecipeAsync(string RecipeName, string db_RecipeName)
        {
            try
            {
                return await Task.Run(async () =>
                {
                    if (string.IsNullOrEmpty(RecipeName) || string.IsNullOrEmpty(db_RecipeName))
                    {
                        return false;
                    }
                    else
                    {
                        string db_File = $"{db_RecipeName}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        bool ExistDataBase = await ExistDatabaseAsync(db_RecipeName) ?? false;
                        if(!ExistDataBase)
                        {
                            return false;
                        }
                        else
                        {
                            using var connection = new SqliteConnection($"Data Source={dbPath}");
                            connection.Open();
                            using var command = connection.CreateCommand();
                            command.CommandText = $@"DELETE FROM {db_RecipeName} WHERE sName = $sName;";
                            command.Parameters.AddWithValue("$sName", RecipeName);
                            int? rowsAffected = command.ExecuteNonQuery();
                            return ((rowsAffected ?? 0) > 0);
                        }
                    }
                });
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Atualiza uma receita específica no banco de dados.
        /// </summary>
        /// <param name="recipe">Objeto contendo os novos dados da receita a serem salvos.</param>
        /// <param name="db_Name">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_Recipe").</param>
        /// <param name="NameRecipe">Nome da receita existente que será atualizada com os novos dados.</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool> UpdateRecipeAsync(string db_Name, string Table_Name, string NameRecipe)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (string.IsNullOrEmpty(db_Name) || string.IsNullOrEmpty(NameRecipe) || string.IsNullOrEmpty(Table_Name))
                    {
                        return false;
                    }
                    else
                    {
                        string db_File = $"{db_Name}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        using var connection = new SqliteConnection($"Data Source={dbPath}");
                        connection.Open();

                        using var command = connection.CreateCommand();
                        command.CommandText =
                        $@"
                        UPDATE {Table_Name}
                        SET
                            iMinutoRampa01 = $iMinutoRampa01,
                            rTemperaturaSP01 = $dTemperaturaSP01,
                            iHoraPatamar01 = $iHoraPatamar01,
                            iMinutoPatamar01 = $iMinutoPatamar01,
                            iMinutoRampa02 = $iMinutoRampa02,
                            rTemperaturaSP02 = $dTemperaturaSP02,
                            iHoraPatamar02 = $iHoraPatamar02,
                            iMinutoPatamar02 = $iMinutoPatamar02,
                            iMinutoRampa03 = $iMinutoRampa03,
                            rTemperaturaSP03 = $dTemperaturaSP03,
                            iHoraPatamar03 = $iHoraPatamar03,
                            iMinutoPatamar03 = $iMinutoPatamar03,
                            iMinutoRampa04 = $iMinutoRampa04,
                            rTemperaturaSP04 = $dTemperaturaSP04,
                            iHoraPatamar04 = $iHoraPatamar04,
                            iMinutoPatamar04 = $iMinutoPatamar04,
                            iMinutoRampa05 = $iMinutoRampa05,
                            rTemperaturaSP05 = $dTemperaturaSP05,
                            iHoraPatamar05 = $iHoraPatamar05,
                            iMinutoPatamar05 = $iMinutoPatamar05,
                            iMinutoRampa06 = $iMinutoRampa06,
                            rTemperaturaSP06 = $dTemperaturaSP06,
                            iHoraPatamar06 = $iHoraPatamar06,
                            iMinutoPatamar06 = $iMinutoPatamar06,
                            iMinutoRampa07 = $iMinutoRampa07,
                            rTemperaturaSP07 = $dTemperaturaSP07,
                            iHoraPatamar07 = $iHoraPatamar07,
                            iMinutoPatamar07 = $iMinutoPatamar07,
                            iMinutoRampa08 = $iMinutoRampa08,
                            rTemperaturaSP08 = $dTemperaturaSP08,
                            iHoraPatamar08 = $iHoraPatamar08,
                            iMinutoPatamar08 = $iMinutoPatamar08,
                            iBombaPatamar01 = $iBombaPatamar01,
                            iBombaPatamar02 = $iBombaPatamar02,
                            iBombaPatamar03 = $iBombaPatamar03,
                            iBombaPatamar04 = $iBombaPatamar04,
                            iBombaPatamar05 = $iBombaPatamar05,
                            iBombaPatamar06 = $iBombaPatamar06,
                            iBombaPatamar07 = $iBombaPatamar07,
                            iBombaPatamar08 = $iBombaPatamar08,
                            iTempoBombaFim = $iTempoBombaFim
                        WHERE sName = $sName;
                    ";

                        command.Parameters.AddWithValue("$sName", NameRecipe);
                        command.Parameters.AddWithValue("$iMinutoRampa01", RecipeSup.iMinutoRampa01);
                        command.Parameters.AddWithValue("$dTemperaturaSP01", RecipeSup.dTemperaturaSP01);
                        command.Parameters.AddWithValue("$iHoraPatamar01", RecipeSup.iHoraPatamar01);
                        command.Parameters.AddWithValue("$iMinutoPatamar01", RecipeSup.iMinutoPatamar01);
                        command.Parameters.AddWithValue("$iMinutoRampa02", RecipeSup.iMinutoRampa02);
                        command.Parameters.AddWithValue("$dTemperaturaSP02", RecipeSup.dTemperaturaSP02);
                        command.Parameters.AddWithValue("$iHoraPatamar02", RecipeSup.iHoraPatamar02);
                        command.Parameters.AddWithValue("$iMinutoPatamar02", RecipeSup.iMinutoPatamar02);
                        command.Parameters.AddWithValue("$iMinutoRampa03", RecipeSup.iMinutoRampa03);
                        command.Parameters.AddWithValue("$dTemperaturaSP03", RecipeSup.dTemperaturaSP03);
                        command.Parameters.AddWithValue("$iHoraPatamar03", RecipeSup.iHoraPatamar03);
                        command.Parameters.AddWithValue("$iMinutoPatamar03", RecipeSup.iMinutoPatamar03);
                        command.Parameters.AddWithValue("$iMinutoRampa04", RecipeSup.iMinutoRampa04);
                        command.Parameters.AddWithValue("$dTemperaturaSP04", RecipeSup.dTemperaturaSP04);
                        command.Parameters.AddWithValue("$iHoraPatamar04", RecipeSup.iHoraPatamar04);
                        command.Parameters.AddWithValue("$iMinutoPatamar04", RecipeSup.iMinutoPatamar04);
                        command.Parameters.AddWithValue("$iMinutoRampa05", RecipeSup.iMinutoRampa05);
                        command.Parameters.AddWithValue("$dTemperaturaSP05", RecipeSup.dTemperaturaSP05);
                        command.Parameters.AddWithValue("$iHoraPatamar05", RecipeSup.iHoraPatamar05);
                        command.Parameters.AddWithValue("$iMinutoPatamar05", RecipeSup.iMinutoPatamar05);
                        command.Parameters.AddWithValue("$iMinutoRampa06", RecipeSup.iMinutoRampa06);
                        command.Parameters.AddWithValue("$dTemperaturaSP06", RecipeSup.dTemperaturaSP06);
                        command.Parameters.AddWithValue("$iHoraPatamar06", RecipeSup.iHoraPatamar06);
                        command.Parameters.AddWithValue("$iMinutoPatamar06", RecipeSup.iMinutoPatamar06);
                        command.Parameters.AddWithValue("$iMinutoRampa07", RecipeSup.iMinutoRampa07);
                        command.Parameters.AddWithValue("$dTemperaturaSP07", RecipeSup.dTemperaturaSP07);
                        command.Parameters.AddWithValue("$iHoraPatamar07", RecipeSup.iHoraPatamar07);
                        command.Parameters.AddWithValue("$iMinutoPatamar07", RecipeSup.iMinutoPatamar07);
                        command.Parameters.AddWithValue("$iMinutoRampa08", RecipeSup.iMinutoRampa08);
                        command.Parameters.AddWithValue("$dTemperaturaSP08", RecipeSup.dTemperaturaSP08);
                        command.Parameters.AddWithValue("$iHoraPatamar08", RecipeSup.iHoraPatamar08);
                        command.Parameters.AddWithValue("$iMinutoPatamar08", RecipeSup.iMinutoPatamar08);
                        command.Parameters.AddWithValue("$iBombaPatamar01", RecipeSup.iBombaPatamar01);
                        command.Parameters.AddWithValue("$iBombaPatamar02", RecipeSup.iBombaPatamar02);
                        command.Parameters.AddWithValue("$iBombaPatamar03", RecipeSup.iBombaPatamar03);
                        command.Parameters.AddWithValue("$iBombaPatamar04", RecipeSup.iBombaPatamar04);
                        command.Parameters.AddWithValue("$iBombaPatamar05", RecipeSup.iBombaPatamar05);
                        command.Parameters.AddWithValue("$iBombaPatamar06", RecipeSup.iBombaPatamar06);
                        command.Parameters.AddWithValue("$iBombaPatamar07", RecipeSup.iBombaPatamar07);
                        command.Parameters.AddWithValue("$iBombaPatamar08", RecipeSup.iBombaPatamar08);
                        command.Parameters.AddWithValue("$iTempoBombaFim", RecipeSup.iTempoBombaFim);

                        command.ExecuteNonQuery();
                        return true;
                    }
                });
            }
            catch
            {
                return false;
            }

        }

        public Data_RecipeSup RecipeSup { get; set; } = new Data_RecipeSup();
        public class Data_RecipeSup
        {

            public string sName { get; set; }
            public int iMinutoRampa01 { get; set; }
            public double dTemperaturaSP01 { get; set; }
            public int iHoraPatamar01 { get; set; }
            public int iMinutoPatamar01 { get; set; }
            public int iMinutoRampa02 { get; set; }
            public double dTemperaturaSP02 { get; set; }
            public int iHoraPatamar02 { get; set; }
            public int iMinutoPatamar02 { get; set; }
            public int iMinutoRampa03 { get; set; }
            public double dTemperaturaSP03 { get; set; }
            public int iHoraPatamar03 { get; set; }
            public int iMinutoPatamar03 { get; set; }
            public int iMinutoRampa04 { get; set; }
            public double dTemperaturaSP04 { get; set; }
            public int iHoraPatamar04 { get; set; }
            public int iMinutoPatamar04 { get; set; }
            public int iMinutoRampa05 { get; set; }
            public double dTemperaturaSP05 { get; set; }
            public int iHoraPatamar05 { get; set; }
            public int iMinutoPatamar05 { get; set; }
            public int iMinutoRampa06 { get; set; }
            public double dTemperaturaSP06 { get; set; }
            public int iHoraPatamar06 { get; set; }
            public int iMinutoPatamar06 { get; set; }
            public int iMinutoRampa07 { get; set; }
            public double dTemperaturaSP07 { get; set; }
            public int iHoraPatamar07 { get; set; }
            public int iMinutoPatamar07 { get; set; }
            public int iMinutoRampa08 { get; set; }
            public double dTemperaturaSP08 { get; set; }
            public int iHoraPatamar08 { get; set; }
            public int iMinutoPatamar08 { get; set; }
            public int iBombaPatamar01 { get; set; }
            public int iBombaPatamar02 { get; set; }
            public int iBombaPatamar03 { get; set; }
            public int iBombaPatamar04 { get; set; }
            public int iBombaPatamar05 { get; set; }
            public int iBombaPatamar06 { get; set; }
            public int iBombaPatamar07 { get; set; }
            public int iBombaPatamar08 { get; set; }
            public int iTempoBombaFim { get; set; }

        }


    }
}
