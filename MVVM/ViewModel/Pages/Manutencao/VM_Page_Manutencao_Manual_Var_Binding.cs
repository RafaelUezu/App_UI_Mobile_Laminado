using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Manual
    {
        private bool _xSwitch_Read_Dumper;
        public bool xSwitch_Read_Dumper
        {
            get => _xSwitch_Read_Dumper;
            set
            {
                if (_xSwitch_Read_Dumper != value)
                {
                    _xSwitch_Read_Dumper = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_Dumper;
        public string sLabel_Status_Dumper
        {
            get => _sLabel_Status_Dumper;
            set
            {
                if (_sLabel_Status_Dumper != value)
                {
                    _sLabel_Status_Dumper = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_PortaSup;
        public bool xSwitch_Read_PortaSup
        {
            get => _xSwitch_Read_PortaSup;
            set
            {
                if (_xSwitch_Read_PortaSup != value)
                {
                    _xSwitch_Read_PortaSup = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_PortaSup;
        public string sLabel_Status_PortaSup
        {
            get => _sLabel_Status_PortaSup;
            set
            {
                if (_sLabel_Status_PortaSup != value)
                {
                    _sLabel_Status_PortaSup = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_BombaVacuo;
        public bool xSwitch_Read_BombaVacuo
        {
            get => _xSwitch_Read_BombaVacuo;
            set
            {
                if (_xSwitch_Read_BombaVacuo != value)
                {
                    _xSwitch_Read_BombaVacuo = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_BombaVacuo;
        public string sLabel_Status_BombaVacuo
        {
            get => _sLabel_Status_BombaVacuo;
            set
            {
                if (_sLabel_Status_BombaVacuo != value)
                {
                    _sLabel_Status_BombaVacuo = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_Ventilador;
        public bool xSwitch_Read_Ventilador
        {
            get => _xSwitch_Read_Ventilador;
            set
            {
                if (_xSwitch_Read_Ventilador != value)
                {
                    _xSwitch_Read_Ventilador = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_Ventilador;
        public string sLabel_Status_Ventilador
        {
            get => _sLabel_Status_Ventilador;
            set
            {
                if (_sLabel_Status_Ventilador != value)
                {
                    _sLabel_Status_Ventilador = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rFrequencia_Ventilador01;
        public float rFrequencia_Ventilador01
        {
            get => _rFrequencia_Ventilador01;
            set
            {
                if (_rFrequencia_Ventilador01 != value)
                {
                    _rFrequencia_Ventilador01 = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rVelocidade_Ventilador01;
        public float rVelocidade_Ventilador01
        {
            get => _rVelocidade_Ventilador01;
            set
            {
                if (_rVelocidade_Ventilador01 != value)
                {
                    _rVelocidade_Ventilador01 = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iTemperaturaTermoparSup01;
        public int iTemperaturaTermoparSup01
        {
            get => _iTemperaturaTermoparSup01;
            set
            {
                if (_iTemperaturaTermoparSup01 != value)
                {
                    _iTemperaturaTermoparSup01 = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_Resistencia01;
        public bool xSwitch_Read_Resistencia01
        {
            get => _xSwitch_Read_Resistencia01;
            set
            {
                if (_xSwitch_Read_Resistencia01 != value)
                {
                    _xSwitch_Read_Resistencia01 = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_Resistencia01;
        public string sLabel_Status_Resistencia01
        {
            get => _sLabel_Status_Resistencia01;
            set
            {
                if (_sLabel_Status_Resistencia01 != value)
                {
                    _sLabel_Status_Resistencia01 = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_Resistencia02;
        public bool xSwitch_Read_Resistencia02
        {
            get => _xSwitch_Read_Resistencia02;
            set
            {
                if (_xSwitch_Read_Resistencia02 != value)
                {
                    _xSwitch_Read_Resistencia02 = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_Resistencia02;
        public string sLabel_Status_Resistencia02
        {
            get => _sLabel_Status_Resistencia02;
            set
            {
                if (_sLabel_Status_Resistencia02 != value)
                {
                    _sLabel_Status_Resistencia02 = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_Resistencia03;
        public bool xSwitch_Read_Resistencia03
        {
            get => _xSwitch_Read_Resistencia03;
            set
            {
                if (_xSwitch_Read_Resistencia03 != value)
                {
                    _xSwitch_Read_Resistencia03 = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_Resistencia03;
        public string sLabel_Status_Resistencia03
        {
            get => _sLabel_Status_Resistencia03;
            set
            {
                if (_sLabel_Status_Resistencia03 != value)
                {
                    _sLabel_Status_Resistencia03 = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xSwitch_Read_Resistencia04;
        public bool xSwitch_Read_Resistencia04
        {
            get => _xSwitch_Read_Resistencia04;
            set
            {
                if (_xSwitch_Read_Resistencia04 != value)
                {
                    _xSwitch_Read_Resistencia04 = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sLabel_Status_Resistencia04;
        public string sLabel_Status_Resistencia04
        {
            get => _sLabel_Status_Resistencia04;
            set
            {
                if (_sLabel_Status_Resistencia04 != value)
                {
                    _sLabel_Status_Resistencia04 = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _fLabel_CorrenteR;
        public float fLabel_CorrenteR
        {
            get => _fLabel_CorrenteR;
            set
            {
                if (_fLabel_CorrenteR != value)
                {
                    _fLabel_CorrenteR = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _fLabel_CorrenteS;
        public float fLabel_CorrenteS
        {
            get => _fLabel_CorrenteS;
            set
            {
                if (_fLabel_CorrenteS != value)
                {
                    _fLabel_CorrenteS = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _fLabel_CorrenteT;
        public float fLabel_CorrenteT
        {
            get => _fLabel_CorrenteT;
            set
            {
                if (_fLabel_CorrenteT != value)
                {
                    _fLabel_CorrenteT = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _fLabel_CorrenteN;
        public float fLabel_CorrenteN
        {
            get => _fLabel_CorrenteN;
            set
            {
                if (_fLabel_CorrenteN != value)
                {
                    _fLabel_CorrenteN = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
