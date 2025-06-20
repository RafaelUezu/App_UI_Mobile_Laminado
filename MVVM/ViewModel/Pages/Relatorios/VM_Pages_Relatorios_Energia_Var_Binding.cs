using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Relatorios
{
    public partial class VM_Pages_Relatorios_Energia
    {
        private float _fTensaoAvgLL;
        public float fTensaoAvgLL
        {
            get => _fTensaoAvgLL;
            set
            {
                if (_fTensaoAvgLL != value)
                {
                    _fTensaoAvgLL = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteAvg;
        public float fCorrenteAvg
        {
            get => _fCorrenteAvg;
            set
            {
                if (_fCorrenteAvg != value)
                {
                    _fCorrenteAvg = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fPotenciaAtivaTotal;
        public float fPotenciaAtivaTotal
        {
            get => _fPotenciaAtivaTotal;
            set
            {
                if (_fPotenciaAtivaTotal != value)
                {
                    _fPotenciaAtivaTotal = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fEnergiaAtivaAcumulada;
        public float fEnergiaAtivaAcumulada
        {
            get => _fEnergiaAtivaAcumulada;
            set
            {
                if (_fEnergiaAtivaAcumulada != value)
                {
                    _fEnergiaAtivaAcumulada = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fAtualDemanda;
        public float fAtualDemanda
        {
            get => _fAtualDemanda;
            set
            {
                if (_fAtualDemanda != value)
                {
                    _fAtualDemanda = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fPicoDemanda;
        public float fPicoDemanda
        {
            get => _fPicoDemanda;
            set
            {
                if (_fPicoDemanda != value)
                {
                    _fPicoDemanda = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fFatorPotenciaTotal;
        public float fFatorPotenciaTotal
        {
            get => _fFatorPotenciaTotal;
            set
            {
                if (_fFatorPotenciaTotal != value)
                {
                    _fFatorPotenciaTotal = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fFrequencia;
        public float fFrequencia
        {
            get => _fFrequencia;
            set
            {
                if (_fFrequencia != value)
                {
                    _fFrequencia = value;
                    OnPropertyChanged();
                }
            }
        }
        // Tensão
        private float _fTensaoAB;
        public float fTensaoAB
        {
            get => _fTensaoAB;
            set
            {
                if (_fTensaoAB != value)
                {
                    _fTensaoAB = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoCA;
        public float fTensaoCA
        {
            get => _fTensaoCA;
            set
            {
                if (_fTensaoCA != value)
                {
                    _fTensaoCA = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoBC;
        public float fTensaoBC
        {
            get => _fTensaoBC;
            set
            {
                if (_fTensaoBC != value)
                {
                    _fTensaoBC = value;
                    OnPropertyChanged();
                }
            }
        }

        private float _fTensaoMaximaAB;
        public float fTensaoMaximaAB
        {
            get => _fTensaoMaximaAB;
            set
            {
                if (_fTensaoMaximaAB != value)
                {
                    _fTensaoMaximaAB = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoMaximaCA;
        public float fTensaoMaximaCA
        {
            get => _fTensaoMaximaCA;
            set
            {
                if (_fTensaoMaximaCA != value)
                {
                    _fTensaoMaximaCA = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoMaximaBC;
        public float fTensaoMaximaBC
        {
            get => _fTensaoMaximaBC;
            set
            {
                if (_fTensaoMaximaBC != value)
                {
                    _fTensaoMaximaBC = value;
                    OnPropertyChanged();
                }
            }
        }
        // Tensão Fase Fase
        private float _fTensaoAN;
        public float fTensaoAN
        {
            get => _fTensaoAN;
            set
            {
                if (_fTensaoAN != value)
                {
                    _fTensaoAN = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoBN;
        public float fTensaoBN
        {
            get => _fTensaoBN;
            set
            {
                if (_fTensaoBN != value)
                {
                    _fTensaoBN = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoCN;
        public float fTensaoCN
        {
            get => _fTensaoCN;
            set
            {
                if (_fTensaoCN != value)
                {
                    _fTensaoCN = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoMaximaAN;
        public float fTensaoMaximaAN
        {
            get => _fTensaoMaximaAN;
            set
            {
                if (_fTensaoMaximaAN != value)
                {
                    _fTensaoMaximaAN = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoMaximaBN;
        public float fTensaoMaximaBN
        {
            get => _fTensaoMaximaBN;
            set
            {
                if (_fTensaoMaximaBN != value)
                {
                    _fTensaoMaximaBN = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fTensaoMaximaCN;
        public float fTensaoMaximaCN
        {
            get => _fTensaoMaximaCN;
            set
            {
                if (_fTensaoMaximaCN != value)
                {
                    _fTensaoMaximaCN = value;
                    OnPropertyChanged();
                }
            }
        }
        // Corrente
        private float _fCorrenteFaseA;
        public float fCorrenteFaseA
        {
            get => _fCorrenteFaseA;
            set
            {
                if (_fCorrenteFaseA != value)
                {
                    _fCorrenteFaseA = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteFaseB;
        public float fCorrenteFaseB
        {
            get => _fCorrenteFaseB;
            set
            {
                if (_fCorrenteFaseB != value)
                {
                    _fCorrenteFaseB = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteFaseC;
        public float fCorrenteFaseC
        {
            get => _fCorrenteFaseC;
            set
            {
                if (_fCorrenteFaseC != value)
                {
                    _fCorrenteFaseC = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteNeutro;
        public float fCorrenteNeutro
        {
            get => _fCorrenteNeutro;
            set
            {
                if (_fCorrenteNeutro != value)
                {
                    _fCorrenteNeutro = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteMaximaFaseA;
        public float fCorrenteMaximaFaseA
        {
            get => _fCorrenteMaximaFaseA;
            set
            {
                if (_fCorrenteMaximaFaseA != value)
                {
                    _fCorrenteMaximaFaseA = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteMaximaFaseB;
        public float fCorrenteMaximaFaseB
        {
            get => _fCorrenteMaximaFaseB;
            set
            {
                if (_fCorrenteMaximaFaseB != value)
                {
                    _fCorrenteMaximaFaseB = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteMaximaFaseC;
        public float fCorrenteMaximaFaseC
        {
            get => _fCorrenteMaximaFaseC;
            set
            {
                if (_fCorrenteMaximaFaseC != value)
                {
                    _fCorrenteMaximaFaseC = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _fCorrenteMaximaNeutro;
        public float fCorrenteMaximaNeutro
        {
            get => _fCorrenteMaximaNeutro;
            set
            {
                if (_fCorrenteMaximaNeutro != value)
                {
                    _fCorrenteMaximaNeutro = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
