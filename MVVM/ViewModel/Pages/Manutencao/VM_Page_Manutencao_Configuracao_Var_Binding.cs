using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Configuracao
    {
        #region Properties

        private string _sUrlOpcUa_ReadWrite;
        public string sUrlOpcUa_ReadWrite
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

        #endregion


    }
}
