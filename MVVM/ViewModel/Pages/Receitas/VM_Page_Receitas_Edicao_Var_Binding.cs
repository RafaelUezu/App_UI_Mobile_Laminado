using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Receitas
{
    public partial class VM_Page_Receitas_Edicao
    {
        /*
        $sName,
        $iMinutoRampa01,
        $dTemperaturaSP01,
        $iHoraPatamar01,
        $iMinutoPatamar01,
        $iMinutoRampa02,
        $dTemperaturaSP02,
        $iHoraPatamar02,
        $iMinutoPatamar02,
        $iMinutoRampa03,
        $dTemperaturaSP03,
        $iHoraPatamar03,
        $iMinutoPatamar03,
        $iMinutoRampa04,
        $dTemperaturaSP04,
        $iHoraPatamar04,
        $iMinutoPatamar04,
        $iMinutoRampa05,
        $dTemperaturaSP05,
        $iHoraPatamar05,
        $iMinutoPatamar05,
        $iMinutoRampa06,
        $dTemperaturaSP06,
        $iHoraPatamar06,
        $iMinutoPatamar06,
        $iMinutoRampa07,
        $dTemperaturaSP07,
        $iHoraPatamar07,
        $iMinutoPatamar07,
        $iMinutoRampa08,
        $dTemperaturaSP08,
        $iHoraPatamar08,
        $iMinutoPatamar08,
        $iBombaPatamar01,
        $iBombaPatamar02,
        $iBombaPatamar03,
        $iBombaPatamar04,
        $iBombaPatamar05,
        $iBombaPatamar06,
        $iBombaPatamar07,
        $iBombaPatamar08,
        $iTempoBombaFim
        */
        private string _sName_ReadWrite = string.Empty;
        public string sName_ReadWrite
        {
            get => _sName_ReadWrite;
            set
            {
                if(_sName_ReadWrite != value)
                {
                    _sName_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa01_ReadWrite = 0;
        public int iMinutoRampa01_ReadWrite
        {
            get => _iMinutoRampa01_ReadWrite;
            set
            {
                if(_iMinutoRampa01_ReadWrite != value)
                {
                    _iMinutoRampa01_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP01_ReadWrite = 0.0;
        public double dTemperaturaSP01_ReadWrite
        {
            get => _dTemperaturaSP01_ReadWrite;
            set
            {
                if(_dTemperaturaSP01_ReadWrite != value)
                {
                    _dTemperaturaSP01_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar01_ReadWrite = 0;
        public int iHoraPatamar01_ReadWrite
        {
            get => _iHoraPatamar01_ReadWrite;
            set
            {
                if(_iHoraPatamar01_ReadWrite != value)
                {
                    _iHoraPatamar01_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar01_ReadWrite = 0;
        public int iMinutoPatamar01_ReadWrite
        {
            get => _iMinutoPatamar01_ReadWrite;
            set
            {
                if(_iMinutoPatamar01_ReadWrite != value)
                {
                    _iMinutoPatamar01_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa02_ReadWrite = 0;
        public int iMinutoRampa02_ReadWrite
        {
            get => _iMinutoRampa02_ReadWrite;
            set
            {
                if (_iMinutoRampa02_ReadWrite != value)
                {
                    _iMinutoRampa02_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP02_ReadWrite = 0.0;
        public double dTemperaturaSP02_ReadWrite
        {
            get => _dTemperaturaSP02_ReadWrite;
            set
            {
                if (_dTemperaturaSP02_ReadWrite != value)
                {
                    _dTemperaturaSP02_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar02_ReadWrite = 0;
        public int iHoraPatamar02_ReadWrite
        {
            get => _iHoraPatamar02_ReadWrite;
            set
            {
                if (_iHoraPatamar02_ReadWrite != value)
                {
                    _iHoraPatamar02_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar02_ReadWrite = 0;
        public int iMinutoPatamar02_ReadWrite
        {
            get => _iMinutoPatamar02_ReadWrite;
            set
            {
                if (_iMinutoPatamar02_ReadWrite != value)
                {
                    _iMinutoPatamar02_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa03_ReadWrite = 0;
        public int iMinutoRampa03_ReadWrite
        {
            get => _iMinutoRampa03_ReadWrite;
            set
            {
                if (_iMinutoRampa03_ReadWrite != value)
                {
                    _iMinutoRampa03_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP03_ReadWrite = 0.0;
        public double dTemperaturaSP03_ReadWrite
        {
            get => _dTemperaturaSP03_ReadWrite;
            set
            {
                if (_dTemperaturaSP03_ReadWrite != value)
                {
                    _dTemperaturaSP03_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar03_ReadWrite = 0;
        public int iHoraPatamar03_ReadWrite
        {
            get => _iHoraPatamar03_ReadWrite;
            set
            {
                if (_iHoraPatamar03_ReadWrite != value)
                {
                    _iHoraPatamar03_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar03_ReadWrite = 0;
        public int iMinutoPatamar03_ReadWrite
        {
            get => _iMinutoPatamar03_ReadWrite;
            set
            {
                if (_iMinutoPatamar03_ReadWrite != value)
                {
                    _iMinutoPatamar03_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa04_ReadWrite = 0;
        public int iMinutoRampa04_ReadWrite
        {
            get => _iMinutoRampa04_ReadWrite;
            set
            {
                if (_iMinutoRampa04_ReadWrite != value)
                {
                    _iMinutoRampa04_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP04_ReadWrite = 0.0;
        public double dTemperaturaSP04_ReadWrite
        {
            get => _dTemperaturaSP04_ReadWrite;
            set
            {
                if (_dTemperaturaSP04_ReadWrite != value)
                {
                    _dTemperaturaSP04_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar04_ReadWrite = 0;
        public int iHoraPatamar04_ReadWrite
        {
            get => _iHoraPatamar04_ReadWrite;
            set
            {
                if (_iHoraPatamar04_ReadWrite != value)
                {
                    _iHoraPatamar04_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar04_ReadWrite = 0;
        public int iMinutoPatamar04_ReadWrite
        {
            get => _iMinutoPatamar04_ReadWrite;
            set
            {
                if (_iMinutoPatamar04_ReadWrite != value)
                {
                    _iMinutoPatamar04_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa05_ReadWrite = 0;
        public int iMinutoRampa05_ReadWrite
        {
            get => _iMinutoRampa05_ReadWrite;
            set
            {
                if (_iMinutoRampa05_ReadWrite != value)
                {
                    _iMinutoRampa05_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP05_ReadWrite = 0.0;
        public double dTemperaturaSP05_ReadWrite
        {
            get => _dTemperaturaSP05_ReadWrite;
            set
            {
                if (_dTemperaturaSP05_ReadWrite != value)
                {
                    _dTemperaturaSP05_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar05_ReadWrite = 0;
        public int iHoraPatamar05_ReadWrite
        {
            get => _iHoraPatamar05_ReadWrite;
            set
            {
                if (_iHoraPatamar05_ReadWrite != value)
                {
                    _iHoraPatamar05_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar05_ReadWrite = 0;
        public int iMinutoPatamar05_ReadWrite
        {
            get => _iMinutoPatamar05_ReadWrite;
            set
            {
                if (_iMinutoPatamar05_ReadWrite != value)
                {
                    _iMinutoPatamar05_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa06_ReadWrite = 0;
        public int iMinutoRampa06_ReadWrite
        {
            get => _iMinutoRampa06_ReadWrite;
            set
            {
                if (_iMinutoRampa06_ReadWrite != value)
                {
                    _iMinutoRampa06_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP06_ReadWrite = 0.0;
        public double dTemperaturaSP06_ReadWrite
        {
            get => _dTemperaturaSP06_ReadWrite;
            set
            {
                if (_dTemperaturaSP06_ReadWrite != value)
                {
                    _dTemperaturaSP06_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar06_ReadWrite = 0;
        public int iHoraPatamar06_ReadWrite
        {
            get => _iHoraPatamar06_ReadWrite;
            set
            {
                if (_iHoraPatamar06_ReadWrite != value)
                {
                    _iHoraPatamar06_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar06_ReadWrite = 0;
        public int iMinutoPatamar06_ReadWrite
        {
            get => _iMinutoPatamar06_ReadWrite;
            set
            {
                if (_iMinutoPatamar06_ReadWrite != value)
                {
                    _iMinutoPatamar06_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa07_ReadWrite = 0;
        public int iMinutoRampa07_ReadWrite
        {
            get => _iMinutoRampa07_ReadWrite;
            set
            {
                if (_iMinutoRampa07_ReadWrite != value)
                {
                    _iMinutoRampa07_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP07_ReadWrite = 0.0;
        public double dTemperaturaSP07_ReadWrite
        {
            get => _dTemperaturaSP07_ReadWrite;
            set
            {
                if (_dTemperaturaSP07_ReadWrite != value)
                {
                    _dTemperaturaSP07_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar07_ReadWrite = 0;
        public int iHoraPatamar07_ReadWrite
        {
            get => _iHoraPatamar07_ReadWrite;
            set
            {
                if (_iHoraPatamar07_ReadWrite != value)
                {
                    _iHoraPatamar07_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar07_ReadWrite = 0;
        public int iMinutoPatamar07_ReadWrite
        {
            get => _iMinutoPatamar07_ReadWrite;
            set
            {
                if (_iMinutoPatamar07_ReadWrite != value)
                {
                    _iMinutoPatamar07_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoRampa08_ReadWrite = 0;
        public int iMinutoRampa08_ReadWrite
        {
            get => _iMinutoRampa08_ReadWrite;
            set
            {
                if (_iMinutoRampa08_ReadWrite != value)
                {
                    _iMinutoRampa08_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private double _dTemperaturaSP08_ReadWrite = 0.0;
        public double dTemperaturaSP08_ReadWrite
        {
            get => _dTemperaturaSP08_ReadWrite;
            set
            {
                if (_dTemperaturaSP08_ReadWrite != value)
                {
                    _dTemperaturaSP08_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHoraPatamar08_ReadWrite = 0;
        public int iHoraPatamar08_ReadWrite
        {
            get => _iHoraPatamar08_ReadWrite;
            set
            {
                if (_iHoraPatamar08_ReadWrite != value)
                {
                    _iHoraPatamar08_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinutoPatamar08_ReadWrite = 0;
        public int iMinutoPatamar08_ReadWrite
        {
            get => _iMinutoPatamar08_ReadWrite;
            set
            {
                if (_iMinutoPatamar08_ReadWrite != value)
                {
                    _iMinutoPatamar08_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar01_ReadWrite = 0;
        public int iBombaPatamar01_ReadWrite
        {
            get => _iBombaPatamar01_ReadWrite;
            set
            {
                if (_iBombaPatamar01_ReadWrite != value)
                {
                    _iBombaPatamar01_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar02_ReadWrite = 0;
        public int iBombaPatamar02_ReadWrite
        {
            get => _iBombaPatamar02_ReadWrite;
            set
            {
                if (_iBombaPatamar02_ReadWrite != value)
                {
                    _iBombaPatamar02_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar03_ReadWrite = 0;
        public int iBombaPatamar03_ReadWrite
        {
            get => _iBombaPatamar03_ReadWrite;
            set
            {
                if (_iBombaPatamar03_ReadWrite != value)
                {
                    _iBombaPatamar03_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar04_ReadWrite = 0;
        public int iBombaPatamar04_ReadWrite
        {
            get => _iBombaPatamar04_ReadWrite;
            set
            {
                if (_iBombaPatamar04_ReadWrite != value)
                {
                    _iBombaPatamar04_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar05_ReadWrite = 0;
        public int iBombaPatamar05_ReadWrite
        {
            get => _iBombaPatamar05_ReadWrite;
            set
            {
                if (_iBombaPatamar05_ReadWrite != value)
                {
                    _iBombaPatamar05_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar06_ReadWrite = 0;
        public int iBombaPatamar06_ReadWrite
        {
            get => _iBombaPatamar06_ReadWrite;
            set
            {
                if (_iBombaPatamar06_ReadWrite != value)
                {
                    _iBombaPatamar06_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar07_ReadWrite = 0;
        public int iBombaPatamar07_ReadWrite
        {
            get => _iBombaPatamar07_ReadWrite;
            set
            {
                if (_iBombaPatamar07_ReadWrite != value)
                {
                    _iBombaPatamar07_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iBombaPatamar08_ReadWrite = 0;
        public int iBombaPatamar08_ReadWrite
        {
            get => _iBombaPatamar08_ReadWrite;
            set
            {
                if (_iBombaPatamar08_ReadWrite != value)
                {
                    _iBombaPatamar08_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iTempoBombaFim_ReadWrite = 0;
        public int iTempoBombaFim_ReadWrite
        {
            get => _iTempoBombaFim_ReadWrite;
            set
            {
                if (_iTempoBombaFim_ReadWrite != value)
                {
                    _iTempoBombaFim_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
}
