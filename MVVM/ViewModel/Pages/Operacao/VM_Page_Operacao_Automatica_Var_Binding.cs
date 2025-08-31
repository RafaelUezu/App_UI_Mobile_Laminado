using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_Automatica
    {
        #region Dados da Receita
        private string _sName_ReadWrite = string.Empty;
        public string sName_ReadWrite
        {
            get => _sName_ReadWrite;
            set
            {
                if (_sName_ReadWrite != value)
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
                if (_iMinutoRampa01_ReadWrite != value)
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
                if (_dTemperaturaSP01_ReadWrite != value)
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
                if (_iHoraPatamar01_ReadWrite != value)
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
                if (_iMinutoPatamar01_ReadWrite != value)
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
                    xBombaPatamar01_Status = ObterStatus(value);
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
                    xBombaPatamar02_Status = ObterStatus(value);
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
                    xBombaPatamar03_Status = ObterStatus(value);
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
                    xBombaPatamar04_Status = ObterStatus(value);
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
                    xBombaPatamar05_Status = ObterStatus(value);
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
                    xBombaPatamar06_Status = ObterStatus(value);
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
                    xBombaPatamar07_Status = ObterStatus(value);
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
                    xBombaPatamar08_Status = ObterStatus(value);
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
        

        private bool ObterStatus(int status)
        {
            return status switch
            {
                0 => false,
                1 => true,
                _ => false
            };
        }

        private bool _xBombaPatamar01_Status = false;
        public bool xBombaPatamar01_Status
        {
            get => _xBombaPatamar01_Status;
            set
            {
                if (_xBombaPatamar01_Status != value)
                {
                    _xBombaPatamar01_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar02_Status = false;
        public bool xBombaPatamar02_Status
        {
            get => _xBombaPatamar02_Status;
            set
            {
                if (_xBombaPatamar02_Status != value)
                {
                    _xBombaPatamar02_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar03_Status = false;
        public bool xBombaPatamar03_Status
        {
            get => _xBombaPatamar03_Status;
            set
            {
                if (_xBombaPatamar03_Status != value)
                {
                    _xBombaPatamar03_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar04_Status = false;
        public bool xBombaPatamar04_Status
        {
            get => _xBombaPatamar04_Status;
            set
            {
                if (_xBombaPatamar04_Status != value)
                {
                    _xBombaPatamar04_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar05_Status = false;
        public bool xBombaPatamar05_Status
        {
            get => _xBombaPatamar05_Status;
            set
            {
                if (_xBombaPatamar05_Status != value)
                {
                    _xBombaPatamar05_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar06_Status = false;
        public bool xBombaPatamar06_Status
        {
            get => _xBombaPatamar06_Status;
            set
            {
                if (_xBombaPatamar06_Status != value)
                {
                    _xBombaPatamar06_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar07_Status = false;
        public bool xBombaPatamar07_Status
        {
            get => _xBombaPatamar07_Status;
            set
            {
                if (_xBombaPatamar07_Status != value)
                {
                    _xBombaPatamar07_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _xBombaPatamar08_Status = false;
        public bool xBombaPatamar08_Status
        {
            get => _xBombaPatamar08_Status;
            set
            {
                if (_xBombaPatamar08_Status != value)
                {
                    _xBombaPatamar08_Status = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Dados da Operação
        #region Temperaturas dos Patamares Superiores
        private float _rTempCxSupPatamar01_Read;
        public float rTempCxSupPatamar01_Read
        {
            get => _rTempCxSupPatamar01_Read;
            set
            {
                if (_rTempCxSupPatamar01_Read != value)
                {
                    _rTempCxSupPatamar01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar01_Write;
        public float? rTempCxSupPatamar01_Write
        {
            get => _rTempCxSupPatamar01_Write;
            set
            {
                if (_rTempCxSupPatamar01_Write != value)
                {
                    _rTempCxSupPatamar01_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar02_Read;
        public float rTempCxSupPatamar02_Read
        {
            get => _rTempCxSupPatamar02_Read;
            set
            {
                if (_rTempCxSupPatamar02_Read != value)
                {
                    _rTempCxSupPatamar02_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar02_Write;
        public float? rTempCxSupPatamar02_Write
        {
            get => _rTempCxSupPatamar02_Write;
            set
            {
                if (_rTempCxSupPatamar02_Write != value)
                {
                    _rTempCxSupPatamar02_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar03_Read;
        public float rTempCxSupPatamar03_Read
        {
            get => _rTempCxSupPatamar03_Read;
            set
            {
                if (_rTempCxSupPatamar03_Read != value)
                {
                    _rTempCxSupPatamar03_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar03_Write;
        public float? rTempCxSupPatamar03_Write
        {
            get => _rTempCxSupPatamar03_Write;
            set
            {
                if (_rTempCxSupPatamar03_Write != value)
                {
                    _rTempCxSupPatamar03_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar04_Read;
        public float rTempCxSupPatamar04_Read
        {
            get => _rTempCxSupPatamar04_Read;
            set
            {
                if (_rTempCxSupPatamar04_Read != value)
                {
                    _rTempCxSupPatamar04_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar04_Write;
        public float? rTempCxSupPatamar04_Write
        {
            get => _rTempCxSupPatamar04_Write;
            set
            {
                if (_rTempCxSupPatamar04_Write != value)
                {
                    _rTempCxSupPatamar04_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar05_Read;
        public float rTempCxSupPatamar05_Read
        {
            get => _rTempCxSupPatamar05_Read;
            set
            {
                if (_rTempCxSupPatamar05_Read != value)
                {
                    _rTempCxSupPatamar05_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar05_Write;
        public float? rTempCxSupPatamar05_Write
        {
            get => _rTempCxSupPatamar05_Write;
            set
            {
                if (_rTempCxSupPatamar05_Write != value)
                {
                    _rTempCxSupPatamar05_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar06_Read;
        public float rTempCxSupPatamar06_Read
        {
            get => _rTempCxSupPatamar06_Read;
            set
            {
                if (_rTempCxSupPatamar06_Read != value)
                {
                    _rTempCxSupPatamar06_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar06_Write;
        public float? rTempCxSupPatamar06_Write
        {
            get => _rTempCxSupPatamar06_Write;
            set
            {
                if (_rTempCxSupPatamar06_Write != value)
                {
                    _rTempCxSupPatamar06_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar07_Read;
        public float rTempCxSupPatamar07_Read
        {
            get => _rTempCxSupPatamar07_Read;
            set
            {
                if (_rTempCxSupPatamar07_Read != value)
                {
                    _rTempCxSupPatamar07_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar07_Write;
        public float? rTempCxSupPatamar07_Write
        {
            get => _rTempCxSupPatamar07_Write;
            set
            {
                if (_rTempCxSupPatamar07_Write != value)
                {
                    _rTempCxSupPatamar07_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTempCxSupPatamar08_Read;
        public float rTempCxSupPatamar08_Read
        {
            get => _rTempCxSupPatamar08_Read;
            set
            {
                if (_rTempCxSupPatamar08_Read != value)
                {
                    _rTempCxSupPatamar08_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTempCxSupPatamar08_Write;
        public float? rTempCxSupPatamar08_Write
        {
            get => _rTempCxSupPatamar08_Write;
            set
            {
                if (_rTempCxSupPatamar08_Write != value)
                {
                    _rTempCxSupPatamar08_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Tempo programado das Rampas Superiores  
        private int _iMinCxSupRampa01_Read;
        public int iMinCxSupRampa01_Read
        {
            get => _iMinCxSupRampa01_Read;
            set
            {
                if (_iMinCxSupRampa01_Read != value)
                {
                    _iMinCxSupRampa01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa02_Read;
        public int iMinCxSupRampa02_Read
        {
            get => _iMinCxSupRampa02_Read;
            set
            {
                if (_iMinCxSupRampa02_Read != value)
                {
                    _iMinCxSupRampa02_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa03_Read;
        public int iMinCxSupRampa03_Read
        {
            get => _iMinCxSupRampa03_Read;
            set
            {
                if (_iMinCxSupRampa03_Read != value)
                {
                    _iMinCxSupRampa03_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa04_Read;
        public int iMinCxSupRampa04_Read
        {
            get => _iMinCxSupRampa04_Read;
            set
            {
                if (_iMinCxSupRampa04_Read != value)
                {
                    _iMinCxSupRampa04_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa05_Read;
        public int iMinCxSupRampa05_Read
        {
            get => _iMinCxSupRampa05_Read;
            set
            {
                if (_iMinCxSupRampa05_Read != value)
                {
                    _iMinCxSupRampa05_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa06_Read;
        public int iMinCxSupRampa06_Read
        {
            get => _iMinCxSupRampa06_Read;
            set
            {
                if (_iMinCxSupRampa06_Read != value)
                {
                    _iMinCxSupRampa06_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa07_Read;
        public int iMinCxSupRampa07_Read
        {
            get => _iMinCxSupRampa07_Read;
            set
            {
                if (_iMinCxSupRampa07_Read != value)
                {
                    _iMinCxSupRampa07_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupRampa08_Read;
        public int iMinCxSupRampa08_Read
        {
            get => _iMinCxSupRampa08_Read;
            set
            {
                if (_iMinCxSupRampa08_Read != value)
                {
                    _iMinCxSupRampa08_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Tempo programado dos Patamares Superiores
        private int _iHorCxSupPatamar01_Read;
        public int iHorCxSupPatamar01_Read
        {
            get => _iHorCxSupPatamar01_Read;
            set
            {
                if (_iHorCxSupPatamar01_Read != value)
                {
                    _iHorCxSupPatamar01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar01_Write;
        public int? iHorCxSupPatamar01_Write
        {
            get => _iHorCxSupPatamar01_Write;
            set
            {
                if (_iHorCxSupPatamar01_Write != value)
                {
                    _iHorCxSupPatamar01_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar02_Read;
        public int iHorCxSupPatamar02_Read
        {
            get => _iHorCxSupPatamar02_Read;
            set
            {
                if (_iHorCxSupPatamar02_Read != value)
                {
                    _iHorCxSupPatamar02_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar02_Write;
        public int? iHorCxSupPatamar02_Write
        {
            get => _iHorCxSupPatamar02_Write;
            set
            {
                if (_iHorCxSupPatamar02_Write != value)
                {
                    _iHorCxSupPatamar02_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar03_Read;
        public int iHorCxSupPatamar03_Read
        {
            get => _iHorCxSupPatamar03_Read;
            set
            {
                if (_iHorCxSupPatamar03_Read != value)
                {
                    _iHorCxSupPatamar03_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar03_Write;
        public int? iHorCxSupPatamar03_Write
        {
            get => _iHorCxSupPatamar03_Write;
            set
            {
                if (_iHorCxSupPatamar03_Write != value)
                {
                    _iHorCxSupPatamar03_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar04_Read;
        public int iHorCxSupPatamar04_Read
        {
            get => _iHorCxSupPatamar04_Read;
            set
            {
                if (_iHorCxSupPatamar04_Read != value)
                {
                    _iHorCxSupPatamar04_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar04_Write;
        public int? iHorCxSupPatamar04_Write
        {
            get => _iHorCxSupPatamar04_Write;
            set
            {
                if (_iHorCxSupPatamar04_Write != value)
                {
                    _iHorCxSupPatamar04_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar05_Read;
        public int iHorCxSupPatamar05_Read
        {
            get => _iHorCxSupPatamar05_Read;
            set
            {
                if (_iHorCxSupPatamar05_Read != value)
                {
                    _iHorCxSupPatamar05_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar05_Write;
        public int? iHorCxSupPatamar05_Write
        {
            get => _iHorCxSupPatamar05_Write;
            set
            {
                if (_iHorCxSupPatamar05_Write != value)
                {
                    _iHorCxSupPatamar05_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar06_Read;
        public int iHorCxSupPatamar06_Read
        {
            get => _iHorCxSupPatamar06_Read;
            set
            {
                if (_iHorCxSupPatamar06_Read != value)
                {
                    _iHorCxSupPatamar06_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar06_Write;
        public int? iHorCxSupPatamar06_Write
        {
            get => _iHorCxSupPatamar06_Write;
            set
            {
                if (_iHorCxSupPatamar06_Write != value)
                {
                    _iHorCxSupPatamar06_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar07_Read;
        public int iHorCxSupPatamar07_Read
        {
            get => _iHorCxSupPatamar07_Read;
            set
            {
                if (_iHorCxSupPatamar07_Read != value)
                {
                    _iHorCxSupPatamar07_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar07_Write;
        public int? iHorCxSupPatamar07_Write
        {
            get => _iHorCxSupPatamar07_Write;
            set
            {
                if (_iHorCxSupPatamar07_Write != value)
                {
                    _iHorCxSupPatamar07_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorCxSupPatamar08_Read;
        public int iHorCxSupPatamar08_Read
        {
            get => _iHorCxSupPatamar08_Read;
            set
            {
                if (_iHorCxSupPatamar08_Read != value)
                {
                    _iHorCxSupPatamar08_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iHorCxSupPatamar08_Write;
        public int? iHorCxSupPatamar08_Write
        {
            get => _iHorCxSupPatamar08_Write;
            set
            {
                if (_iHorCxSupPatamar08_Write != value)
                {
                    _iHorCxSupPatamar08_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar01_Read;
        public int iMinCxSupPatamar01_Read
        {
            get => _iMinCxSupPatamar01_Read;
            set
            {
                if (_iMinCxSupPatamar01_Read != value)
                {
                    _iMinCxSupPatamar01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar01_Write;
        public int? iMinCxSupPatamar01_Write
        {
            get => _iMinCxSupPatamar01_Write;
            set
            {
                if (_iMinCxSupPatamar01_Write != value)
                {
                    _iMinCxSupPatamar01_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar02_Read;
        public int iMinCxSupPatamar02_Read
        {
            get => _iMinCxSupPatamar02_Read;
            set
            {
                if (_iMinCxSupPatamar02_Read != value)
                {
                    _iMinCxSupPatamar02_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar02_Write;
        public int? iMinCxSupPatamar02_Write
        {
            get => _iMinCxSupPatamar02_Write;
            set
            {
                if (_iMinCxSupPatamar02_Write != value)
                {
                    _iMinCxSupPatamar02_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar03_Read;
        public int iMinCxSupPatamar03_Read
        {
            get => _iMinCxSupPatamar03_Read;
            set
            {
                if (_iMinCxSupPatamar03_Read != value)
                {
                    _iMinCxSupPatamar03_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar03_Write;
        public int? iMinCxSupPatamar03_Write
        {
            get => _iMinCxSupPatamar03_Write;
            set
            {
                if (_iMinCxSupPatamar03_Write != value)
                {
                    _iMinCxSupPatamar03_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar04_Read;
        public int iMinCxSupPatamar04_Read
        {
            get => _iMinCxSupPatamar04_Read;
            set
            {
                if (_iMinCxSupPatamar04_Read != value)
                {
                    _iMinCxSupPatamar04_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar04_Write;
        public int? iMinCxSupPatamar04_Write
        {
            get => _iMinCxSupPatamar04_Write;
            set
            {
                if (_iMinCxSupPatamar04_Write != value)
                {
                    _iMinCxSupPatamar04_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar05_Read;
        public int iMinCxSupPatamar05_Read
        {
            get => _iMinCxSupPatamar05_Read;
            set
            {
                if (_iMinCxSupPatamar05_Read != value)
                {
                    _iMinCxSupPatamar05_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar05_Write;
        public int? iMinCxSupPatamar05_Write
        {
            get => _iMinCxSupPatamar05_Write;
            set
            {
                if (_iMinCxSupPatamar05_Write != value)
                {
                    _iMinCxSupPatamar05_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar06_Read;
        public int iMinCxSupPatamar06_Read
        {
            get => _iMinCxSupPatamar06_Read;
            set
            {
                if (_iMinCxSupPatamar06_Read != value)
                {
                    _iMinCxSupPatamar06_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar06_Write;
        public int? iMinCxSupPatamar06_Write
        {
            get => _iMinCxSupPatamar06_Write;
            set
            {
                if (_iMinCxSupPatamar06_Write != value)
                {
                    _iMinCxSupPatamar06_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar07_Read;
        public int iMinCxSupPatamar07_Read
        {
            get => _iMinCxSupPatamar07_Read;
            set
            {
                if (_iMinCxSupPatamar07_Read != value)
                {
                    _iMinCxSupPatamar07_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar07_Write;
        public int? iMinCxSupPatamar07_Write
        {
            get => _iMinCxSupPatamar07_Write;
            set
            {
                if (_iMinCxSupPatamar07_Write != value)
                {
                    _iMinCxSupPatamar07_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinCxSupPatamar08_Read;
        public int iMinCxSupPatamar08_Read
        {
            get => _iMinCxSupPatamar08_Read;
            set
            {
                if (_iMinCxSupPatamar08_Read != value)
                {
                    _iMinCxSupPatamar08_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinCxSupPatamar08_Write;
        public int? iMinCxSupPatamar08_Write
        {
            get => _iMinCxSupPatamar08_Write;
            set
            {
                if (_iMinCxSupPatamar08_Write != value)
                {
                    _iMinCxSupPatamar08_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Status dos estágios Superiores
        private int? _uStatusAquecimentoSup_Read;
        public int? uStatusAquecimentoSup_Read
        {
            get => _uStatusAquecimentoSup_Read;
            set
            {
                if (_uStatusAquecimentoSup_Read != value)
                {
                    _uStatusAquecimentoSup_Read = value;
                    cStatusAquecimentoSup_Color = ObterCorStatus(value ?? 0);
                    sStatusAquecimentoSup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa01Sup_Read;
        public int? wStatusRampa01Sup_Read
        {
            get => _wStatusRampa01Sup_Read;
            set
            {
                if (_wStatusRampa01Sup_Read != value)
                {
                    _wStatusRampa01Sup_Read = value;
                    cStatusRampa01Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa01Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa02Sup_Read;
        public int? wStatusRampa02Sup_Read
        {
            get => _wStatusRampa02Sup_Read;
            set
            {
                if (_wStatusRampa02Sup_Read != value)
                {
                    _wStatusRampa02Sup_Read = value;
                    cStatusRampa02Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa02Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa03Sup_Read;
        public int? wStatusRampa03Sup_Read
        {
            get => _wStatusRampa03Sup_Read;
            set
            {
                if (_wStatusRampa03Sup_Read != value)
                {
                    _wStatusRampa03Sup_Read = value;
                    cStatusRampa03Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa03Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa04Sup_Read;
        public int? wStatusRampa04Sup_Read
        {
            get => _wStatusRampa04Sup_Read;
            set
            {
                if (_wStatusRampa04Sup_Read != value)
                {
                    _wStatusRampa04Sup_Read = value;
                    cStatusRampa04Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa04Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa05Sup_Read;
        public int? wStatusRampa05Sup_Read
        {
            get => _wStatusRampa05Sup_Read;
            set
            {
                if (_wStatusRampa05Sup_Read != value)
                {
                    _wStatusRampa05Sup_Read = value;
                    cStatusRampa05Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa05Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa06Sup_Read;
        public int? wStatusRampa06Sup_Read
        {
            get => _wStatusRampa06Sup_Read;
            set
            {
                if (_wStatusRampa06Sup_Read != value)
                {
                    _wStatusRampa06Sup_Read = value;
                    cStatusRampa06Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa06Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa07Sup_Read;
        public int? wStatusRampa07Sup_Read
        {
            get => _wStatusRampa07Sup_Read;
            set
            {
                if (_wStatusRampa07Sup_Read != value)
                {
                    _wStatusRampa07Sup_Read = value;
                    cStatusRampa07Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa07Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusRampa08Sup_Read;
        public int? wStatusRampa08Sup_Read
        {
            get => _wStatusRampa08Sup_Read;
            set
            {
                if (_wStatusRampa08Sup_Read != value)
                {
                    _wStatusRampa08Sup_Read = value;
                    cStatusRampa08Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusRampa08Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }

        private int? _wStatusPatamar01Sup_Read;
        public int? wStatusPatamar01Sup_Read
        {
            get => _wStatusPatamar01Sup_Read;
            set
            {
                if (_wStatusPatamar01Sup_Read != value)
                {
                    _wStatusPatamar01Sup_Read = value;
                    cStatusPatamar01Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar01Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar02Sup_Read;
        public int? wStatusPatamar02Sup_Read
        {
            get => _wStatusPatamar02Sup_Read;
            set
            {
                if (_wStatusPatamar02Sup_Read != value)
                {
                    _wStatusPatamar02Sup_Read = value;
                    cStatusPatamar02Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar02Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar03Sup_Read;
        public int? wStatusPatamar03Sup_Read
        {
            get => _wStatusPatamar03Sup_Read;
            set
            {
                if (_wStatusPatamar03Sup_Read != value)
                {
                    _wStatusPatamar03Sup_Read = value;
                    cStatusPatamar03Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar03Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar04Sup_Read;
        public int? wStatusPatamar04Sup_Read
        {
            get => _wStatusPatamar04Sup_Read;
            set
            {
                if (_wStatusPatamar04Sup_Read != value)
                {
                    _wStatusPatamar04Sup_Read = value;
                    cStatusPatamar04Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar04Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar05Sup_Read;
        public int? wStatusPatamar05Sup_Read
        {
            get => _wStatusPatamar05Sup_Read;
            set
            {
                if (_wStatusPatamar05Sup_Read != value)
                {
                    _wStatusPatamar05Sup_Read = value;
                    cStatusPatamar05Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar05Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar06Sup_Read;
        public int? wStatusPatamar06Sup_Read
        {
            get => _wStatusPatamar06Sup_Read;
            set
            {
                if (_wStatusPatamar06Sup_Read != value)
                {
                    _wStatusPatamar06Sup_Read = value;
                    cStatusPatamar06Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar06Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar07Sup_Read;
        public int? wStatusPatamar07Sup_Read
        {
            get => _wStatusPatamar07Sup_Read;
            set
            {
                if (_wStatusPatamar07Sup_Read != value)
                {
                    _wStatusPatamar07Sup_Read = value;
                    cStatusPatamar07Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar07Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
        private int? _wStatusPatamar08Sup_Read;
        public int? wStatusPatamar08Sup_Read
        {
            get => _wStatusPatamar08Sup_Read;
            set
            {
                if (_wStatusPatamar08Sup_Read != value)
                {
                    _wStatusPatamar08Sup_Read = value;
                    cStatusPatamar08Sup_Color = ObterCorStatus(value ?? 0);
                    sStatusPatamar08Sup_Legend = ObterLegendaStatus(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region Cores dos Estágios Superiores

        private Color _cStatusAquecimentoSup_Color;
        public Color cStatusAquecimentoSup_Color
        {
            get => _cStatusAquecimentoSup_Color;
            set
            {
                if (_cStatusAquecimentoSup_Color != value)
                {

                    _cStatusAquecimentoSup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa01Sup_Color;
        public Color cStatusRampa01Sup_Color
        {
            get => _cStatusRampa01Sup_Color;
            set
            {
                if (_cStatusRampa01Sup_Color != value)
                {
                    _cStatusRampa01Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa02Sup_Color;
        public Color cStatusRampa02Sup_Color
        {
            get => _cStatusRampa02Sup_Color;
            set
            {
                if (_cStatusRampa02Sup_Color != value)
                {
                    _cStatusRampa02Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa03Sup_Color;
        public Color cStatusRampa03Sup_Color
        {
            get => _cStatusRampa03Sup_Color;
            set
            {
                if (_cStatusRampa03Sup_Color != value)
                {
                    _cStatusRampa03Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa04Sup_Color;
        public Color cStatusRampa04Sup_Color
        {
            get => _cStatusRampa04Sup_Color;
            set
            {
                if (_cStatusRampa04Sup_Color != value)
                {
                    _cStatusRampa04Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa05Sup_Color;
        public Color cStatusRampa05Sup_Color
        {
            get => _cStatusRampa05Sup_Color;
            set
            {
                if (_cStatusRampa05Sup_Color != value)
                {
                    _cStatusRampa05Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa06Sup_Color;
        public Color cStatusRampa06Sup_Color
        {
            get => _cStatusRampa06Sup_Color;
            set
            {
                if (_cStatusRampa06Sup_Color != value)
                {
                    _cStatusRampa06Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa07Sup_Color;
        public Color cStatusRampa07Sup_Color
        {
            get => _cStatusRampa07Sup_Color;
            set
            {
                if (_cStatusRampa07Sup_Color != value)
                {
                    _cStatusRampa07Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusRampa08Sup_Color;
        public Color cStatusRampa08Sup_Color
        {
            get => _cStatusRampa08Sup_Color;
            set
            {
                if (_cStatusRampa08Sup_Color != value)
                {
                    _cStatusRampa08Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }

        private Color _cStatusPatamar01Sup_Color;
        public Color cStatusPatamar01Sup_Color
        {
            get => _cStatusPatamar01Sup_Color;
            set
            {
                if (_cStatusPatamar01Sup_Color != value)
                {
                    _cStatusPatamar01Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar02Sup_Color;
        public Color cStatusPatamar02Sup_Color
        {
            get => _cStatusPatamar02Sup_Color;
            set
            {
                if (_cStatusPatamar02Sup_Color != value)
                {
                    _cStatusPatamar02Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar03Sup_Color;
        public Color cStatusPatamar03Sup_Color
        {
            get => _cStatusPatamar03Sup_Color;
            set
            {
                if (_cStatusPatamar03Sup_Color != value)
                {
                    _cStatusPatamar03Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar04Sup_Color;
        public Color cStatusPatamar04Sup_Color
        {
            get => _cStatusPatamar04Sup_Color;
            set
            {
                if (_cStatusPatamar04Sup_Color != value)
                {
                    _cStatusPatamar04Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar05Sup_Color;
        public Color cStatusPatamar05Sup_Color
        {
            get => _cStatusPatamar05Sup_Color;
            set
            {
                if (_cStatusPatamar05Sup_Color != value)
                {
                    _cStatusPatamar05Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar06Sup_Color;
        public Color cStatusPatamar06Sup_Color
        {
            get => _cStatusPatamar06Sup_Color;
            set
            {
                if (_cStatusPatamar06Sup_Color != value)
                {
                    _cStatusPatamar06Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar07Sup_Color;
        public Color cStatusPatamar07Sup_Color
        {
            get => _cStatusPatamar07Sup_Color;
            set
            {
                if (_cStatusPatamar07Sup_Color != value)
                {
                    _cStatusPatamar07Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPatamar08Sup_Color;
        public Color cStatusPatamar08Sup_Color
        {
            get => _cStatusPatamar08Sup_Color;
            set
            {
                if (_cStatusPatamar08Sup_Color != value)
                {
                    _cStatusPatamar08Sup_Color = value;
                    OnPropertyChanged();
                }
            }
        }

        private Color ObterCorStatus(int status)
        {
            return status switch
            {
                0 => Colors.Red,
                1 => Colors.Green,
                2 => Colors.Black,

                _ => Colors.Gray
            };
        }

        private string _sStatusAquecimentoSup_Legend;
        public string sStatusAquecimentoSup_Legend
        {
            get => _sStatusAquecimentoSup_Legend;
            set
            {
                if (_sStatusAquecimentoSup_Legend != value)
                {

                    _sStatusAquecimentoSup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa01Sup_Legend;
        public string sStatusRampa01Sup_Legend
        {
            get => _sStatusRampa01Sup_Legend;
            set
            {
                if (_sStatusRampa01Sup_Legend != value)
                {
                    _sStatusRampa01Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa02Sup_Legend;
        public string sStatusRampa02Sup_Legend
        {
            get => _sStatusRampa02Sup_Legend;
            set
            {
                if (_sStatusRampa02Sup_Legend != value)
                {
                    _sStatusRampa02Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa03Sup_Legend;
        public string sStatusRampa03Sup_Legend
        {
            get => _sStatusRampa03Sup_Legend;
            set
            {
                if (_sStatusRampa03Sup_Legend != value)
                {
                    _sStatusRampa03Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa04Sup_Legend;
        public string sStatusRampa04Sup_Legend
        {
            get => _sStatusRampa04Sup_Legend;
            set
            {
                if (_sStatusRampa04Sup_Legend != value)
                {
                    _sStatusRampa04Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa05Sup_Legend;
        public string sStatusRampa05Sup_Legend
        {
            get => _sStatusRampa05Sup_Legend;
            set
            {
                if (_sStatusRampa05Sup_Legend != value)
                {
                    _sStatusRampa05Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa06Sup_Legend;
        public string sStatusRampa06Sup_Legend
        {
            get => _sStatusRampa06Sup_Legend;
            set
            {
                if (_sStatusRampa06Sup_Legend != value)
                {
                    _sStatusRampa06Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa07Sup_Legend;
        public string sStatusRampa07Sup_Legend
        {
            get => _sStatusRampa07Sup_Legend;
            set
            {
                if (_sStatusRampa07Sup_Legend != value)
                {
                    _sStatusRampa07Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusRampa08Sup_Legend;
        public string sStatusRampa08Sup_Legend
        {
            get => _sStatusRampa08Sup_Legend;
            set
            {
                if (_sStatusRampa08Sup_Legend != value)
                {
                    _sStatusRampa08Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _sStatusPatamar01Sup_Legend;
        public string sStatusPatamar01Sup_Legend
        {
            get => _sStatusPatamar01Sup_Legend;
            set
            {
                if (_sStatusPatamar01Sup_Legend != value)
                {
                    _sStatusPatamar01Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar02Sup_Legend;
        public string sStatusPatamar02Sup_Legend
        {
            get => _sStatusPatamar02Sup_Legend;
            set
            {
                if (_sStatusPatamar02Sup_Legend != value)
                {
                    _sStatusPatamar02Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar03Sup_Legend;
        public string sStatusPatamar03Sup_Legend
        {
            get => _sStatusPatamar03Sup_Legend;
            set
            {
                if (_sStatusPatamar03Sup_Legend != value)
                {
                    _sStatusPatamar03Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar04Sup_Legend;
        public string sStatusPatamar04Sup_Legend
        {
            get => _sStatusPatamar04Sup_Legend;
            set
            {
                if (_sStatusPatamar04Sup_Legend != value)
                {
                    _sStatusPatamar04Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar05Sup_Legend;
        public string sStatusPatamar05Sup_Legend
        {
            get => _sStatusPatamar05Sup_Legend;
            set
            {
                if (_sStatusPatamar05Sup_Legend != value)
                {
                    _sStatusPatamar05Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar06Sup_Legend;
        public string sStatusPatamar06Sup_Legend
        {
            get => _sStatusPatamar06Sup_Legend;
            set
            {
                if (_sStatusPatamar06Sup_Legend != value)
                {
                    _sStatusPatamar06Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar07Sup_Legend;
        public string sStatusPatamar07Sup_Legend
        {
            get => _sStatusPatamar07Sup_Legend;
            set
            {
                if (_sStatusPatamar07Sup_Legend != value)
                {
                    _sStatusPatamar07Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPatamar08Sup_Legend;
        public string sStatusPatamar08Sup_Legend
        {
            get => _sStatusPatamar08Sup_Legend;
            set
            {
                if (_sStatusPatamar08Sup_Legend != value)
                {
                    _sStatusPatamar08Sup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }

        private string ObterLegendaStatus(int status)
        {
            return status switch
            {
                0 => "Desligado",
                1 => "Em Ciclo",
                2 => "Finalizado",

                _ => "Null"
            };
        }

        #endregion

        #region Tempo da Bomba Ligada no Fim do Ciclo
        private int _iMinDecorTasbSup_Read;
        public int iMinDecorTasbSup_Read
        {
            get => _iMinDecorTasbSup_Read;
            set
            {
                if (_iMinDecorTasbSup_Read != value)
                {
                    _iMinDecorTasbSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorTasbSup_Read;
        public int iSegDecorTasbSup_Read
        {
            get => _iSegDecorTasbSup_Read;
            set
            {
                if (_iSegDecorTasbSup_Read != value)
                {
                    _iSegDecorTasbSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinTasbCxSup_Read;
        public int iMinTasbCxSup_Read
        {
            get => _iMinTasbCxSup_Read;
            set
            {
                if (_iMinTasbCxSup_Read != value)
                {
                    _iMinTasbCxSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int? _iMinTasbCxSup_Write;
        public int? iMinTasbCxSup_Write
        {
            get => _iMinTasbCxSup_Write;
            set
            {
                if (_iMinTasbCxSup_Write != value)
                {
                    _iMinTasbCxSup_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Comandos de Inicialziação

        private string? _sLegenda_CicloLaminaSupHabilitado;
        public string? sLegenda_CicloLaminaSupHabilitado
        {
            get => _sLegenda_CicloLaminaSupHabilitado;
            set
            {
                if (_sLegenda_CicloLaminaSupHabilitado != value)
                {
                    _sLegenda_CicloLaminaSupHabilitado = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color? _cLegenda_CicloLaminaSupHabilitado;
        public Color? cLegenda_CicloLaminaSupHabilitado
        {
            get => _cLegenda_CicloLaminaSupHabilitado;
            set
            {
                if (_cLegenda_CicloLaminaSupHabilitado != value)
                {
                    _cLegenda_CicloLaminaSupHabilitado = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color? _cStatus_CicloLaminaSupHabilitado;
        public Color? cStatus_CicloLaminaSupHabilitado
        {
            get => _cStatus_CicloLaminaSupHabilitado;
            set
            {
                if (_cStatus_CicloLaminaSupHabilitado != value)
                {
                    _cStatus_CicloLaminaSupHabilitado = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #endregion



    }
}
