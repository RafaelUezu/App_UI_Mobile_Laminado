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
            ICommand_Enviar_Receita = new Command(async () => await ExecutarEnvio());

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
        #endregion
        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaValores);
            MainThread.BeginInvokeOnMainThread(EscreveValores);
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
        private async Task ExecutarEnvio()
        {

        }
        public void AtualizaValores()
        {

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
