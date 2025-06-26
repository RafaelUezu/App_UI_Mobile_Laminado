using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MAUI_Opcua.Services.Communication.Variable;
namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao
{
    public partial class VM_Page_Operacao_Manual
    {
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
        private string? _cMotorBombaVacuo01_Status_Color;
        public string? cMotorBombaVacuo01_Status_Color
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
        
        public ICommand Button_BtLdVacuoMesa01_Command => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Write ?? false);
            GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Write = novoValor;
        });

    }
}
