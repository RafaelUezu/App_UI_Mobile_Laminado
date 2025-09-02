using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using App_UI_Mobile_Laminado.Services.db.db_Recipe;
using MAUI_Opcua.Services.Drivers.Opcua;
using MAUI_Opcua.Services.Communication.Variable;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_Automatica : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Operacao_Automatica()
        {
            ICommand_Selecionar_Receita = new Command(async () => await ExecutarSelecao());
            ICommand_Enviar_Receita = new Command(() => ExecutarEnvio());
            ICommand_IniciarCiclo_Receita = new Command(async() => await IniciarCiclo_Receita());
            ICommand_AbortaCicloSup = new Command(async() => await AbortaCiclo_Receita());

            OpcUaEvents.LeituraFinalizadaAsync += () =>
            {
                OnLeituraFinalizada();
                return Task.CompletedTask;
            };
        }
        #region Instâncias das classes
        private readonly db_Recipe _db_Recipe = new db_Recipe(); // Move automaticamente para o construtor
        #endregion
        #region Declaração dos comandos
        public ICommand ICommand_Selecionar_Receita { get; }
        public ICommand ICommand_Enviar_Receita { get; }
        public ICommand ICommand_IniciarCiclo_Receita { get; }
        public ICommand ICommand_AbortaCicloSup { get; }
        #endregion
        #region Variaveis privadas da classe
        bool xCicloLaminaSupHabilitado;
  

        #endregion

        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaValores);
            MainThread.BeginInvokeOnMainThread(EscreveValores);
        }

        private async Task AbortaCiclo_Receita()
        {
            bool resposta = await Application.Current.MainPage.DisplayAlert("Atenção", "Deseja abortar do ciclo?", "Sim", "Não");
            if (resposta == true)
            {
                GVL.Opcua.GVL_IhmClp.xAbortaCicloSup.Write = true;
            }
        }

        private async Task IniciarCiclo_Receita()
        {
            if (xCicloLaminaSupHabilitado == true)
            {
                GVL.Opcua.GVL_IhmClp.xBtIniciaCicloSup.Write = true;
            }
            else
            {
                if (Application.Current?.MainPage != null)
                    _ = Application.Current.MainPage.DisplayAlert("Validação", "O ciclo esta desabilitado!", "Ok");
            }
        }

        private async Task ExecutarSelecao()
        {
            try
            {
                List<string?>? sNomesColunaReceita = await _db_Recipe.AllListDatabaseAsync("db_Recipe", "RecipeSup", "sName");
                string[] opcoes = sNomesColunaReceita?
                        .Where(s => s != null)
                        .Select(s => s!)
                        .ToArray()
                        ?? Array.Empty<string>();
                Page? page = Application.Current.MainPage;
                string? resposta = await page.DisplayActionSheet("Escolha", "Cancelar", null, opcoes);

                if (!string.IsNullOrEmpty(resposta) && resposta != "Cancelar")
                {
                    bool? ValidadeSelect = await _db_Recipe.SelectRecipeAsync("db_Recipe", "RecipeSup", "sName", resposta);
                    if (ValidadeSelect == true)
                    {
                        db_to_ViewModelValue();
                    }
                    else if (ValidadeSelect == false)
                    {
                        if (Application.Current?.MainPage != null)
                            _ = Application.Current.MainPage.DisplayAlert("Falha", "Erro ao carregar a receita.", "OK");
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void ExecutarEnvio()
        {
            if( string.IsNullOrEmpty(sName_ReadWrite) )
            {
                if (Application.Current?.MainPage != null)
                    _ = Application.Current.MainPage.DisplayAlert("Validação", "Nenhuma receita foi selecionada!", "Ok");
                return;
            }
            else
            {
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa01.Write = (Int16)iMinutoRampa01_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa02.Write = (Int16)iMinutoRampa02_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa03.Write = (Int16)iMinutoRampa03_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa04.Write = (Int16)iMinutoRampa04_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa05.Write = (Int16)iMinutoRampa05_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa06.Write = (Int16)iMinutoRampa06_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa07.Write = (Int16)iMinutoRampa07_ReadWrite;
            GVL.Opcua.GVL_Permanentes.iMinCxSupRampa08.Write = (Int16)iMinutoRampa08_ReadWrite;

            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar01.Write = (Int16)iMinutoPatamar01_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar02.Write = (Int16)iMinutoPatamar02_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar03.Write = (Int16)iMinutoPatamar03_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar04.Write = (Int16)iMinutoPatamar04_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar05.Write = (Int16)iMinutoPatamar05_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar06.Write = (Int16)iMinutoPatamar06_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar07.Write = (Int16)iMinutoPatamar07_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecMinCxSupPatamar08.Write = (Int16)iMinutoPatamar08_ReadWrite;

            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar01.Write = (Int16)iHoraPatamar01_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar02.Write = (Int16)iHoraPatamar02_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar03.Write = (Int16)iHoraPatamar03_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar04.Write = (Int16)iHoraPatamar04_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar05.Write = (Int16)iHoraPatamar05_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar06.Write = (Int16)iHoraPatamar06_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar07.Write = (Int16)iHoraPatamar07_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecHorCxSupPatamar08.Write = (Int16)iHoraPatamar08_ReadWrite;

            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar01.Write = (float)dTemperaturaSP01_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar02.Write = (float)dTemperaturaSP02_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar03.Write = (float)dTemperaturaSP03_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar04.Write = (float)dTemperaturaSP04_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar05.Write = (float)dTemperaturaSP05_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar06.Write = (float)dTemperaturaSP06_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar07.Write = (float)dTemperaturaSP07_ReadWrite;
            GVL.Opcua.GVL_Receita.rRecTempCxSupPatamar08.Write = (float)dTemperaturaSP08_ReadWrite;

            GVL.Opcua.GVL_Receita.iRecSp01Vacuo01.Write = (Int16)iBombaPatamar01_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp02Vacuo01.Write = (Int16)iBombaPatamar02_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp03Vacuo01.Write = (Int16)iBombaPatamar03_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp04Vacuo01.Write = (Int16)iBombaPatamar04_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp05Vacuo01.Write = (Int16)iBombaPatamar05_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp06Vacuo01.Write = (Int16)iBombaPatamar06_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp07Vacuo01.Write = (Int16)iBombaPatamar07_ReadWrite;
            GVL.Opcua.GVL_Receita.iRecSp08Vacuo01.Write = (Int16)iBombaPatamar08_ReadWrite;

            GVL.Opcua.GVL_Receita.iRecMinTasbCxSup.Write = (Int16)iTempoBombaFim_ReadWrite;

            GVL.Opcua.GVL_Receita.iEscreveReceitaCxSup.Write = 1;

            if (Application.Current?.MainPage != null)
                _ = Application.Current.MainPage.DisplayAlert("Notificação", "A Receita '" + sName_ReadWrite + "' foi enviada ao controlador", "Ok");
            }
        }
        public void AtualizaValores()
        {
            xCicloLaminaSupHabilitado = GVL.Opcua.GVL_ClpIhm.xCicloLaminaSupHabilitado.Read ?? false;
            if (xCicloLaminaSupHabilitado)
            {
                sLegenda_CicloLaminaSupHabilitado = "Ciclo Habilitado";
                cLegenda_CicloLaminaSupHabilitado = Colors.Green;
                cStatus_CicloLaminaSupHabilitado = Colors.White;
                sLegenda_AbortaCicloSup = "Abortar Ciclo!";
                cLegenda_AbortaCicloSup = Colors.Yellow;
                cStatus_AbortaCicloSup = Colors.Red;

            }
            else
            {
                sLegenda_CicloLaminaSupHabilitado = "Ciclo Desabilitado";
                cLegenda_CicloLaminaSupHabilitado = Colors.Gray;
                cStatus_CicloLaminaSupHabilitado = Colors.White;
                sLegenda_AbortaCicloSup = "Abortar Ciclo!";
                cLegenda_AbortaCicloSup = Colors.Gray;
                cStatus_AbortaCicloSup = Colors.White;
            }
            xAlarme = GVL.Opcua.GVL_ClpIhm.xAlarme.Read;
            if (xAlarme == true)
            {
                cBackground_Alarme = Colors.Yellow;
                cTextColor_Alarme = Colors.Red;
                sText_Alarme = "Forno em Falha!";
            }
            else
            {
                cBackground_Alarme = Colors.Gray;
                cTextColor_Alarme = Colors.White;
                sText_Alarme = "Sem falhas!";
            }
            xOperacaoAutomatico = GVL.Opcua.GVL_ClpIhm.xOperacaoAutomatico.Read;
            if(xOperacaoAutomatico == true)
            {

            }
            else
            {

            }
        }
        public void EscreveValores()
        {

        }
        private void db_to_ViewModelValue()
        {
            sName_ReadWrite = _db_Recipe.RecipeSup.sName ?? string.Empty;
            iMinutoRampa01_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa01;
            iMinutoRampa02_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa02;
            iMinutoRampa03_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa03;
            iMinutoRampa04_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa04;
            iMinutoRampa05_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa05;
            iMinutoRampa06_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa06;
            iMinutoRampa07_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa07;
            iMinutoRampa08_ReadWrite = _db_Recipe.RecipeSup.iMinutoRampa08;
            iMinutoPatamar01_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar01;
            iMinutoPatamar02_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar02;
            iMinutoPatamar03_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar03;
            iMinutoPatamar04_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar04;
            iMinutoPatamar05_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar05;
            iMinutoPatamar06_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar06;
            iMinutoPatamar07_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar07;
            iMinutoPatamar08_ReadWrite = _db_Recipe.RecipeSup.iMinutoPatamar08;
            iHoraPatamar01_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar01;
            iHoraPatamar02_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar02;
            iHoraPatamar03_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar03;
            iHoraPatamar04_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar04;
            iHoraPatamar05_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar05;
            iHoraPatamar06_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar06;
            iHoraPatamar07_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar07;
            iHoraPatamar08_ReadWrite = _db_Recipe.RecipeSup.iHoraPatamar08;
            dTemperaturaSP01_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP01;
            dTemperaturaSP02_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP02;
            dTemperaturaSP03_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP03;
            dTemperaturaSP04_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP04;
            dTemperaturaSP05_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP05;
            dTemperaturaSP06_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP06;
            dTemperaturaSP07_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP07;
            dTemperaturaSP08_ReadWrite = _db_Recipe.RecipeSup.dTemperaturaSP08;
            iBombaPatamar01_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar01;
            iBombaPatamar02_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar02;
            iBombaPatamar03_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar03;
            iBombaPatamar04_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar04;
            iBombaPatamar05_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar05;
            iBombaPatamar06_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar06;
            iBombaPatamar07_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar07;
            iBombaPatamar08_ReadWrite = _db_Recipe.RecipeSup.iBombaPatamar08;
            iTempoBombaFim_ReadWrite = _db_Recipe.RecipeSup.iTempoBombaFim;
        }




    }
}
