using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Drivers.Opcua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App_UI_Mobile_Laminado.Services.db.db_ConfSuper;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Configuracao : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Manutencao_Configuracao()
        {
            OnStartValue();
            OpcUaEvents.LeituraFinalizadaAsync += () =>
            {
                OnLeituraFinalizada();
                return Task.CompletedTask;

            };
        }
        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaValores);
        }
        public void OnStartValue()
        {
            sUrlOpcUa_ReadWrite = GVL.ConfSuper.sUrlOpcUa.ReadWrite ?? "Error";
            iTimeOutPing_ReadWrite = GVL.ConfSuper.iTimeOutPing.ReadWrite ?? 0;
            iTimeRequest_ReadWrite = GVL.ConfSuper.iTimeRequest.ReadWrite ?? 0;
            iMaxAgeOpcUa_ReadWrite = GVL.ConfSuper.iMaxAgeOpcUa.ReadWrite ?? 0;
            iMedAgeOpcUa_ReadWrite = GVL.ConfSuper.iMedAgeOpcUa.ReadWrite ?? 0;
            iMinAgeOpcUa_ReadWrite = GVL.ConfSuper.iMinAgeOpcUa.ReadWrite ?? 0;
            iZeroAgeOpcUa_ReadWrite = GVL.ConfSuper.iZeroAgeOpcUa.ReadWrite ?? 0;
            iMaxTempRecipe_ReadWrite = GVL.ConfSuper.iMaxTempRecipe.ReadWrite ?? 0;
            iMinTempRecipe_ReadWrite = GVL.ConfSuper.iMinTempRecipe.ReadWrite ?? 0;
            iMaxTempOperation_ReadWrite = GVL.ConfSuper.iMaxTempOperation.ReadWrite ?? 0;
            iMinTempOperation_ReadWrite = GVL.ConfSuper.iMinTempOperation.ReadWrite ?? 0;



        }

        public ICommand Button_SaveOpcUaConfig_Command => new Command(async () =>
        {
            bool? Success = await SaveOpcUaConfigAsync();
            if (Success == true)
            {
                await Application.Current.MainPage.DisplayAlert("Salvamento", "Configuração salva com sucesso.", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Salvamento", "Falha ao salvar a configuração.", "Ok");
            }
        });
        public ICommand Button_ResetToDefaultConfSuper_Command => new Command(async () =>
        {
            bool? Success = await ResetToDefaultConfSuper();
            if (Success == true)
            {
                await Application.Current.MainPage.DisplayAlert("Reset", "Configuração restaurada com sucesso.", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Reset", "Falha ao restaurar a configuração.", "Ok");
            }
        });
        public ICommand Button_ResetToDefaultRecipe_Command => new Command(async () =>
        {

        });
        public ICommand Button_ResetToDefaultAlarms_Command => new Command(async () =>
        {

        });
        public ICommand Button_ResetToDefaultEvents_Command => new Command(async () =>
        {

        });
        public ICommand Button_ResetToDefaultReport_Command => new Command(async () =>
        {

        });


        private async Task<bool?> ResetToDefaultConfSuper()
        {
            try
            {
                db_ConfSuper _dbConfSuper = new db_ConfSuper();
                await _dbConfSuper.ResetToDefaultAsync();
                ConfSuperConfig newConfig = await _dbConfSuper.LoadConfigAsync();
                GVL.ConfSuper.sUrlOpcUa.ReadWrite = newConfig.sUrlOpcUa;
                GVL.ConfSuper.iTimeOutPing.ReadWrite = newConfig.iTimeOutPing;
                GVL.ConfSuper.iTimeRequest.ReadWrite = newConfig.iTimeRequest;
                GVL.ConfSuper.iMaxAgeOpcUa.ReadWrite = newConfig.iMaxAgeOpcUa;
                GVL.ConfSuper.iMedAgeOpcUa.ReadWrite = newConfig.iMedAgeOpcUa;
                GVL.ConfSuper.iMinAgeOpcUa.ReadWrite = newConfig.iMinAgeOpcUa;
                GVL.ConfSuper.iZeroAgeOpcUa.ReadWrite = newConfig.iZeroAgeOpcUa;
                GVL.ConfSuper.iMaxTempRecipe.ReadWrite = newConfig.iMaxTempRecipe;
                GVL.ConfSuper.iMinTempRecipe.ReadWrite = newConfig.iMinTempRecipe;
                GVL.ConfSuper.iMaxTempOperation.ReadWrite = newConfig.iMaxTempOperation;
                GVL.ConfSuper.iMinTempOperation.ReadWrite = newConfig.iMinTempOperation;
                OnStartValue();
                return true;
            }
            catch
            {
                return false;
            }

        }

        private async Task<bool?> SaveOpcUaConfigAsync()
        {
            try
            {
                db_ConfSuper _dbConfSuper = new db_ConfSuper();
                ConfSuperConfig config = new ConfSuperConfig
                {
                    sUrlOpcUa = sUrlOpcUa_ReadWrite,
                    iTimeOutPing = iTimeOutPing_ReadWrite,
                    iTimeRequest = iTimeRequest_ReadWrite,
                    iMaxAgeOpcUa = iMaxAgeOpcUa_ReadWrite,
                    iMedAgeOpcUa = iMedAgeOpcUa_ReadWrite,
                    iMinAgeOpcUa = iMinAgeOpcUa_ReadWrite,
                    iZeroAgeOpcUa = iZeroAgeOpcUa_ReadWrite,
                    iMaxTempRecipe = iMaxTempRecipe_ReadWrite,
                    iMinTempRecipe = iMinTempRecipe_ReadWrite,
                    iMaxTempOperation = iMaxTempOperation_ReadWrite,
                    iMinTempOperation = iMinTempOperation_ReadWrite
                };

                await _dbConfSuper.SaveConfigAsync(config);
                ConfSuperConfig newConfig = await _dbConfSuper.LoadConfigAsync();
                GVL.ConfSuper.sUrlOpcUa.ReadWrite = newConfig.sUrlOpcUa;
                GVL.ConfSuper.iTimeOutPing.ReadWrite = newConfig.iTimeOutPing;
                GVL.ConfSuper.iTimeRequest.ReadWrite = newConfig.iTimeRequest;
                GVL.ConfSuper.iMaxAgeOpcUa.ReadWrite = newConfig.iMaxAgeOpcUa;
                GVL.ConfSuper.iMedAgeOpcUa.ReadWrite = newConfig.iMedAgeOpcUa;
                GVL.ConfSuper.iMinAgeOpcUa.ReadWrite = newConfig.iMinAgeOpcUa;
                GVL.ConfSuper.iZeroAgeOpcUa.ReadWrite = newConfig.iZeroAgeOpcUa;
                GVL.ConfSuper.iMaxTempRecipe.ReadWrite = newConfig.iMaxTempRecipe;
                GVL.ConfSuper.iMinTempRecipe.ReadWrite = newConfig.iMinTempRecipe;
                GVL.ConfSuper.iMaxTempOperation.ReadWrite = newConfig.iMaxTempOperation;
                GVL.ConfSuper.iMinTempOperation.ReadWrite = newConfig.iMinTempOperation;

                OnStartValue();
                return true;
            }
            catch
            {
                return false;
            }

            
        }
        private void AtualizaValores()
        {
            iQueryTime_ReadWrite = GVL.ConfSuper.iQueryTime.ReadWrite ?? 0;
            sStatusOpcUa_ReadWrite = GVL.ConfSuper.sStatusOpcUa.ReadWrite ?? "Error";
        }
        private void EscreveValores()
        {

        }
    }
}
