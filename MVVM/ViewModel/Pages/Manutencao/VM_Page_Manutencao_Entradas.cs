using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public class VM_Page_Manutencao_Entradas : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private string _C1_sDI0_Descricao;

        public string C1_sDI0_Descricao
        {
            get 
            {
                return _C1_sDI0_Descricao;
            }
            set
            {
                if (C1_sDI0_Descricao != value)
                {
                    _C1_sDI0_Descricao = value;
                    OnPropertyChanged();
                }
            }
        }




    }
}
