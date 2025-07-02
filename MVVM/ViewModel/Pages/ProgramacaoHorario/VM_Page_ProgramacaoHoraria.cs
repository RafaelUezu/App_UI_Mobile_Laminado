using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Drivers.Opcua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.ProgramacaoHorario
{
    public partial class VM_Page_ProgramacaoHoraria : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public VM_Page_ProgramacaoHoraria()
        {
            OpcUaEvents.LeituraFinalizadaAsync += () =>
            {
                OnLeituraFinalizada();
                return Task.CompletedTask;

            };
        }
        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaValores);
            MainThread.BeginInvokeOnMainThread(EscreveValores);
        }
        public void AtualizaValores()
        {
            uLdomingo_Read = GVL.Opcua.GVL_Permanentes.uLdomingo.Read ?? 0;
            uLsegunda_Read = GVL.Opcua.GVL_Permanentes.uLsegunda.Read ?? 0;
            uLterca_Read = GVL.Opcua.GVL_Permanentes.uLterca.Read ?? 0;
            uLquarta_Read = GVL.Opcua.GVL_Permanentes.uLquarta.Read ?? 0;
            uLquinta_Read = GVL.Opcua.GVL_Permanentes.uLquinta.Read ?? 0;
            uLsexta_Read = GVL.Opcua.GVL_Permanentes.uLsexta.Read ?? 0;
            uLsabado_Read = GVL.Opcua.GVL_Permanentes.uLsabado.Read ?? 0;

            uHorProgramado_Read = GVL.Opcua.GVL_Permanentes.uHorProgramado.Read ?? 0;
            uMinProgramado_Read = GVL.Opcua.GVL_Permanentes.uMinProgramado.Read ?? 0;

            xLdomingo_Read = (uLdomingo_Read == 7) ? true : false;
            xLsegunda_Read = (uLsegunda_Read == 1) ? true : false;
            xLterca_Read = (uLterca_Read == 2) ? true : false;
            xLquarta_Read = (uLquarta_Read == 3) ? true : false;
            xLquinta_Read = (uLquinta_Read == 4) ? true : false;
            xLsexta_Read = (uLsexta_Read == 5) ? true : false;
            xLsabado_Read = (uLsabado_Read == 6) ? true : false;

        }

        public void EscreveValores()
        {
            if (uHorProgramado_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.uHorProgramado.Write = (uint)uHorProgramado_Write.Value;
                uHorProgramado_Write = null;
            }
            if (uMinProgramado_Write.HasValue)
            {
                GVL.Opcua.GVL_Permanentes.uMinProgramado.Write = (uint)uMinProgramado_Write.Value;
                uMinProgramado_Write = null;
            }
        }

        public ICommand Button_Domingo_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLdomingo.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLdomingo.Write = (uint)7;
            }
            if (GVL.Opcua.GVL_Permanentes.uLdomingo.Read == (uint)7)
            {
                GVL.Opcua.GVL_Permanentes.uLdomingo.Write = (uint)0;
            }
        });
        public ICommand Button_Segunda_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLsegunda.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLsegunda.Write = (uint)1;
            }
            if (GVL.Opcua.GVL_Permanentes.uLsegunda.Read == (uint)1)
            {
                GVL.Opcua.GVL_Permanentes.uLsegunda.Write = (uint)0;
            }
        });
        public ICommand Button_Terca_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLterca.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLterca.Write = (uint)2;
            }
            if (GVL.Opcua.GVL_Permanentes.uLterca.Read == (uint)2)
            {
                GVL.Opcua.GVL_Permanentes.uLterca.Write = (uint)0;
            }
        });
        public ICommand Button_Quarta_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLquarta.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLquarta.Write = (uint)3;
            }
            if (GVL.Opcua.GVL_Permanentes.uLquarta.Read == (uint)3)
            {
                GVL.Opcua.GVL_Permanentes.uLquarta.Write = (uint)0;
            }
        });
        public ICommand Button_Quinta_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLquinta.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLquinta.Write = (uint)4;
            }
            if (GVL.Opcua.GVL_Permanentes.uLquinta.Read == (uint)4)
            {
                GVL.Opcua.GVL_Permanentes.uLquinta.Write = (uint)0;
            }
        });
        public ICommand Button_Sexta_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLsexta.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLsexta.Write = (uint)5;
            }
            if (GVL.Opcua.GVL_Permanentes.uLsexta.Read == (uint)5)
            {
                GVL.Opcua.GVL_Permanentes.uLsexta.Write = (uint)0;
            }
        });
        public ICommand Button_Sabado_Command => new Command(() =>
        {
            if (GVL.Opcua.GVL_Permanentes.uLsabado.Read == (uint)0)
            {
                GVL.Opcua.GVL_Permanentes.uLsabado.Write = (uint)6;
            }
            if (GVL.Opcua.GVL_Permanentes.uLsabado.Read == (uint)6)
            {
                GVL.Opcua.GVL_Permanentes.uLsabado.Write = (uint)0;
            }
        });


    }
}
