using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages
{
    public class VM_Page_Manutencao_Saidas : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string _BoundText;
        public string BoundText
        {
            get => _BoundText;
            set
            {
                if (_BoundText != value)
                {
                    _BoundText = value;
                    OnPropertyChanged();

                }
            }
        }



    }
}
