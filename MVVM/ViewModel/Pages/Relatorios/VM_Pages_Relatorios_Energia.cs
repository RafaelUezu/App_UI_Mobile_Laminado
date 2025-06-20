using MAUI_Opcua.Services.Drivers.Opcua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Drivers.Opcua;
using MAUI_Opcua.Services.Communication.Variable;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Relatorios
{
    public partial class VM_Pages_Relatorios_Energia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Pages_Relatorios_Energia()
        {
            OpcUaEvents.LeituraFinalizadaAsync += () =>
            {
                OnLeituraFinalizada();
                return Task.CompletedTask;
            };
        }

        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaVariaveis);
        }

        public void AtualizaVariaveis()
        {
            fTensaoAvgLL = GVL.Opcua.GVL_Energia.fTensaoAvgLL.Read ?? 0.0f;
            fCorrenteAvg = GVL.Opcua.GVL_Energia.fCorrenteAvg.Read ?? 0.0f;
            fPotenciaAtivaTotal = GVL.Opcua.GVL_Energia.fPotenciaAtivaTotal.Read ?? 0.0f;
            fEnergiaAtivaAcumulada = GVL.Opcua.GVL_Energia.fEnergiaAtivaAcumulada.Read ?? 0.0f;
            fAtualDemanda = GVL.Opcua.GVL_Energia.fAtualDemanda.Read ?? 0.0f;
            fPicoDemanda = GVL.Opcua.GVL_Energia.fPicoDemanda.Read ?? 0.0f;
            fFatorPotenciaTotal = GVL.Opcua.GVL_Energia.fFatorPotenciaTotal.Read ?? 0.0f;
            fFrequencia = GVL.Opcua.GVL_Energia.fFrequencia.Read ?? 0.0f;

            fTensaoAB = GVL.Opcua.GVL_Energia.fTensaoAB.Read ?? 0.0f;
            fTensaoBC = GVL.Opcua.GVL_Energia.fTensaoBC.Read ?? 0.0f;
            fTensaoCA = GVL.Opcua.GVL_Energia.fTensaoCA.Read ?? 0.0f;
            

            fTensaoMaximaAB = GVL.Opcua.GVL_Energia.fTensaoMaximaAB.Read ?? 0.0f;
            fTensaoMaximaBC = GVL.Opcua.GVL_Energia.fTensaoMaximaBC.Read ?? 0.0f;
            fTensaoMaximaCA = GVL.Opcua.GVL_Energia.fTensaoMaximaCA.Read ?? 0.0f;
            

            fTensaoAN = GVL.Opcua.GVL_Energia.fTensaoAN.Read ?? 0.0f;
            fTensaoBN = GVL.Opcua.GVL_Energia.fTensaoBN.Read ?? 0.0f;
            fTensaoCN = GVL.Opcua.GVL_Energia.fTensaoCN.Read ?? 0.0f;

            fTensaoMaximaAN = GVL.Opcua.GVL_Energia.fTensaoMaximaAN.Read ?? 0.0f;
            fTensaoMaximaBN = GVL.Opcua.GVL_Energia.fTensaoMaximaBN.Read ?? 0.0f;
            fTensaoMaximaCN = GVL.Opcua.GVL_Energia.fTensaoMaximaCN.Read ?? 0.0f;

            fCorrenteFaseA = GVL.Opcua.GVL_Energia.fCorrenteFaseA.Read ?? 0.0f;
            fCorrenteFaseB = GVL.Opcua.GVL_Energia.fCorrenteFaseB.Read ?? 0.0f;
            fCorrenteFaseC = GVL.Opcua.GVL_Energia.fCorrenteFaseC.Read ?? 0.0f;
            fCorrenteNeutro = GVL.Opcua.GVL_Energia.fCorrenteNeutro.Read ?? 0.0f;
            fCorrenteMaximaFaseA = GVL.Opcua.GVL_Energia.fCorrenteMaximaFaseA.Read ?? 0.0f;
        }


    }
}
