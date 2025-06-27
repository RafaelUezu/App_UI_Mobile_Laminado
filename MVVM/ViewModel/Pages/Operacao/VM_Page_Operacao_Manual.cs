using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Drivers.Opcua;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_Manual : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Operacao_Manual()
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
        }
        public void AtualizaValores()
        {
            xVacuo01Ok_Read = GVL.Opcua.GVL_ClpIhm.xVacuo01Ok.Read ?? false;
            ImgMotor5_Read = GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.GetRead(5) ?? false;
            sMotorBombaVacuo01_Status_Legend = ImgMotor5_Read ? "Com Vácuo" : "Sem Vácuo";
            cMotorBombaVacuo01_Status_Color = ImgMotor5_Read ? Colors.Green: Colors.Red;
            fMotorBombaVacuo01_Freq_Read = ImgMotor5_Read ? 60.0f : 0.0f;
            sMotorBombaVacuo01_Cmd_Legend = ImgMotor5_Read ? "Desligar" : "Ligar";
            wStatusPortaEsq_Read = GVL.Opcua.GVL_ClpIhm.wStatusPortaEsq.Read ?? 0;
            ImgGeral7_Read = GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(7) ?? false;
            sBtAbreFechaPortaSup_Legend = ImgGeral7_Read ? "Abrir" : "Fechar";
            iTermoparSup01_Read = GVL.Opcua.GVL_ClpIhm.iTermoparSup01.Read ?? 0;
            fTermoparSup01_Read = ((float)iTermoparSup01_Read)/10;
            rTemperaturaMinimaSup_Read = GVL.Opcua.GVL_Permanentes.rTemperaturaMinimaSup.Read ?? 0.0f;
            if(rTemperaturaMinimaSup_Read != 0.0f)
            {
                cTermoparSup01_Color = fTermoparSup01_Read < rTemperaturaMinimaSup_Read ? Colors.Blue : Colors.Red;
            }
            else
            {
                cTermoparSup01_Color = Colors.Gray;
            }
            ImgMotor3_Read = GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.GetRead(3) ?? false;
            cVentSup_Status_Color = ImgMotor3_Read ? Color.FromArgb("#6000FF00") : Colors.Transparent;
            rFrequenciaAtualVentSup_Read = GVL.Opcua.GVL_ClpIhm.rFrequenciaAtualVentSup.Read ?? 0.0f;
            sVentSup_Status_Legend = ImgMotor3_Read ? "Desligar" : "Ligar";
            uStatusAquecimentoSup_Read = GVL.Opcua.GVL_ClpIhm.uStatusAquecimentoSup.Read ?? 0;

            uStatusAquecimentoCicloSup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa01Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa02Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa03Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa04Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa05Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa06Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa07Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusRampa08Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar01Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar02Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar03Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar04Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar05Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar06Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar07Sup.Read ?? 0
                                            + GVL.Opcua.GVL_ClpIhm.wStatusPatamar08Sup.Read ?? 0;


        }



    }
}
