using App_UI_Mobile_Laminado.Services.db.db_Recipe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Receitas
{
    public partial class VM_Page_Receitas_Edicao : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Receitas_Edicao()
        {
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

        private string _ReceitaSelecionada_ReadWrite;
        public string ReceitaSelecionada_ReadWrite
        {
            get => _ReceitaSelecionada_ReadWrite;
            set
            {
                if (_ReceitaSelecionada_ReadWrite != value)
                {
                    _ReceitaSelecionada_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }














        db_Recipe _db_Recipe = new db_Recipe();
        
        


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
