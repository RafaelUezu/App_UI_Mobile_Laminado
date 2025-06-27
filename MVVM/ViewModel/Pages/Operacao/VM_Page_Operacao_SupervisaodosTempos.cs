using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Drivers.Opcua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        // Remover depois de testar---------------------------------------------------
        /*
        private readonly System.Timers.Timer _timer;

        public VM_Page_Operacao_SupervisaodosTempos()
        {
            _timer = new System.Timers.Timer(200); // 200 ms
            _timer.Elapsed += Timer_Elapsed;
            _timer.AutoReset = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(OnLeituraFinalizada);
        }

        public void StartAtualizacaoDI()
        {
            _timer?.Start();
        }

        public void StopAtualizacaoDI()
        {
            _timer?.Stop();
        }
        */
        // Remover depois de testar---------------------------------------------------
        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaValores);
            MainThread.BeginInvokeOnMainThread(EscreveValores);
        }

        public void AtualizaValores()
        {
            //var stopwatch = Stopwatch.StartNew();
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

            iMinCxSupRampa01_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa01.Read ?? 0;
            iMinCxSupRampa02_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa02.Read ?? 0;
            iMinCxSupRampa03_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa03.Read ?? 0;
            iMinCxSupRampa04_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa04.Read ?? 0;
            iMinCxSupRampa05_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa05.Read ?? 0;
            iMinCxSupRampa06_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa06.Read ?? 0;
            iMinCxSupRampa07_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa07.Read ?? 0;
            iMinCxSupRampa08_Read = GVL.Opcua.GVL_Permanentes.iMinCxSupRampa08.Read ?? 0;

            iHorCxSupPatamar01_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Read ?? 0;
            iHorCxSupPatamar02_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar02.Read ?? 0;
            iHorCxSupPatamar03_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar03.Read ?? 0;
            iHorCxSupPatamar04_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar04.Read ?? 0;
            iHorCxSupPatamar05_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar05.Read ?? 0;
            iHorCxSupPatamar06_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar06.Read ?? 0;
            iHorCxSupPatamar07_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar07.Read ?? 0;
            iHorCxSupPatamar08_Read = GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar08.Read ?? 0;

            iMinCxSupPatamar01_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Read ?? 0;
            iMinCxSupPatamar02_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar02.Read ?? 0;
            iMinCxSupPatamar03_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar03.Read ?? 0;
            iMinCxSupPatamar04_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar04.Read ?? 0;
            iMinCxSupPatamar05_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar05.Read ?? 0;
            iMinCxSupPatamar06_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar06.Read ?? 0;
            iMinCxSupPatamar07_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar07.Read ?? 0;
            iMinCxSupPatamar08_Read = GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar08.Read ?? 0;

            uStatusAquecimentoSup_Read = GVL.Opcua.GVL_ClpIhm.uStatusAquecimentoSup.Read ?? 0;
            wStatusRampa01Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa01Sup.Read ?? 0;
            wStatusRampa02Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa02Sup.Read ?? 0;
            wStatusRampa03Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa03Sup.Read ?? 0;
            wStatusRampa04Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa04Sup.Read ?? 0;
            wStatusRampa05Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa05Sup.Read ?? 0;
            wStatusRampa06Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa06Sup.Read ?? 0;
            wStatusRampa07Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa07Sup.Read ?? 0;
            wStatusRampa08Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusRampa08Sup.Read ?? 0;

            wStatusPatamar01Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar01Sup.Read ?? 0;
            wStatusPatamar02Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar02Sup.Read ?? 0;
            wStatusPatamar03Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar03Sup.Read ?? 0;
            wStatusPatamar04Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar04Sup.Read ?? 0;
            wStatusPatamar05Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar05Sup.Read ?? 0;
            wStatusPatamar06Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar06Sup.Read ?? 0;
            wStatusPatamar07Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar07Sup.Read ?? 0;
            wStatusPatamar08Sup_Read = GVL.Opcua.GVL_ClpIhm.wStatusPatamar08Sup.Read ?? 0;

            iMinDecorTasbSup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorTasbSup.Read ?? 0;
            iSegDecorTasbSup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorTasbSup.Read ?? 0;
            iMinTasbCxSup_Read = GVL.Opcua.GVL_IhmClp.iMinTasbCxSup.Read ?? 0;

            iMinDecorResfrSup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorResfrSup.Read ?? 0;
            iSegDecorResfrSup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorResfrSup.Read ?? 0;
            iTempoExaustorMinSup_Read = GVL.Opcua.GVL_Permanentes.iTempoExaustorMinSup.Read ?? 0;

            iMinDecorAbPortSup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorAbPortSup.Read ?? 0;
            iSegDecorAbPortSup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorAbPortSup.Read ?? 0;
            iTempoAberturaSup_Read = GVL.Opcua.GVL_Permanentes.iTempoAberturaSup.Read ?? 0;

            iHorDecorTotalSup_Read = GVL.Opcua.GVL_ClpIhm.iHorDecorTotalSup.Read ?? 0;
            iMinDecorTotalSup_Read = GVL.Opcua.GVL_ClpIhm.iMinDecorTotalSup.Read ?? 0;
            iSegDecorTotalSup_Read = GVL.Opcua.GVL_ClpIhm.iSegDecorTotalSup.Read ?? 0;

            iHorProgTotalSup_Read = GVL.Opcua.GVL_ClpIhm.iHorProgTotalSup.Read ?? 0;
            iMinProgTotalSup_Read = GVL.Opcua.GVL_ClpIhm.iMinProgTotalSup.Read ?? 0;


            //stopwatch.Stop(); // Para o cronômetro

            //System.Diagnostics.Debug.WriteLine($"Tempo decorrido da Tela: {stopwatch.ElapsedMilliseconds} ms");
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
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Write = (Int16)iHorCxSupPatamar01_Write.Value;
                iHorCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar01_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Write = (Int16)iMinCxSupPatamar01_Write.Value;
                iMinCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar01_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Write = (Int16)iHorCxSupPatamar01_Write.Value;
                iHorCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar01_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Write = (Int16)iMinCxSupPatamar01_Write.Value;
                iMinCxSupPatamar01_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar02_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar02.Write = (Int16)iHorCxSupPatamar02_Write.Value;
                iHorCxSupPatamar02_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar02_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar02.Write = (Int16)iMinCxSupPatamar02_Write.Value;
                iMinCxSupPatamar02_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar03_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar03.Write = (Int16)iHorCxSupPatamar03_Write.Value;
                iHorCxSupPatamar03_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar03_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar03.Write = (Int16)iMinCxSupPatamar03_Write.Value;
                iMinCxSupPatamar03_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar04_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar04.Write = (Int16)iHorCxSupPatamar04_Write.Value;
                iHorCxSupPatamar04_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar04_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar04.Write = (Int16)iMinCxSupPatamar04_Write.Value;
                iMinCxSupPatamar04_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar05_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar05.Write = (Int16)iHorCxSupPatamar05_Write.Value;
                iHorCxSupPatamar05_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar05_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar05.Write = (Int16)iMinCxSupPatamar05_Write.Value;
                iMinCxSupPatamar05_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar06_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar06.Write = (Int16)iHorCxSupPatamar06_Write.Value;
                iHorCxSupPatamar06_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar06_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar06.Write = (Int16)iMinCxSupPatamar06_Write.Value;
                iMinCxSupPatamar06_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar07_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar07.Write = (Int16)iHorCxSupPatamar07_Write.Value;
                iHorCxSupPatamar07_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar07_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar07.Write = (Int16)iMinCxSupPatamar07_Write.Value;
                iMinCxSupPatamar07_Write = null; // Limpa o valor após escrita
            }
            if (iHorCxSupPatamar08_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar08.Write = (Int16)iHorCxSupPatamar08_Write.Value;
                iHorCxSupPatamar08_Write = null; // Limpa o valor após escrita
            }
            if (iMinCxSupPatamar08_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar08.Write = (Int16)iMinCxSupPatamar08_Write.Value;
                iMinCxSupPatamar08_Write = null; // Limpa o valor após escrita
            }
            if (iMinTasbCxSup_Write.HasValue)
            {
                GVL.Opcua.GVL_IhmClp.iMinTasbCxSup.Write = (Int16)iMinTasbCxSup_Write.Value;
                iMinTasbCxSup_Write = null; // Limpa o valor após escrita
            }

        }
    }

}
