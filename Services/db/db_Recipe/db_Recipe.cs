﻿using System;
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
        /// <param name="db_RecipeName">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        /// 
        public async Task<bool?> CreateDatabaseIfNotExistsAsync(string db_RecipeName)
        {
            try
            {
                if (string.IsNullOrEmpty(db_RecipeName))
                {
                    return false;
                }
                else
                {
                    await Task.Run(() =>
                    {
                        string db_File = $"{db_RecipeName}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        if (!File.Exists(dbPath))
                        {
                            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
                            {
                                connection.Open();
                                var command = connection.CreateCommand();
                                command.CommandText =
                                $@"
                                CREATE TABLE IF NOT EXISTS {db_RecipeName} (
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
        /// <param name="db_RecipeName">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        /// 
        public async Task<bool?> InsertRecipeAsync(Data_RecipeSup recipe, string db_RecipeName)
        {
            try
            {
                if (recipe == null || string.IsNullOrEmpty(db_RecipeName))
                {
                    return false;
                }
                else
                {
                    await Task.Run(() =>
                    {
                        string db_File = $"{db_RecipeName}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        using var connection = new SqliteConnection($"Data Source={dbPath}");
                        connection.Open();
                        using var command = connection.CreateCommand();
                        command.CommandText =
                        $@"
                        INSERT INTO {db_RecipeName} (
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
                        command.Parameters.AddWithValue("$sName", recipe.sName);
                        command.Parameters.AddWithValue("$iMinutoRampa01", recipe.iMinutoRampa01);
                        command.Parameters.AddWithValue("$dTemperaturaSP01", recipe.dTemperaturaSP01);
                        command.Parameters.AddWithValue("$iHoraPatamar01", recipe.iHoraPatamar01);
                        command.Parameters.AddWithValue("$iMinutoPatamar01", recipe.iMinutoPatamar01);
                        command.Parameters.AddWithValue("$iMinutoRampa02", recipe.iMinutoRampa02);
                        command.Parameters.AddWithValue("$dTemperaturaSP02", recipe.dTemperaturaSP02);
                        command.Parameters.AddWithValue("$iHoraPatamar02", recipe.iHoraPatamar02);
                        command.Parameters.AddWithValue("$iMinutoPatamar02", recipe.iMinutoPatamar02);
                        command.Parameters.AddWithValue("$iMinutoRampa03", recipe.iMinutoRampa03);
                        command.Parameters.AddWithValue("$dTemperaturaSP03", recipe.dTemperaturaSP03);
                        command.Parameters.AddWithValue("$iHoraPatamar03", recipe.iHoraPatamar03);
                        command.Parameters.AddWithValue("$iMinutoPatamar03", recipe.iMinutoPatamar03);
                        command.Parameters.AddWithValue("$iMinutoRampa04", recipe.iMinutoRampa04);
                        command.Parameters.AddWithValue("$dTemperaturaSP04", recipe.dTemperaturaSP04);
                        command.Parameters.AddWithValue("$iHoraPatamar04", recipe.iHoraPatamar04);
                        command.Parameters.AddWithValue("$iMinutoPatamar04", recipe.iMinutoPatamar04);
                        command.Parameters.AddWithValue("$iMinutoRampa05", recipe.iMinutoRampa05);
                        command.Parameters.AddWithValue("$dTemperaturaSP05", recipe.dTemperaturaSP05);
                        command.Parameters.AddWithValue("$iHoraPatamar05", recipe.iHoraPatamar05);
                        command.Parameters.AddWithValue("$iMinutoPatamar05", recipe.iMinutoPatamar05);
                        command.Parameters.AddWithValue("$iMinutoRampa06", recipe.iMinutoRampa06);
                        command.Parameters.AddWithValue("$dTemperaturaSP06", recipe.dTemperaturaSP06);
                        command.Parameters.AddWithValue("$iHoraPatamar06", recipe.iHoraPatamar06);
                        command.Parameters.AddWithValue("$iMinutoPatamar06", recipe.iMinutoPatamar06);
                        command.Parameters.AddWithValue("$iMinutoRampa07", recipe.iMinutoRampa07);
                        command.Parameters.AddWithValue("$dTemperaturaSP07", recipe.dTemperaturaSP07);
                        command.Parameters.AddWithValue("$iHoraPatamar07", recipe.iHoraPatamar07);
                        command.Parameters.AddWithValue("$iMinutoPatamar07", recipe.iMinutoPatamar07);
                        command.Parameters.AddWithValue("$iMinutoRampa08", recipe.iMinutoRampa08);
                        command.Parameters.AddWithValue("$dTemperaturaSP08", recipe.dTemperaturaSP08);
                        command.Parameters.AddWithValue("$iHoraPatamar08", recipe.iHoraPatamar08);
                        command.Parameters.AddWithValue("$iMinutoPatamar08", recipe.iMinutoPatamar08);
                        command.Parameters.AddWithValue("$iBombaPatamar01", recipe.iBombaPatamar01);
                        command.Parameters.AddWithValue("$iBombaPatamar02", recipe.iBombaPatamar02);
                        command.Parameters.AddWithValue("$iBombaPatamar03", recipe.iBombaPatamar03);
                        command.Parameters.AddWithValue("$iBombaPatamar04", recipe.iBombaPatamar04);
                        command.Parameters.AddWithValue("$iBombaPatamar05", recipe.iBombaPatamar05);
                        command.Parameters.AddWithValue("$iBombaPatamar06", recipe.iBombaPatamar06);
                        command.Parameters.AddWithValue("$iBombaPatamar07", recipe.iBombaPatamar07);
                        command.Parameters.AddWithValue("$iBombaPatamar08", recipe.iBombaPatamar08);
                        command.Parameters.AddWithValue("$iTempoBombaFim", recipe.iTempoBombaFim);

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
        /// <param name="db_RecipeName">Nome do arquivo ou identificador do banco de dados de receitas (ex.: "db_RecipeSup").</param>
        /// <param name="NameRecipeEdit">Nome da receita existente que será atualizada com os novos dados.</param>
        /// <returns>Retorna true se a atualização for bem-sucedida; caso contrário, false.</returns>
        public async Task<bool> UpdateRecipeAsync(Data_RecipeSup recipe, string db_RecipeName, string NameRecipeEdit)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (string.IsNullOrEmpty(db_RecipeName) || string.IsNullOrEmpty(NameRecipeEdit) || recipe == null)
                    {
                        return false;
                    }
                    else
                    {
                        string db_File = $"{db_RecipeName}.db";
                        string dbPath = Path.Combine(FileSystem.AppDataDirectory, db_File);
                        using var connection = new SqliteConnection($"Data Source={dbPath}");
                        connection.Open();

                        using var command = connection.CreateCommand();
                        command.CommandText =
                        $@"
                        UPDATE {db_RecipeName}
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

                        command.Parameters.AddWithValue("$sName", NameRecipeEdit);
                        command.Parameters.AddWithValue("$iMinutoRampa01", recipe.iMinutoRampa01);
                        command.Parameters.AddWithValue("$rTemperaturaSP01", recipe.dTemperaturaSP01);
                        command.Parameters.AddWithValue("$iHoraPatamar01", recipe.iHoraPatamar01);
                        command.Parameters.AddWithValue("$iMinutoPatamar01", recipe.iMinutoPatamar01);
                        command.Parameters.AddWithValue("$iMinutoRampa02", recipe.iMinutoRampa02);
                        command.Parameters.AddWithValue("$rTemperaturaSP02", recipe.dTemperaturaSP02);
                        command.Parameters.AddWithValue("$iHoraPatamar02", recipe.iHoraPatamar02);
                        command.Parameters.AddWithValue("$iMinutoPatamar02", recipe.iMinutoPatamar02);
                        command.Parameters.AddWithValue("$iMinutoRampa03", recipe.iMinutoRampa03);
                        command.Parameters.AddWithValue("$rTemperaturaSP03", recipe.dTemperaturaSP03);
                        command.Parameters.AddWithValue("$iHoraPatamar03", recipe.iHoraPatamar03);
                        command.Parameters.AddWithValue("$iMinutoPatamar03", recipe.iMinutoPatamar03);
                        command.Parameters.AddWithValue("$iMinutoRampa04", recipe.iMinutoRampa04);
                        command.Parameters.AddWithValue("$rTemperaturaSP04", recipe.dTemperaturaSP04);
                        command.Parameters.AddWithValue("$iHoraPatamar04", recipe.iHoraPatamar04);
                        command.Parameters.AddWithValue("$iMinutoPatamar04", recipe.iMinutoPatamar04);
                        command.Parameters.AddWithValue("$iMinutoRampa05", recipe.iMinutoRampa05);
                        command.Parameters.AddWithValue("$rTemperaturaSP05", recipe.dTemperaturaSP05);
                        command.Parameters.AddWithValue("$iHoraPatamar05", recipe.iHoraPatamar05);
                        command.Parameters.AddWithValue("$iMinutoPatamar05", recipe.iMinutoPatamar05);
                        command.Parameters.AddWithValue("$iMinutoRampa06", recipe.iMinutoRampa06);
                        command.Parameters.AddWithValue("$rTemperaturaSP06", recipe.dTemperaturaSP06);
                        command.Parameters.AddWithValue("$iHoraPatamar06", recipe.iHoraPatamar06);
                        command.Parameters.AddWithValue("$iMinutoPatamar06", recipe.iMinutoPatamar06);
                        command.Parameters.AddWithValue("$iMinutoRampa07", recipe.iMinutoRampa07);
                        command.Parameters.AddWithValue("$rTemperaturaSP07", recipe.dTemperaturaSP07);
                        command.Parameters.AddWithValue("$iHoraPatamar07", recipe.iHoraPatamar07);
                        command.Parameters.AddWithValue("$iMinutoPatamar07", recipe.iMinutoPatamar07);
                        command.Parameters.AddWithValue("$iMinutoRampa08", recipe.iMinutoRampa08);
                        command.Parameters.AddWithValue("$rTemperaturaSP08", recipe.dTemperaturaSP08);
                        command.Parameters.AddWithValue("$iHoraPatamar08", recipe.iHoraPatamar08);
                        command.Parameters.AddWithValue("$iMinutoPatamar08", recipe.iMinutoPatamar08);
                        command.Parameters.AddWithValue("$iBombaPatamar01", recipe.iBombaPatamar01);
                        command.Parameters.AddWithValue("$iBombaPatamar02", recipe.iBombaPatamar02);
                        command.Parameters.AddWithValue("$iBombaPatamar03", recipe.iBombaPatamar03);
                        command.Parameters.AddWithValue("$iBombaPatamar04", recipe.iBombaPatamar04);
                        command.Parameters.AddWithValue("$iBombaPatamar05", recipe.iBombaPatamar05);
                        command.Parameters.AddWithValue("$iBombaPatamar06", recipe.iBombaPatamar06);
                        command.Parameters.AddWithValue("$iBombaPatamar07", recipe.iBombaPatamar07);
                        command.Parameters.AddWithValue("$iBombaPatamar08", recipe.iBombaPatamar08);
                        command.Parameters.AddWithValue("$iTempoBombaFim", recipe.iTempoBombaFim);

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
