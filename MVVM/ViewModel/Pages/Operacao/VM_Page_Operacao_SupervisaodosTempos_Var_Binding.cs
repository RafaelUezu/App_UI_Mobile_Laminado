using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_SupervisaodosTempos
    {
        private float _rTempCxSupPatamar01;
        public float rTempCxSupPatamar01
        {
            get => _rTempCxSupPatamar01;
            set
            {
                if (_rTempCxSupPatamar01 != value)
                {
                    _rTempCxSupPatamar01 = value;
                    OnPropertyChanged();
                }
            }
        }



    }
}
