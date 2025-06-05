using MAUI_Opcua.Services.Communication.Variable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Saidas : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private readonly System.Timers.Timer _timer;

        public VM_Page_Manutencao_Saidas()
        {
            IniciarlizarDescricao();
            _timer = new System.Timers.Timer(100); // 200 ms
            _timer.Elapsed += Timer_Elapsed;
            _timer.AutoReset = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(AtualizaEstadoDQ);
        }

        public void StartAtualizacaoDQ()
        {
            _timer?.Start();
        }

        public void StopAtualizacaoDQ()
        {
            _timer?.Stop();
        }

        public void AtualizaEstadoDQ()
        {
            xC1_DQ0 = (GVL.Opcua.Test.xC1_DQ0.Read ?? false) ? true : false;
            xC1_DQ1 = (GVL.Opcua.Test.xC1_DQ1.Read ?? false) ? true : false;
            xC1_DQ2 = (GVL.Opcua.Test.xC1_DQ2.Read ?? false) ? true : false;
            xC1_DQ3 = (GVL.Opcua.Test.xC1_DQ3.Read ?? false) ? true : false;
            xC1_DQ4 = (GVL.Opcua.Test.xC1_DQ4.Read ?? false) ? true : false;
            xC1_DQ5 = (GVL.Opcua.Test.xC1_DQ5.Read ?? false) ? true : false;
            xC1_DQ6 = (GVL.Opcua.Test.xC1_DQ6.Read ?? false) ? true : false;
            xC1_DQ7 = (GVL.Opcua.Test.xC1_DQ7.Read ?? false) ? true : false;

            xC2_DQ0 = (GVL.Opcua.Test.xC2_DQ0.Read ?? false) ? true : false;
            xC2_DQ1 = (GVL.Opcua.Test.xC2_DQ1.Read ?? false) ? true : false;
            xC2_DQ2 = (GVL.Opcua.Test.xC2_DQ2.Read ?? false) ? true : false;
            xC2_DQ3 = (GVL.Opcua.Test.xC2_DQ3.Read ?? false) ? true : false;
            xC2_DQ4 = (GVL.Opcua.Test.xC2_DQ4.Read ?? false) ? true : false;
            xC2_DQ5 = (GVL.Opcua.Test.xC2_DQ5.Read ?? false) ? true : false;
            xC2_DQ6 = (GVL.Opcua.Test.xC2_DQ6.Read ?? false) ? true : false;
            xC2_DQ7 = (GVL.Opcua.Test.xC2_DQ7.Read ?? false) ? true : false;
        }

        public void IniciarlizarDescricao()
        {
            sC1_DQ0_Descricao = "Sinalização: Reset Emergência";
            sC1_DQ1_Descricao = "Torre Luminosa: Led Vermelho";
            sC1_DQ2_Descricao = "Torre Luminosa: Led Verde";
            sC1_DQ3_Descricao = "Torre Luminosa: Led Amarelo";
            sC1_DQ4_Descricao = "Torre Luminosa: Sinalização Sonora";
            sC1_DQ5_Descricao = "Ativar Ventilador";
            sC1_DQ6_Descricao = "Reserva";
            sC1_DQ7_Descricao = "Reserva";

            sC2_DQ0_Descricao = "Ativar Bomba a Vácuo";
            sC2_DQ1_Descricao = "Ativar Dumper Exaustor";
            sC2_DQ2_Descricao = "Abrir/Fechar Porta do Forno";
            sC2_DQ3_Descricao = "Ativar SSR1: Resistência 1";
            sC2_DQ4_Descricao = "Ativar SSR2: Resistência 2";
            sC2_DQ5_Descricao = "Ativar SSR3: Resistência 3";
            sC2_DQ6_Descricao = "Ativar SSR4: Resistência 4";
            sC2_DQ7_Descricao = "Reserva";
        }
        public bool xC1_DQ0_Read => GVL.Opcua.Test.xC1_DQ0.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ0 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ0.Write = !xC1_DQ0_Read;

        });
        public bool xC1_DQ1_Read => GVL.Opcua.Test.xC1_DQ1.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ1 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ1.Write = !xC1_DQ1_Read;

        });
        public bool xC1_DQ2_Read => GVL.Opcua.Test.xC1_DQ2.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ2 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ2.Write = !xC1_DQ2_Read;

        });
        public bool xC1_DQ3_Read => GVL.Opcua.Test.xC1_DQ3.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ3 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ3.Write = !xC1_DQ3_Read;

        });
        public bool xC1_DQ4_Read => GVL.Opcua.Test.xC1_DQ4.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ4 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ4.Write = !xC1_DQ4_Read;

        });
        public bool xC1_DQ5_Read => GVL.Opcua.Test.xC1_DQ5.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ5 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ5.Write = !xC1_DQ5_Read;

        });
        public bool xC1_DQ6_Read => GVL.Opcua.Test.xC1_DQ6.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ6 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ6.Write = !xC1_DQ6_Read;

        });
        public bool xC1_DQ7_Read => GVL.Opcua.Test.xC1_DQ7.Read ?? false;
        public ICommand Cmd_Toggle_C1_DQ7 => new Command(() =>
        {
            GVL.Opcua.Test.xC1_DQ7.Write = !xC1_DQ7_Read;

        });
        public bool xC2_DQ0_Read => GVL.Opcua.Test.xC2_DQ0.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ0 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ0.Write = !xC2_DQ0_Read;

        });
        public bool xC2_DQ1_Read => GVL.Opcua.Test.xC2_DQ1.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ1 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ1.Write = !xC2_DQ1_Read;

        });
        public bool xC2_DQ2_Read => GVL.Opcua.Test.xC2_DQ2.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ2 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ2.Write = !xC2_DQ2_Read;

        });
        public bool xC2_DQ3_Read => GVL.Opcua.Test.xC2_DQ3.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ3 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ3.Write = !xC2_DQ3_Read;

        });
        public bool xC2_DQ4_Read => GVL.Opcua.Test.xC2_DQ4.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ4 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ4.Write = !xC2_DQ4_Read;

        });
        public bool xC2_DQ5_Read => GVL.Opcua.Test.xC2_DQ5.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ5 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ5.Write = !xC2_DQ5_Read;

        });
        public bool xC2_DQ6_Read => GVL.Opcua.Test.xC2_DQ6.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ6 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ6.Write = !xC2_DQ6_Read;

        });
        public bool xC2_DQ7_Read => GVL.Opcua.Test.xC2_DQ7.Read ?? false;
        public ICommand Cmd_Toggle_C2_DQ7 => new Command(() =>
        {
            GVL.Opcua.Test.xC2_DQ7.Write = !xC2_DQ7_Read;

        });











    }
}
