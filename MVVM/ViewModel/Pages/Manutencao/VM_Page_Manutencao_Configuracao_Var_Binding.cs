using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_UI_Mobile_Laminado.Services.Communication.Variables;
namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Configuracao
    {
        #region Properties

        private string? _sUrlOpcUa_ReadWrite;
        public string? sUrlOpcUa_ReadWrite
        {
            get => _sUrlOpcUa_ReadWrite;
            set
            {
                if (_sUrlOpcUa_ReadWrite != value)
                {
                    _sUrlOpcUa_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iTimeOutPing_ReadWrite;
        public int iTimeOutPing_ReadWrite
        {
            get => _iTimeOutPing_ReadWrite;
            set
            {
                if (_iTimeOutPing_ReadWrite != value)
                {
                    _iTimeOutPing_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iTimeRequest_ReadWrite;
        public int iTimeRequest_ReadWrite
        {
            get => _iTimeRequest_ReadWrite;
            set
            {
                if (_iTimeRequest_ReadWrite != value)
                {
                    _iTimeRequest_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMaxAgeOpcUa_ReadWrite;
        public int iMaxAgeOpcUa_ReadWrite
        {
            get => _iMaxAgeOpcUa_ReadWrite;
            set
            {
                if (_iMaxAgeOpcUa_ReadWrite != value)
                {
                    _iMaxAgeOpcUa_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMedAgeOpcUa_ReadWrite;
        public int iMedAgeOpcUa_ReadWrite
        {
            get => _iMedAgeOpcUa_ReadWrite;
            set
            {
                if (_iMedAgeOpcUa_ReadWrite != value)
                {
                    _iMedAgeOpcUa_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinAgeOpcUa_ReadWrite;
        public int iMinAgeOpcUa_ReadWrite
        {
            get => _iMinAgeOpcUa_ReadWrite;
            set
            {
                if (_iMinAgeOpcUa_ReadWrite != value)
                {
                    _iMinAgeOpcUa_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iZeroAgeOpcUa_ReadWrite;
        public int iZeroAgeOpcUa_ReadWrite
        {
            get => _iZeroAgeOpcUa_ReadWrite;
            set
            {
                if (_iZeroAgeOpcUa_ReadWrite != value)
                {
                    _iZeroAgeOpcUa_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iQueryTime_ReadWrite;
        public int iQueryTime_ReadWrite
        {
            get => _iQueryTime_ReadWrite;
            set
            {
                if (_iQueryTime_ReadWrite != value)
                {
                    _iQueryTime_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _sStatusOpcUa_ReadWrite;
        public string sStatusOpcUa_ReadWrite
        {
            get => _sStatusOpcUa_ReadWrite;
            set
            {
                if (_sStatusOpcUa_ReadWrite != value)
                {
                    _sStatusOpcUa_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }


        #endregion

        #region Parametros de limitação de campos
        private int _iMaxTempRecipe_ReadWrite;
        public int iMaxTempRecipe_ReadWrite
        {
            get => _iMaxTempRecipe_ReadWrite;
            set
            {
                if (_iMaxTempRecipe_ReadWrite != value)
                {
                    _iMaxTempRecipe_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinTempRecipe_ReadWrite;
        public int iMinTempRecipe_ReadWrite
        {
            get => _iMinTempRecipe_ReadWrite;
            set
            {
                if (_iMinTempRecipe_ReadWrite != value)
                {
                    _iMinTempRecipe_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMaxTempOperation_ReadWrite;
        public int iMaxTempOperation_ReadWrite
        {
            get => _iMaxTempOperation_ReadWrite;
            set
            {
                if (_iMaxTempOperation_ReadWrite != value)
                {
                    _iMaxTempOperation_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _iMinTempOperation_ReadWrite;
        public int iMinTempOperation_ReadWrite
        {
            get => _iMinTempOperation_ReadWrite;
            set
            {
                if (_iMinTempOperation_ReadWrite != value)
                {
                    _iMinTempOperation_ReadWrite = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
    }
}
