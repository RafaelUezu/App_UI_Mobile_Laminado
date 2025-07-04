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
        }

        public ICommand Button_SaveOpcUaConfig_Command => new Command(() =>
        {
            db_ConfSuper _dbConfSuper = new db_ConfSuper();
            _dbConfSuper.LoadConfigAsync();
            OnStartValue();
        });

        public void AtualizaValores()
        {
        }
    }
}
