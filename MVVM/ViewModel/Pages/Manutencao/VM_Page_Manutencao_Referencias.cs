using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_UI_Mobile_Laminado.Services.Communication.Variables;
using App_UI_Mobile_Laminado.Services.Drivers.Opcua;


namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Referencias : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public VM_Page_Manutencao_Referencias()
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
        Int16 Normalizacao = 10;
        private void AtualizaValores()
        {
            iTempoExaustorMinSup_Read = GVL.Opcua.GVL_Permanentes.iTempoExaustorMinSup.Read ?? 0;
            rTemperaturaMinimaSup_Read = GVL.Opcua.GVL_Permanentes.rTemperaturaMinimaSup.Read ?? 0;
            iTempoAberturaSup_Read = GVL.Opcua.GVL_Permanentes.iTempoAberturaSup.Read ?? 0;
            iFreqManCxSuperior_Read = (Int16)(((short?)GVL.Opcua.GVL_Permanentes.iFreqManCxSuperior.Read ?? 0)/10);

            iSpContHorProgB01_Read = GVL.Opcua.GVL_Permanentes.iSpContHorProgB01.Read ?? 0;
            iTemperaturaSegurancaSup_Read = (Int16)(((short?)GVL.Opcua.GVL_Permanentes.iTemperaturaSegurancaSup.Read ?? 0)/10);
        }

        private void EscreveValores()
        {
            if (iTempoExaustorMinSup_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.iTempoExaustorMinSup.Write = (Int16)iTempoExaustorMinSup_Write.Value;
                iTempoExaustorMinSup_Write = null;
            }
            if (rTemperaturaMinimaSup_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.rTemperaturaMinimaSup.Write = (float)rTemperaturaMinimaSup_Write.Value;
                rTemperaturaMinimaSup_Write = null;
            }
            if (iTempoAberturaSup_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.iTempoAberturaSup.Write = (Int16)iTempoAberturaSup_Write.Value;
                iTempoAberturaSup_Write = null;
            }
            if (iFreqManCxSuperior_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.iFreqManCxSuperior.Write = (Int16)((short)iFreqManCxSuperior_Write.Value/10);
                iFreqManCxSuperior_Write = null;
            }
            if (iSpContHorProgB01_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.iSpContHorProgB01.Write = (Int16)iSpContHorProgB01_Write.Value;
                iSpContHorProgB01_Write = null;
            }
            if (iTemperaturaSegurancaSup_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.iTemperaturaSegurancaSup.Write = (Int16)((short)iTemperaturaSegurancaSup_Write.Value/10);
                iTemperaturaSegurancaSup_Write = null;
            }
            /*
            rTemperaturaMinimaSup
            iTempoAberturaSup
            iFreqManCxSuperior
            iSpContHorProgB01
            iTemperaturaSegurancaSup
             */
        }
    }
}
