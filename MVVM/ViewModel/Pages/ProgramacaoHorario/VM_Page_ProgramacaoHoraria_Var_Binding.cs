using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.ProgramacaoHorario
{
    public partial class VM_Page_ProgramacaoHoraria
    {
        #region Variaveis de Leitura
        private uint _uLdomingo_Read;
        public uint uLdomingo_Read
        {
            get => _uLdomingo_Read;
            set
            {
                if (_uLdomingo_Read != value)
                {
                    _uLdomingo_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uLsegunda_Read;
        public uint uLsegunda_Read
        {
            get => _uLsegunda_Read;
            set
            {
                if (_uLsegunda_Read != value)
                {
                    _uLsegunda_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uLterca_Read;
        public uint uLterca_Read
        {
            get => _uLterca_Read;
            set
            {
                if (_uLterca_Read != value)
                {
                    _uLterca_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uLquarta_Read;
        public uint uLquarta_Read
        {
            get => _uLquarta_Read;
            set
            {
                if (_uLquarta_Read != value)
                {
                    _uLquarta_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uLquinta_Read;
        public uint uLquinta_Read
        {
            get => _uLquinta_Read;
            set
            {
                if (_uLquinta_Read != value)
                {
                    _uLquinta_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uLsexta_Read;
        public uint uLsexta_Read
        {
            get => _uLsexta_Read;
            set
            {
                if (_uLsexta_Read != value)
                {
                    _uLsexta_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uLsabado_Read;
        public uint uLsabado_Read
        {
            get => _uLsabado_Read;
            set
            {
                if (_uLsabado_Read != value)
                {
                    _uLsabado_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uHorProgramado_Read;
        public uint uHorProgramado_Read
        {
            get => _uHorProgramado_Read;
            set
            {
                if (_uHorProgramado_Read != value)
                {
                    _uHorProgramado_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint _uMinProgramado_Read;
        public uint uMinProgramado_Read
        {
            get => _uMinProgramado_Read;
            set
            {
                if (_uMinProgramado_Read != value)
                {
                    _uMinProgramado_Read = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion
        #region Variaveis de Leitura
        private uint? _uLdomingo_Write;
        public uint? uLdomingo_Write
        {
            get => _uLdomingo_Write;
            set
            {
                if (_uLdomingo_Write != value)
                {
                    _uLdomingo_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uLsegunda_Write;
        public uint? uLsegunda_Write
        {
            get => _uLsegunda_Write;
            set
            {
                if (_uLsegunda_Write != value)
                {
                    _uLsegunda_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uLterca_Write;
        public uint? uLterca_Write
        {
            get => _uLterca_Write;
            set
            {
                if (_uLterca_Write != value)
                {
                    _uLterca_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uLquarta_Write;
        public uint? uLquarta_Write
        {
            get => _uLquarta_Write;
            set
            {
                if (_uLquarta_Write != value)
                {
                    _uLquarta_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uLquinta_Write;
        public uint? uLquinta_Write
        {
            get => _uLquinta_Write;
            set
            {
                if (_uLquinta_Write != value)
                {
                    _uLquinta_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uLsexta_Write;
        public uint? uLsexta_Write
        {
            get => _uLsexta_Write;
            set
            {
                if (_uLsexta_Write != value)
                {
                    _uLsexta_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uLsabado_Write;
        public uint? uLsabado_Write
        {
            get => _uLsabado_Write;
            set
            {
                if (_uLsabado_Write != value)
                {
                    _uLsabado_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uHorProgramado_Write;
        public uint? uHorProgramado_Write
        {
            get => _uHorProgramado_Write;
            set
            {
                if (_uHorProgramado_Write != value)
                {
                    _uHorProgramado_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private uint? _uMinProgramado_Write;
        public uint? uMinProgramado_Write
        {
            get => _uMinProgramado_Write;
            set
            {
                if (_uMinProgramado_Write != value)
                {
                    _uMinProgramado_Write = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion
    }
}
