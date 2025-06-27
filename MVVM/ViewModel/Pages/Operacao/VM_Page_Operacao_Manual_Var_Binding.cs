using MAUI_Opcua.Services.Communication.Variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MAUI_Opcua.Services.Communication.Variable.GVL.Opcua.GVL_Permanentes;
namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_Manual
    {
        #region Vácuo01
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

        private string? _sMotorBombaVacuo01_Status_Legend;
        public string? sMotorBombaVacuo01_Status_Legend
        {
            get => _sMotorBombaVacuo01_Status_Legend;
            set
            {
                if (_sMotorBombaVacuo01_Status_Legend != value)
                {
                    _sMotorBombaVacuo01_Status_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color? _cMotorBombaVacuo01_Status_Color;
        public Color? cMotorBombaVacuo01_Status_Color
        {
            get => _cMotorBombaVacuo01_Status_Color;
            set
            {
                if (_cMotorBombaVacuo01_Status_Color != value)
                {
                    _cMotorBombaVacuo01_Status_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _fMotorBombaVacuo01_Freq_Read;
        public float? fMotorBombaVacuo01_Freq_Read
        {
            get => _fMotorBombaVacuo01_Freq_Read;
            set
            {
                if (_fMotorBombaVacuo01_Freq_Read != value)
                {
                    _fMotorBombaVacuo01_Freq_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private string? _sMotorBombaVacuo01_Cmd_Legend;
        public string? sMotorBombaVacuo01_Cmd_Legend
        {
            get => _sMotorBombaVacuo01_Cmd_Legend;
            set
            {
                if (_sMotorBombaVacuo01_Cmd_Legend != value)
                {
                    _sMotorBombaVacuo01_Cmd_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _BtLdVacuoMesa01_Read;
        public bool BtLdVacuoMesa01_Read
        {
            get => _BtLdVacuoMesa01_Read;
            set
            {
                if (_BtLdVacuoMesa01_Read != value)
                {
                    _BtLdVacuoMesa01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sBtLdVacuoMesa01_Legend;
        public string sBtLdVacuoMesa01_Legend
        {
            get => _sBtLdVacuoMesa01_Legend;
            set
            {
                if (_sBtLdVacuoMesa01_Legend != value)
                {
                    _sBtLdVacuoMesa01_Legend = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Button_BtLdVacuoMesa01_Command => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Write ?? false);
            GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Write = novoValor;
        });
        #endregion

        #region Porta Superior
        private bool _xBtAbreFechaPortaSup_Read;
        public bool xBtAbreFechaPortaSup_Read
        {
            get => _xBtAbreFechaPortaSup_Read;
            set
            {
                if (_xBtAbreFechaPortaSup_Read != value)
                {
                    _xBtAbreFechaPortaSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sBtAbreFechaPortaSup_Status_Legend;
        public string sBtAbreFechaPortaSup_Status_Legend
        {
            get => _sBtAbreFechaPortaSup_Status_Legend;
            set
            {
                if (_sBtAbreFechaPortaSup_Status_Legend != value)
                {
                    _sBtAbreFechaPortaSup_Status_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cBtAbreFechaPortaSup_Status_Color;
        public Color cBtAbreFechaPortaSup_Status_Color
        {
            get => _cBtAbreFechaPortaSup_Status_Color;
            set
            {
                if (_cBtAbreFechaPortaSup_Status_Color != value)
                {
                    _cBtAbreFechaPortaSup_Status_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _ImgGeral7_Read;
        public bool ImgGeral7_Read
        {
            get => _ImgGeral7_Read;
            set
            {
                if (_ImgGeral7_Read != value)
                {
                    _ImgGeral7_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _wStatusPortaEsq_Read;
        public int wStatusPortaEsq_Read
        {
            get => _wStatusPortaEsq_Read;
            set
            {
                if (_wStatusPortaEsq_Read != value)
                {
                    sStatusPortaEsq_Legend = ObterLegendaStatus_Porta(value);
                    cStatusPortaEsq_Color = ObterCorStatus_Porta(value);
                    _wStatusPortaEsq_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusPortaEsq_Legend;
        public string sStatusPortaEsq_Legend
        {
            get => _sStatusPortaEsq_Legend;
            set
            {
                if (_sStatusPortaEsq_Legend != value)
                {
                    _sStatusPortaEsq_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sBtAbreFechaPortaSup_Legend;
        public string sBtAbreFechaPortaSup_Legend
        {
            get => _sBtAbreFechaPortaSup_Legend;
            set
            {
                if (_sBtAbreFechaPortaSup_Legend != value)
                {
                    _sBtAbreFechaPortaSup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cStatusPortaEsq_Color;
        public Color cStatusPortaEsq_Color
        {
            get => _cStatusPortaEsq_Color;
            set
            {
                if (_cStatusPortaEsq_Color != value)
                {
                    _cStatusPortaEsq_Color = value;
                    OnPropertyChanged();
                }
            }
        }

        private string ObterLegendaStatus_Porta(int status)
        {
            return status switch
            {
                0 => "Porta Fora de Posição",
                1 => "Porta Fechada",
                2 => "Porta Aberta",

                _ => "Null"
            };
        }
        private Color ObterCorStatus_Porta(int status)
        {
            return status switch
            {
                0 => Colors.Red,
                1 => Colors.Green,
                2 => Colors.Yellow,

                _ => Colors.Gray
            };
        }


        public ICommand Button_BtAbreFechaPortaSup_Command => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Write ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Write = novoValor;
        });

        #endregion

        #region Termopar


        private int _iTermoparSup01_Read;
        public int iTermoparSup01_Read
        {
            get => _iTermoparSup01_Read;
            set
            {
                if (_iTermoparSup01_Read != value)
                {
                    _iTermoparSup01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cTermoparSup01_Color;
        public Color cTermoparSup01_Color
        {
            get => _cTermoparSup01_Color;
            set
            {
                if (_cTermoparSup01_Color != value)
                {
                    _cTermoparSup01_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTermoparSup01_Read;
        public float fTermoparSup01_Read
        {
            get => _fTermoparSup01_Read;
            set
            {
                if (_fTermoparSup01_Read != value)
                {
                    _fTermoparSup01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _rTemperaturaMinimaSup_Read;
        public float rTemperaturaMinimaSup_Read
        {
            get => _rTemperaturaMinimaSup_Read;
            set
            {
                if (_rTemperaturaMinimaSup_Read != value)
                {
                    _rTemperaturaMinimaSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }


        #endregion

        #region Ventilador

        private float _rFrequenciaAtualVentSup_Read;
        public float rFrequenciaAtualVentSup_Read
        {
            get => _rFrequenciaAtualVentSup_Read;
            set
            {
                if (_rFrequenciaAtualVentSup_Read != value)
                {
                    _rFrequenciaAtualVentSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _ImgMotor3_Read;
        public bool ImgMotor3_Read
        {
            get => _ImgMotor3_Read;
            set
            {
                if (_ImgMotor3_Read != value)
                {
                    _ImgMotor3_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color _cVentSup_Status_Color;
        public Color cVentSup_Status_Color
        {
            get => _cVentSup_Status_Color;
            set
            {
                if (_cVentSup_Status_Color != value)
                {
                    _cVentSup_Status_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sVentSup_Status_Legend;
        public string sVentSup_Status_Legend
        {
            get => _sVentSup_Status_Legend;
            set
            {
                if (_sVentSup_Status_Legend != value)
                {
                    _sVentSup_Status_Legend = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Button_BtLigaDesligaVentSup_Command => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Write ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Write = novoValor;
        });

        #endregion

        #region Resistência
        private int? _uStatusAquecimentoSup_Read;
        public int? uStatusAquecimentoSup_Read
        {
            get => _uStatusAquecimentoSup_Read;
            set
            {
                if (_uStatusAquecimentoSup_Read != value)
                {
                    _uStatusAquecimentoSup_Read = value;
                    cStatusAquecimentoSup_Color = ObterCorStatus_FornoGeral(value ?? 0);
                    sStatusAquecimentoSup_Legend = ObterLegendaStatus_FornoGeral(value ?? 0);
                    cStatusAquecimentoSup_Resist_Color = ObterCorStatus_Rsistencia(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }
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

        private string ObterLegendaStatus_FornoGeral(int status)
        {
            return status switch
            {
                0 => "Desligado",
                1 => "Ligado",
                2 => "Finalizado",

                _ => "Null"
            };
        }
        private Color ObterCorStatus_FornoGeral(int status)
        {
            return status switch
            {
                0 => Colors.Red,
                1 => Colors.Green,
                2 => Colors.Gray,

                _ => Colors.Yellow
            };
        }
        private Color _cStatusAquecimentoSup_Resist_Color;
        public Color cStatusAquecimentoSup_Resist_Color
        {
            get => _cStatusAquecimentoSup_Resist_Color;
            set
            {
                if (_cStatusAquecimentoSup_Resist_Color != value)
                {
                    _cStatusAquecimentoSup_Resist_Color = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color ObterCorStatus_Rsistencia(int status)
        {
            return status switch
            {
                0 => Colors.Gray,
                1 => Colors.Yellow,
                2 => Colors.Gray,

                _ => Colors.Yellow
            };
        }

        private int? _uStatusAquecimentoCicloSup_Read;
        public int? uStatusAquecimentoCicloSup_Read
        {
            get => _uStatusAquecimentoCicloSup_Read;
            set
            {
                if (_uStatusAquecimentoCicloSup_Read != value)
                {
                    _uStatusAquecimentoCicloSup_Read = value;
                    sStatusAquecimentoCicloSup_Legend = ObterLegendaStatus_FornoCiclo(value ?? 0);
                    OnPropertyChanged();
                }
            }
        }

        private string _sStatusAquecimentoCicloSup_Legend;
        public string sStatusAquecimentoCicloSup_Legend
        {
            get => _sStatusAquecimentoCicloSup_Legend;
            set
            {
                if (_sStatusAquecimentoCicloSup_Legend != value)
                {
                    _sStatusAquecimentoCicloSup_Legend = value;
                    OnPropertyChanged();
                }
            }
        }

        private string ObterLegendaStatus_FornoCiclo(int status)
        {
            return status switch
            {
                0 => "",
                1 => "Rampa 01",
                2 => "Rampa 01",
                3 => "Patamar 01",
                4 => "Patamar 01",
                5 => "Rampa 02",
                6 => "Rampa 02",
                7 => "Patamar 02",
                8 => "Patamar 02",
                9 => "Rampa 03",
                10 => "Rampa 03",
                11 => "Patamar 03",
                12 => "Patamar 03",
                13 => "Rampa 04",
                14 => "Rampa 04",
                15 => "Patamar 04",
                16 => "Patamar 04",
                17 => "Rampa 05",
                18 => "Rampa 05",
                19 => "Patamar 05",
                20 => "Patamar 05",
                21 => "Rampa 06",
                22 => "Rampa 06",
                23 => "Patamar 06",
                24 => "Patamar 06",
                25 => "Rampa 07",
                26 => "Rampa 07",
                27 => "Patamar 07",
                28 => "Patamar 07",
                29 => "Rampa 08",
                30 => "Rampa 08",
                31 => "Patamar 08",
                32 => "Patamar 08",


                _ => "Null"
            };
        }
  

        #endregion


    }
}
