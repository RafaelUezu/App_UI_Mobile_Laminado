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

        #region Tempos Decorridos das Rampas e Patamares Superiores
        private int _iHorDecorRampa01Sup_Read;
        public int iHorDecorRampa01Sup_Read
        {
            get => _iHorDecorRampa01Sup_Read;
            set
            {
                if (_iHorDecorRampa01Sup_Read != value)
                {
                    _iHorDecorRampa01Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa02Sup_Read;
        public int iHorDecorRampa02Sup_Read
        {
            get => _iHorDecorRampa02Sup_Read;
            set
            {
                if (_iHorDecorRampa02Sup_Read != value)
                {
                    _iHorDecorRampa02Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa03Sup_Read;
        public int iHorDecorRampa03Sup_Read
        {
            get => _iHorDecorRampa03Sup_Read;
            set
            {
                if (_iHorDecorRampa03Sup_Read != value)
                {
                    _iHorDecorRampa03Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa04Sup_Read;
        public int iHorDecorRampa04Sup_Read
        {
            get => _iHorDecorRampa04Sup_Read;
            set
            {
                if (_iHorDecorRampa04Sup_Read != value)
                {
                    _iHorDecorRampa04Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa05Sup_Read;
        public int iHorDecorRampa05Sup_Read
        {
            get => _iHorDecorRampa05Sup_Read;
            set
            {
                if (_iHorDecorRampa05Sup_Read != value)
                {
                    _iHorDecorRampa05Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa06Sup_Read;
        public int iHorDecorRampa06Sup_Read
        {
            get => _iHorDecorRampa06Sup_Read;
            set
            {
                if (_iHorDecorRampa06Sup_Read != value)
                {
                    _iHorDecorRampa06Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa07Sup_Read;
        public int iHorDecorRampa07Sup_Read
        {
            get => _iHorDecorRampa07Sup_Read;
            set
            {
                if (_iHorDecorRampa07Sup_Read != value)
                {
                    _iHorDecorRampa07Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorRampa08Sup_Read;
        public int iHorDecorRampa08Sup_Read
        {
            get => _iHorDecorRampa08Sup_Read;
            set
            {
                if (_iHorDecorRampa08Sup_Read != value)
                {
                    _iHorDecorRampa08Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _iMinDecorRampa01Sup_Read;
        public int iMinDecorRampa01Sup_Read
        {
            get => _iMinDecorRampa01Sup_Read;
            set
            {
                if (_iMinDecorRampa01Sup_Read != value)
                {
                    _iMinDecorRampa01Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa02Sup_Read;
        public int iMinDecorRampa02Sup_Read
        {
            get => _iMinDecorRampa02Sup_Read;
            set
            {
                if (_iMinDecorRampa02Sup_Read != value)
                {
                    _iMinDecorRampa02Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa03Sup_Read;
        public int iMinDecorRampa03Sup_Read
        {
            get => _iMinDecorRampa03Sup_Read;
            set
            {
                if (_iMinDecorRampa03Sup_Read != value)
                {
                    _iMinDecorRampa03Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa04Sup_Read;
        public int iMinDecorRampa04Sup_Read
        {
            get => _iMinDecorRampa04Sup_Read;
            set
            {
                if (_iMinDecorRampa04Sup_Read != value)
                {
                    _iMinDecorRampa04Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa05Sup_Read;
        public int iMinDecorRampa05Sup_Read
        {
            get => _iMinDecorRampa05Sup_Read;
            set
            {
                if (_iMinDecorRampa05Sup_Read != value)
                {
                    _iMinDecorRampa05Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa06Sup_Read;
        public int iMinDecorRampa06Sup_Read
        {
            get => _iMinDecorRampa06Sup_Read;
            set
            {
                if (_iMinDecorRampa06Sup_Read != value)
                {
                    _iMinDecorRampa06Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa07Sup_Read;
        public int iMinDecorRampa07Sup_Read
        {
            get => _iMinDecorRampa07Sup_Read;
            set
            {
                if (_iMinDecorRampa07Sup_Read != value)
                {
                    _iMinDecorRampa07Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorRampa08Sup_Read;
        public int iMinDecorRampa08Sup_Read
        {
            get => _iMinDecorRampa08Sup_Read;
            set
            {
                if (_iMinDecorRampa08Sup_Read != value)
                {
                    _iMinDecorRampa08Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _iSegDecorRampa01Sup_Read;
        public int iSegDecorRampa01Sup_Read
        {
            get => _iSegDecorRampa01Sup_Read;
            set
            {
                if (_iSegDecorRampa01Sup_Read != value)
                {
                    _iSegDecorRampa01Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa02Sup_Read;
        public int iSegDecorRampa02Sup_Read
        {
            get => _iSegDecorRampa02Sup_Read;
            set
            {
                if (_iSegDecorRampa02Sup_Read != value)
                {
                    _iSegDecorRampa02Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa03Sup_Read;
        public int iSegDecorRampa03Sup_Read
        {
            get => _iSegDecorRampa03Sup_Read;
            set
            {
                if (_iSegDecorRampa03Sup_Read != value)
                {
                    _iSegDecorRampa03Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa04Sup_Read;
        public int iSegDecorRampa04Sup_Read
        {
            get => _iSegDecorRampa04Sup_Read;
            set
            {
                if (_iSegDecorRampa04Sup_Read != value)
                {
                    _iSegDecorRampa04Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa05Sup_Read;
        public int iSegDecorRampa05Sup_Read
        {
            get => _iSegDecorRampa05Sup_Read;
            set
            {
                if (_iSegDecorRampa05Sup_Read != value)
                {
                    _iSegDecorRampa05Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa06Sup_Read;
        public int iSegDecorRampa06Sup_Read
        {
            get => _iSegDecorRampa06Sup_Read;
            set
            {
                if (_iSegDecorRampa06Sup_Read != value)
                {
                    _iSegDecorRampa06Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa07Sup_Read;
        public int iSegDecorRampa07Sup_Read
        {
            get => _iSegDecorRampa07Sup_Read;
            set
            {
                if (_iSegDecorRampa07Sup_Read != value)
                {
                    _iSegDecorRampa07Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorRampa08Sup_Read;
        public int iSegDecorRampa08Sup_Read
        {
            get => _iSegDecorRampa08Sup_Read;
            set
            {
                if (_iSegDecorRampa08Sup_Read != value)
                {
                    _iSegDecorRampa08Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _iHorDecorPatam01Sup_Read;
        public int iHorDecorPatam01Sup_Read
        {
            get => _iHorDecorPatam01Sup_Read;
            set
            {
                if (_iHorDecorPatam01Sup_Read != value)
                {
                    _iHorDecorPatam01Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam02Sup_Read;
        public int iHorDecorPatam02Sup_Read
        {
            get => _iHorDecorPatam02Sup_Read;
            set
            {
                if (_iHorDecorPatam02Sup_Read != value)
                {
                    _iHorDecorPatam02Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam03Sup_Read;
        public int iHorDecorPatam03Sup_Read
        {
            get => _iHorDecorPatam03Sup_Read;
            set
            {
                if (_iHorDecorPatam03Sup_Read != value)
                {
                    _iHorDecorPatam03Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam04Sup_Read;
        public int iHorDecorPatam04Sup_Read
        {
            get => _iHorDecorPatam04Sup_Read;
            set
            {
                if (_iHorDecorPatam04Sup_Read != value)
                {
                    _iHorDecorPatam04Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam05Sup_Read;
        public int iHorDecorPatam05Sup_Read
        {
            get => _iHorDecorPatam05Sup_Read;
            set
            {
                if (_iHorDecorPatam05Sup_Read != value)
                {
                    _iHorDecorPatam05Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam06Sup_Read;
        public int iHorDecorPatam06Sup_Read
        {
            get => _iHorDecorPatam06Sup_Read;
            set
            {
                if (_iHorDecorPatam06Sup_Read != value)
                {
                    _iHorDecorPatam06Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam07Sup_Read;
        public int iHorDecorPatam07Sup_Read
        {
            get => _iHorDecorPatam07Sup_Read;
            set
            {
                if (_iHorDecorPatam07Sup_Read != value)
                {
                    _iHorDecorPatam07Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorDecorPatam08Sup_Read;
        public int iHorDecorPatam08Sup_Read
        {
            get => _iHorDecorPatam08Sup_Read;
            set
            {
                if (_iHorDecorPatam08Sup_Read != value)
                {
                    _iHorDecorPatam08Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _iMinDecorPatam01Sup_Read;
        public int iMinDecorPatam01Sup_Read
        {
            get => _iMinDecorPatam01Sup_Read;
            set
            {
                if (_iMinDecorPatam01Sup_Read != value)
                {
                    _iMinDecorPatam01Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam02Sup_Read;
        public int iMinDecorPatam02Sup_Read
        {
            get => _iMinDecorPatam02Sup_Read;
            set
            {
                if (_iMinDecorPatam02Sup_Read != value)
                {
                    _iMinDecorPatam02Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam03Sup_Read;
        public int iMinDecorPatam03Sup_Read
        {
            get => _iMinDecorPatam03Sup_Read;
            set
            {
                if (_iMinDecorPatam03Sup_Read != value)
                {
                    _iMinDecorPatam03Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam04Sup_Read;
        public int iMinDecorPatam04Sup_Read
        {
            get => _iMinDecorPatam04Sup_Read;
            set
            {
                if (_iMinDecorPatam04Sup_Read != value)
                {
                    _iMinDecorPatam04Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam05Sup_Read;
        public int iMinDecorPatam05Sup_Read
        {
            get => _iMinDecorPatam05Sup_Read;
            set
            {
                if (_iMinDecorPatam05Sup_Read != value)
                {
                    _iMinDecorPatam05Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam06Sup_Read;
        public int iMinDecorPatam06Sup_Read
        {
            get => _iMinDecorPatam06Sup_Read;
            set
            {
                if (_iMinDecorPatam06Sup_Read != value)
                {
                    _iMinDecorPatam06Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam07Sup_Read;
        public int iMinDecorPatam07Sup_Read
        {
            get => _iMinDecorPatam07Sup_Read;
            set
            {
                if (_iMinDecorPatam07Sup_Read != value)
                {
                    _iMinDecorPatam07Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorPatam08Sup_Read;
        public int iMinDecorPatam08Sup_Read
        {
            get => _iMinDecorPatam08Sup_Read;
            set
            {
                if (_iMinDecorPatam08Sup_Read != value)
                {
                    _iMinDecorPatam08Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _iSegDecorPatam01Sup_Read;
        public int iSegDecorPatam01Sup_Read
        {
            get => _iSegDecorPatam01Sup_Read;
            set
            {
                if (_iSegDecorPatam01Sup_Read != value)
                {
                    _iSegDecorPatam01Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam02Sup_Read;
        public int iSegDecorPatam02Sup_Read
        {
            get => _iSegDecorPatam02Sup_Read;
            set
            {
                if (_iSegDecorPatam02Sup_Read != value)
                {
                    _iSegDecorPatam02Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam03Sup_Read;
        public int iSegDecorPatam03Sup_Read
        {
            get => _iSegDecorPatam03Sup_Read;
            set
            {
                if (_iSegDecorPatam03Sup_Read != value)
                {
                    _iSegDecorPatam03Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam04Sup_Read;
        public int iSegDecorPatam04Sup_Read
        {
            get => _iSegDecorPatam04Sup_Read;
            set
            {
                if (_iSegDecorPatam04Sup_Read != value)
                {
                    _iSegDecorPatam04Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam05Sup_Read;
        public int iSegDecorPatam05Sup_Read
        {
            get => _iSegDecorPatam05Sup_Read;
            set
            {
                if (_iSegDecorPatam05Sup_Read != value)
                {
                    _iSegDecorPatam05Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam06Sup_Read;
        public int iSegDecorPatam06Sup_Read
        {
            get => _iSegDecorPatam06Sup_Read;
            set
            {
                if (_iSegDecorPatam06Sup_Read != value)
                {
                    _iSegDecorPatam06Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam07Sup_Read;
        public int iSegDecorPatam07Sup_Read
        {
            get => _iSegDecorPatam07Sup_Read;
            set
            {
                if (_iSegDecorPatam07Sup_Read != value)
                {
                    _iSegDecorPatam07Sup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorPatam08Sup_Read;
        public int iSegDecorPatam08Sup_Read
        {
            get => _iSegDecorPatam08Sup_Read;
            set
            {
                if (_iSegDecorPatam08Sup_Read != value)
                {
                    _iSegDecorPatam08Sup_Read = value;
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
        private int _uStatusAquecimentoSup_Read;
        public int uStatusAquecimentoSup_Read
        {
            get => _uStatusAquecimentoSup_Read;
            set
            {
                if (_uStatusAquecimentoSup_Read != value)
                {
                    _uStatusAquecimentoSup_Read = value;
                    cStatusAquecimentoSup_Color = ObterCorStatus(value);
                    sStatusAquecimentoSup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa01Sup_Read;
        public int wStatusRampa01Sup_Read
        {
            get => _wStatusRampa01Sup_Read;
            set
            {
                if (_wStatusRampa01Sup_Read != value)
                {
                    _wStatusRampa01Sup_Read = value;
                    cStatusRampa01Sup_Color = ObterCorStatus(value);
                    sStatusRampa01Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa02Sup_Read;
        public int wStatusRampa02Sup_Read
        {
            get => _wStatusRampa02Sup_Read;
            set
            {
                if (_wStatusRampa02Sup_Read != value)
                {
                    _wStatusRampa02Sup_Read = value;
                    cStatusRampa02Sup_Color = ObterCorStatus(value);
                    sStatusRampa02Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa03Sup_Read;
        public int wStatusRampa03Sup_Read
        {
            get => _wStatusRampa03Sup_Read;
            set
            {
                if (_wStatusRampa03Sup_Read != value)
                {
                    _wStatusRampa03Sup_Read = value;
                    cStatusRampa03Sup_Color = ObterCorStatus(value);
                    sStatusRampa03Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa04Sup_Read;
        public int wStatusRampa04Sup_Read
        {
            get => _wStatusRampa04Sup_Read;
            set
            {
                if (_wStatusRampa04Sup_Read != value)
                {
                    _wStatusRampa04Sup_Read = value;
                    cStatusRampa04Sup_Color = ObterCorStatus(value);
                    sStatusRampa04Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa05Sup_Read;
        public int wStatusRampa05Sup_Read
        {
            get => _wStatusRampa05Sup_Read;
            set
            {
                if (_wStatusRampa05Sup_Read != value)
                {
                    _wStatusRampa05Sup_Read = value;
                    cStatusRampa05Sup_Color = ObterCorStatus(value);
                    sStatusRampa05Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa06Sup_Read;
        public int wStatusRampa06Sup_Read
        {
            get => _wStatusRampa06Sup_Read;
            set
            {
                if (_wStatusRampa06Sup_Read != value)
                {
                    _wStatusRampa06Sup_Read = value;
                    cStatusRampa06Sup_Color = ObterCorStatus(value);
                    sStatusRampa06Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa07Sup_Read;
        public int wStatusRampa07Sup_Read
        {
            get => _wStatusRampa07Sup_Read;
            set
            {
                if (_wStatusRampa07Sup_Read != value)
                {
                    _wStatusRampa07Sup_Read = value;
                    cStatusRampa07Sup_Color = ObterCorStatus(value);
                    sStatusRampa07Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusRampa08Sup_Read;
        public int wStatusRampa08Sup_Read
        {
            get => _wStatusRampa08Sup_Read;
            set
            {
                if (_wStatusRampa08Sup_Read != value)
                {
                    _wStatusRampa08Sup_Read = value;
                    cStatusRampa08Sup_Color = ObterCorStatus(value);
                    sStatusRampa08Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }

        private int _wStatusPatamar01Sup_Read;
        public int wStatusPatamar01Sup_Read
        {
            get => _wStatusPatamar01Sup_Read;
            set
            {
                if (_wStatusPatamar01Sup_Read != value)
                {
                    _wStatusPatamar01Sup_Read = value;
                    cStatusPatamar01Sup_Color = ObterCorStatus(value);
                    sStatusPatamar01Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar02Sup_Read;
        public int wStatusPatamar02Sup_Read
        {
            get => _wStatusPatamar02Sup_Read;
            set
            {
                if (_wStatusPatamar02Sup_Read != value)
                {
                    _wStatusPatamar02Sup_Read = value;
                    cStatusPatamar02Sup_Color = ObterCorStatus(value);
                    sStatusPatamar02Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar03Sup_Read;
        public int wStatusPatamar03Sup_Read
        {
            get => _wStatusPatamar03Sup_Read;
            set
            {
                if (_wStatusPatamar03Sup_Read != value)
                {
                    _wStatusPatamar03Sup_Read = value;
                    cStatusPatamar03Sup_Color = ObterCorStatus(value);
                    sStatusPatamar03Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar04Sup_Read;
        public int wStatusPatamar04Sup_Read
        {
            get => _wStatusPatamar04Sup_Read;
            set
            {
                if (_wStatusPatamar04Sup_Read != value)
                {
                    _wStatusPatamar04Sup_Read = value;
                    cStatusPatamar04Sup_Color = ObterCorStatus(value);
                    sStatusPatamar04Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar05Sup_Read;
        public int wStatusPatamar05Sup_Read
        {
            get => _wStatusPatamar05Sup_Read;
            set
            {
                if (_wStatusPatamar05Sup_Read != value)
                {
                    _wStatusPatamar05Sup_Read = value;
                    cStatusPatamar05Sup_Color = ObterCorStatus(value);
                    sStatusPatamar05Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar06Sup_Read;
        public int wStatusPatamar06Sup_Read
        {
            get => _wStatusPatamar06Sup_Read;
            set
            {
                if (_wStatusPatamar06Sup_Read != value)
                {
                    _wStatusPatamar06Sup_Read = value;
                    cStatusPatamar06Sup_Color = ObterCorStatus(value);
                    sStatusPatamar06Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar07Sup_Read;
        public int wStatusPatamar07Sup_Read
        {
            get => _wStatusPatamar07Sup_Read;
            set
            {
                if (_wStatusPatamar07Sup_Read != value)
                {
                    _wStatusPatamar07Sup_Read = value;
                    cStatusPatamar07Sup_Color = ObterCorStatus(value);
                    sStatusPatamar07Sup_Legend = ObterLegendaStatus(value);
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPatamar08Sup_Read;
        public int wStatusPatamar08Sup_Read
        {
            get => _wStatusPatamar08Sup_Read;
            set
            {
                if (_wStatusPatamar08Sup_Read != value)
                {
                    _wStatusPatamar08Sup_Read = value;
                    cStatusPatamar08Sup_Color = ObterCorStatus(value);
                    sStatusPatamar08Sup_Legend = ObterLegendaStatus(value);
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

        private String ObterLegendaStatus(int status)
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
        private int _iMinTasbCxSup_Write;
        public int iMinTasbCxSup_Write
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

        #region Tempo do Exaustor
        private int _iMinDecorResfrSup_Read;
        public int iMinDecorResfrSup_Read
        {
            get => _iMinDecorResfrSup_Read;
            set
            {
                if (_iMinDecorResfrSup_Read != value)
                {
                    _iMinDecorResfrSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorResfrSup_Read;
        public int iSegDecorResfrSup_Read
        {
            get => _iSegDecorResfrSup_Read;
            set
            {
                if (_iSegDecorResfrSup_Read != value)
                {
                    _iSegDecorResfrSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iTempoExaustorMinSup_Read;
        public int iTempoExaustorMinSup_Read
        {
            get => _iTempoExaustorMinSup_Read;
            set
            {
                if (_iTempoExaustorMinSup_Read != value)
                {
                    _iTempoExaustorMinSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Tempo para abertura da porta após finalização do ciclo
        private int _iMinDecorAbPortSup_Read;
        public int iMinDecorAbPortSup_Read
        {
            get => _iMinDecorAbPortSup_Read;
            set
            {
                if (_iMinDecorAbPortSup_Read != value)
                {
                    _iMinDecorAbPortSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorAbPortSup_Read;
        public int iSegDecorAbPortSup_Read
        {
            get => _iSegDecorAbPortSup_Read;
            set
            {
                if (_iSegDecorAbPortSup_Read != value)
                {
                    _iSegDecorAbPortSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iTempoAberturaSup_Read;
        public int iTempoAberturaSup_Read
        {
            get => _iTempoAberturaSup_Read;
            set
            {
                if (_iTempoAberturaSup_Read != value)
                {
                    _iTempoAberturaSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        #region Tempo Total do Ciclo Superiores
        private int _iHorDecorTotalSup_Read;
        public int iHorDecorTotalSup_Read
        {
            get => _iHorDecorTotalSup_Read;
            set
            {
                if (_iHorDecorTotalSup_Read != value)
                {
                    _iHorDecorTotalSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinDecorTotalSup_Read;
        public int iMinDecorTotalSup_Read
        {
            get => _iMinDecorTotalSup_Read;
            set
            {
                if (_iMinDecorTotalSup_Read != value)
                {
                    _iMinDecorTotalSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iSegDecorTotalSup_Read;
        public int iSegDecorTotalSup_Read
        {
            get => _iSegDecorTotalSup_Read;
            set
            {
                if (_iSegDecorTotalSup_Read != value)
                {
                    _iSegDecorTotalSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iHorProgTotalSup_Read;
        public int iHorProgTotalSup_Read
        {
            get => _iHorProgTotalSup_Read;
            set
            {
                if (_iHorProgTotalSup_Read != value)
                {
                    _iHorProgTotalSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinProgTotalSup_Read;
        public int iMinProgTotalSup_Read
        {
            get => _iMinProgTotalSup_Read;
            set
            {
                if (_iMinProgTotalSup_Read != value)
                {
                    _iMinProgTotalSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion




    }
}
