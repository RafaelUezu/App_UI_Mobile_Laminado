using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_UI_Mobile_Laminado.Services.db.db_Recipe;
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
