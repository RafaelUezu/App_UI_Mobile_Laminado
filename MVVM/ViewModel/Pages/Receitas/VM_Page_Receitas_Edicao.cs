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

        public VM_Page_Receitas_Edicao()
        {
            iBombaPatamar01_ReadWrite = 1;
            iBombaPatamar02_ReadWrite = 1;
            iBombaPatamar03_ReadWrite = 1;
            iBombaPatamar04_ReadWrite = 1;
            iBombaPatamar05_ReadWrite = 1;
            iBombaPatamar06_ReadWrite = 1;
            iBombaPatamar07_ReadWrite = 1;
            iBombaPatamar08_ReadWrite = 1;

            SelecionarCommand = new Command(async () => await ExecutarSelecao());
        }


        public ICommand SelecionarCommand { get; }
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




        

        db_Recipe _db_Recipe = new db_Recipe();

        public ICommand ICommand_Salvar_Receita => new Command(async () =>
        {
            

        });

        public ICommand Button_DeleteRecipe_Command => new Command(async () =>
        {
            try
            {
                await _db_Recipe.DeleteRecipeAsync("SSS", "ss");
            }
            catch
            {

            }
        });

    }
}
