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
    public partial class VM_Page_Operacao_SupervisaodosTempos : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Operacao_SupervisaodosTempos()
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

            rTempCxSupPatamar01_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar01.Read ?? 0F;
            rTempCxSupPatamar02_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar02.Read ?? 0F;
            rTempCxSupPatamar03_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar03.Read ?? 0F;
            rTempCxSupPatamar04_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar04.Read ?? 0F;
            rTempCxSupPatamar05_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar05.Read ?? 0F;
            rTempCxSupPatamar06_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar06.Read ?? 0F;
            rTempCxSupPatamar07_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar07.Read ?? 0F;
            rTempCxSupPatamar08_Read = GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar08.Read ?? 0F;

            iHorDecorRampa01Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa01Sup.Read ?? 0;
            iHorDecorRampa02Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa02Sup.Read ?? 0;
            iHorDecorRampa03Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa03Sup.Read ?? 0;
            iHorDecorRampa04Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa04Sup.Read ?? 0;
            iHorDecorRampa05Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa05Sup.Read ?? 0;
            iHorDecorRampa06Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa06Sup.Read ?? 0;
            iHorDecorRampa07Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa07Sup.Read ?? 0;
            iHorDecorRampa08Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorRampa08Sup.Read ?? 0;

            iMinDecorRampa01Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa01Sup.Read ?? 0;
            iMinDecorRampa02Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa02Sup.Read ?? 0;
            iMinDecorRampa03Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa03Sup.Read ?? 0;
            iMinDecorRampa04Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa04Sup.Read ?? 0;
            iMinDecorRampa05Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa05Sup.Read ?? 0;
            iMinDecorRampa06Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa06Sup.Read ?? 0;
            iMinDecorRampa07Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa07Sup.Read ?? 0;
            iMinDecorRampa08Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorRampa08Sup.Read ?? 0;

            iSegDecorRampa01Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa01Sup.Read ?? 0;
            iSegDecorRampa02Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa02Sup.Read ?? 0;
            iSegDecorRampa03Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa03Sup.Read ?? 0;
            iSegDecorRampa04Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa04Sup.Read ?? 0;
            iSegDecorRampa05Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa05Sup.Read ?? 0;
            iSegDecorRampa06Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa06Sup.Read ?? 0;
            iSegDecorRampa07Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa07Sup.Read ?? 0;
            iSegDecorRampa08Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorRampa08Sup.Read ?? 0;

            iHorDecorPatam01Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam01Sup.Read ?? 0;
            iHorDecorPatam02Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam02Sup.Read ?? 0;
            iHorDecorPatam03Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam03Sup.Read ?? 0;
            iHorDecorPatam04Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam04Sup.Read ?? 0;
            iHorDecorPatam05Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam05Sup.Read ?? 0;
            iHorDecorPatam06Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam06Sup.Read ?? 0;
            iHorDecorPatam07Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam07Sup.Read ?? 0;
            iHorDecorPatam08Sup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorPatam08Sup.Read ?? 0;

            iMinDecorPatam01Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam01Sup.Read ?? 0;
            iMinDecorPatam02Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam02Sup.Read ?? 0;
            iMinDecorPatam03Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam03Sup.Read ?? 0;
            iMinDecorPatam04Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam04Sup.Read ?? 0;
            iMinDecorPatam05Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam05Sup.Read ?? 0;
            iMinDecorPatam06Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam06Sup.Read ?? 0;
            iMinDecorPatam07Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam07Sup.Read ?? 0;
            iMinDecorPatam08Sup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorPatam08Sup.Read ?? 0;

            iSegDecorPatam01Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam01Sup.Read ?? 0;
            iSegDecorPatam02Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam02Sup.Read ?? 0;
            iSegDecorPatam03Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam03Sup.Read ?? 0;
            iSegDecorPatam04Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam04Sup.Read ?? 0;
            iSegDecorPatam05Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam05Sup.Read ?? 0;
            iSegDecorPatam06Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam06Sup.Read ?? 0;
            iSegDecorPatam07Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam07Sup.Read ?? 0;
            iSegDecorPatam08Sup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorPatam08Sup.Read ?? 0;

        }
        public void EscreveValores()
        {
            if (rTempCxSupPatamar01_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar01.Write = rTempCxSupPatamar01_Write.Value;
                rTempCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar02_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar02.Write = rTempCxSupPatamar02_Write.Value;
                rTempCxSupPatamar02_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar03_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar03.Write = rTempCxSupPatamar03_Write.Value;
                rTempCxSupPatamar03_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar04_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar04.Write = rTempCxSupPatamar04_Write.Value;
                rTempCxSupPatamar04_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar05_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar05.Write = rTempCxSupPatamar05_Write.Value;
                rTempCxSupPatamar05_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar06_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar06.Write = rTempCxSupPatamar06_Write.Value;
                rTempCxSupPatamar06_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar07_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar07.Write = rTempCxSupPatamar07_Write.Value;
                rTempCxSupPatamar07_Write = null; // Limpa o valor após escrita
            }
            if (rTempCxSupPatamar08_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar08.Write = rTempCxSupPatamar08_Write.Value;
                rTempCxSupPatamar08_Write = null; // Limpa o valor após escrita
            }

            if (iHorCxSupPatamar01_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Write = (Int16)(short)iHorCxSupPatamar01_Write.Value;
                iHorCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar01_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Write = (Int16)(short)iMinCxSupPatamar01_Write.Value;
                iMinCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
        }
    }

}
