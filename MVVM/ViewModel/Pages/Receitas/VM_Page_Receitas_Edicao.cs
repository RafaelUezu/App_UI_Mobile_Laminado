using App_UI_Mobile_Laminado.Services.db.db_Recipe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Receitas
{
    public partial class VM_Page_Receitas_Edicao : ObservableObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Receitas_Edicao() // Construtor
        {
            iBombaPatamar01_ReadWrite = 1;
            iBombaPatamar02_ReadWrite = 1;
            iBombaPatamar03_ReadWrite = 1;
            iBombaPatamar04_ReadWrite = 1;
            iBombaPatamar05_ReadWrite = 1;
            iBombaPatamar06_ReadWrite = 1;
            iBombaPatamar07_ReadWrite = 1;
            iBombaPatamar08_ReadWrite = 1;

            ZeraValores_ViewModel();

            SelecionarCommand = new Command(async () => await ExecutarSelecao());
            ICommand_Salvar_Receita = new Command(async () => await SalvarReceitaAsync());
            ICommand_Nova_Receita = new Command(async () => await NovaReceitaAsync());

        }
        #region Instâncias das classes
        private readonly db_Recipe _db_Recipe = new db_Recipe(); // Move automaticamente para o construtor
        #endregion
        #region Declaração dos comandos
        public ICommand ICommand_Salvar_Receita { get; }
        public ICommand SelecionarCommand { get; }
        public ICommand ICommand_Nova_Receita { get; }
        #endregion

        public string Resultado { get; set; }
        private async Task ExecutarSelecao()
        {
            var page = Application.Current.MainPage;

            string[] opcoes = { "Item A", "Item B", "Item C" };
            var resposta = await page.DisplayActionSheet("Escolha", "Cancelar", null, opcoes);

            if (resposta != null && resposta != "Cancelar")
            {
                Resultado = $"Selecionou: {resposta}";
                OnPropertyChanged(nameof(Resultado));
            }
        }

        public ObservableCollection<string> ListaReceitas_ReadWrite { get; } = new()
        {
            "Opção 1",
            "Opção 2",
            "Opção 3"
        };

        private void ZeraValores_ViewModel()
        {
            sName_ReadWrite = string.Empty;
            iMinutoRampa01_ReadWrite = 0;
            iMinutoRampa02_ReadWrite = 0;
            iMinutoRampa03_ReadWrite = 0;
            iMinutoRampa04_ReadWrite = 0;
            iMinutoRampa05_ReadWrite = 0;
            iMinutoRampa06_ReadWrite = 0;
            iMinutoRampa07_ReadWrite = 0;
            iMinutoRampa08_ReadWrite = 0;
            iMinutoPatamar01_ReadWrite = 0;
            iMinutoPatamar02_ReadWrite = 0;
            iMinutoPatamar03_ReadWrite = 0;
            iMinutoPatamar04_ReadWrite = 0;
            iMinutoPatamar05_ReadWrite = 0;
            iMinutoPatamar06_ReadWrite = 0;
            iMinutoPatamar07_ReadWrite = 0;
            iMinutoPatamar08_ReadWrite = 0;
            iHoraPatamar01_ReadWrite = 0;
            iHoraPatamar02_ReadWrite = 0;
            iHoraPatamar03_ReadWrite = 0;
            iHoraPatamar04_ReadWrite = 0;
            iHoraPatamar05_ReadWrite = 0;
            iHoraPatamar06_ReadWrite = 0;
            iHoraPatamar07_ReadWrite = 0;
            iHoraPatamar08_ReadWrite = 0;
            dTemperaturaSP01_ReadWrite = 0;
            dTemperaturaSP02_ReadWrite = 0;
            dTemperaturaSP03_ReadWrite = 0;
            dTemperaturaSP04_ReadWrite = 0;
            dTemperaturaSP05_ReadWrite = 0;
            dTemperaturaSP06_ReadWrite = 0;
            dTemperaturaSP07_ReadWrite = 0;
            dTemperaturaSP08_ReadWrite = 0;
            iBombaPatamar01_ReadWrite = 1;
            iBombaPatamar02_ReadWrite = 1;
            iBombaPatamar03_ReadWrite = 1;
            iBombaPatamar04_ReadWrite = 1;
            iBombaPatamar05_ReadWrite = 1;
            iBombaPatamar06_ReadWrite = 1;
            iBombaPatamar07_ReadWrite = 1;
            iBombaPatamar08_ReadWrite = 1;
            iTempoBombaFim_ReadWrite = 0;
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


        }
        private void ViewModelValue_to_db()
        {
            _db_Recipe.RecipeSup.sName = sName_ReadWrite ?? string.Empty;
            _db_Recipe.RecipeSup.iMinutoRampa01 = iMinutoRampa01_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa02 = iMinutoRampa02_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa03 = iMinutoRampa03_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa04 = iMinutoRampa04_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa05 = iMinutoRampa05_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa06 = iMinutoRampa06_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa07 = iMinutoRampa07_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoRampa08 = iMinutoRampa08_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar01 = iMinutoPatamar01_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar02 = iMinutoPatamar02_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar03 = iMinutoPatamar03_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar04 = iMinutoPatamar04_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar05 = iMinutoPatamar05_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar06 = iMinutoPatamar06_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar07 = iMinutoPatamar07_ReadWrite;
            _db_Recipe.RecipeSup.iMinutoPatamar08 = iMinutoPatamar08_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar01 = iHoraPatamar01_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar02 = iHoraPatamar02_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar03 = iHoraPatamar03_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar04 = iHoraPatamar04_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar05 = iHoraPatamar05_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar06 = iHoraPatamar06_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar07 = iHoraPatamar07_ReadWrite;
            _db_Recipe.RecipeSup.iHoraPatamar08 = iHoraPatamar08_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP01 = dTemperaturaSP01_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP02 = dTemperaturaSP02_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP03 = dTemperaturaSP03_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP04 = dTemperaturaSP04_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP05 = dTemperaturaSP05_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP06 = dTemperaturaSP06_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP07 = dTemperaturaSP07_ReadWrite;
            _db_Recipe.RecipeSup.dTemperaturaSP08 = dTemperaturaSP08_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar01 = iBombaPatamar01_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar02 = iBombaPatamar02_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar03 = iBombaPatamar03_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar04 = iBombaPatamar04_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar05 = iBombaPatamar05_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar06 = iBombaPatamar06_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar07 = iBombaPatamar07_ReadWrite;
            _db_Recipe.RecipeSup.iBombaPatamar08 = iBombaPatamar08_ReadWrite;
            _db_Recipe.RecipeSup.iTempoBombaFim = iTempoBombaFim_ReadWrite;
        }
        
        private async Task SalvarReceitaAsync()
        {
            try
            {
                ViewModelValue_to_db();

                bool? Validate = await _db_Recipe.InsertRecipeAsync("db_RecipeSup");
                if (Validate == true)
                {
                    if (Application.Current?.MainPage != null)
                        _ = Application.Current.MainPage.DisplayAlert("Sucesso", "Receita salva com sucesso!", "OK");
                }
                else
                {
                    if (Application.Current?.MainPage != null)
                        _ = Application.Current.MainPage.DisplayAlert("Falha", "Erro ao salvar receita.", "OK");
                }
            }
            catch (Exception ex)
            {
                if (Application.Current?.MainPage != null)
                    _ = Application.Current.MainPage.DisplayAlert("Falha", "Erro ao salvar receita.", "OK");
            }
        }

        private async Task NovaReceitaAsync()
        {
            try
            {
                ZeraValores_ViewModel();

            }
            catch
            {

            }
        }
    }
}
