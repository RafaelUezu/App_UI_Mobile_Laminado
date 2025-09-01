using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Referencias
    {
        #region Leitura
        private Int16? _iTempoExaustorMinSup_Read;
        public Int16? iTempoExaustorMinSup_Read
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
        private float? _rTemperaturaMinimaSup_Read;
        public float? rTemperaturaMinimaSup_Read
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
        private Int16? _iTempoAberturaSup_Read;
        public Int16? iTempoAberturaSup_Read
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
        private Int16? _iFreqManCxSuperior_Read;
        public Int16? iFreqManCxSuperior_Read
        {
            get => _iFreqManCxSuperior_Read;
            set
            {
                if (_iFreqManCxSuperior_Read != value)
                {
                    _iFreqManCxSuperior_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private Int16? _iSpContHorProgB01_Read;
        public Int16? iSpContHorProgB01_Read
        {
            get => _iSpContHorProgB01_Read;
            set
            {
                if (_iSpContHorProgB01_Read != value)
                {
                    _iSpContHorProgB01_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        private Int16? _iTemperaturaSegurancaSup_Read;
        public Int16? iTemperaturaSegurancaSup_Read
        {
            get => _iTemperaturaSegurancaSup_Read;
            set
            {
                if (_iTemperaturaSegurancaSup_Read != value)
                {
                    _iTemperaturaSegurancaSup_Read = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region Escrita
        private Int16? _iTempoExaustorMinSup_Write;
        public Int16? iTempoExaustorMinSup_Write
        {
            get => _iTempoExaustorMinSup_Write;
            set
            {
                if (_iTempoExaustorMinSup_Write != value)
                {
                    _iTempoExaustorMinSup_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private float? _rTemperaturaMinimaSup_Write;
        public float? rTemperaturaMinimaSup_Write
        {
            get => _rTemperaturaMinimaSup_Write;
            set
            {
                if (_rTemperaturaMinimaSup_Write != value)
                {
                    _rTemperaturaMinimaSup_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private Int16? _iTempoAberturaSup_Write;
        public Int16? iTempoAberturaSup_Write
        {
            get => _iTempoAberturaSup_Write;
            set
            {
                if (_iTempoAberturaSup_Write != value)
                {
                    _iTempoAberturaSup_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private Int16? _iFreqManCxSuperior_Write;
        public Int16? iFreqManCxSuperior_Write
        {
            get => _iFreqManCxSuperior_Write;
            set
            {
                if (_iFreqManCxSuperior_Write != value)
                {
                    _iFreqManCxSuperior_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private Int16? _iSpContHorProgB01_Write;
        public Int16? iSpContHorProgB01_Write
        {
            get => _iSpContHorProgB01_Write;
            set
            {
                if (_iSpContHorProgB01_Write != value)
                {
                    _iSpContHorProgB01_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        private Int16? _iTemperaturaSegurancaSup_Write;
        public Int16? iTemperaturaSegurancaSup_Write
        {
            get => _iTemperaturaSegurancaSup_Write;
            set
            {
                if (_iTemperaturaSegurancaSup_Write != value)
                {
                    _iTemperaturaSegurancaSup_Write = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

    }
}
