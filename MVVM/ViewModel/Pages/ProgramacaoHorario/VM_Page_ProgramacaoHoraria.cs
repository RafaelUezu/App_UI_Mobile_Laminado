using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Drivers.Opcua;


namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.ProgramacaoHorario
{
    public partial class VM_Page_ProgramacaoHoraria : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public VM_Page_ProgramacaoHoraria()
        {
            OpcUaEvents.LeituraFinalizadaAsync += () =>
            {
                OnLeituraFinalizada();
                return Task.CompletedTask;

            };
        }
        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaValores);
            MainThread.BeginInvokeOnMainThread(EscreveValores);
        }
        public void AtualizaValores()
        {
            uLdomingo_Read = GVL.Opcua.GVL_Permanentes.uLdomingo.Read ?? 0;
            uLsegunda_Read = GVL.Opcua.GVL_Permanentes.uLsegunda.Read ?? 0;
            uLterca_Read = GVL.Opcua.GVL_Permanentes.uLterca.Read ?? 0;
            uLquarta_Read = GVL.Opcua.GVL_Permanentes.uLquarta.Read ?? 0;
            uLquinta_Read = GVL.Opcua.GVL_Permanentes.uLquinta.Read ?? 0;
            uLsexta_Read = GVL.Opcua.GVL_Permanentes.uLsexta.Read ?? 0;
            uLsabado_Read = GVL.Opcua.GVL_Permanentes.uLsabado.Read ?? 0;

            uHorProgramado_Read = GVL.Opcua.GVL_Permanentes.uHorProgramado.Read ?? 0;
            uMinProgramado_Read = GVL.Opcua.GVL_Permanentes.uMinProgramado.Read ?? 0;
        }

        public void EscreveValores()
        {
        

        }
    }
}
