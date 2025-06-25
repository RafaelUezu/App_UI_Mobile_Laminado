using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_Manual
    {
        private bool _xVacuo01Ok_Read;
        public bool xVacuo01Ok_Read
        {
            get => _xVacuo01Ok_Read;
            set
            {
                if (_xVacuo01Ok_Read != value)
                {
                    _xVacuo01Ok_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _ImgMotor5_Read;
        public bool ImgMotor5_Read
        {
            get => _ImgMotor5_Read;
            set
            {
                if (_ImgMotor5_Read != value)
                {



                    _ImgMotor5_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _fFreqMotorBomba01_Read;
        public float? fFreqMotorBomba01_Read
        {
            get => _fFreqMotorBomba01_Read;
            set
            {
                if (_fFreqMotorBomba01_Read != value)
                {
                    _fFreqMotorBomba01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private string? _sCmdMotorBomba01_Legend;
        public string? sCmdMotorBomba01_Legend
        {
            get => _sCmdMotorBomba01_Legend;
            set
            {
                if (_sCmdMotorBomba01_Legend != value)
                {
                    _sCmdMotorBomba01_Legend = value;
                    OnPropertyChanged();
                }
            }
        }

  



    }
}
