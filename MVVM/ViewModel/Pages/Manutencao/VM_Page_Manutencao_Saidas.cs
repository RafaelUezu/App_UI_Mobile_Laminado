using App_UI_Mobile_Laminado.Services.Communication.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App_UI_Mobile_Laminado.Services.Drivers.Opcua;
using Microsoft.Maui.Dispatching;
using Microsoft.Maui.ApplicationModel;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Saidas : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public VM_Page_Manutencao_Saidas()
        {
            
            IniciarlizarDescricao();

            OpcUaEvents.LeituraFinalizadaAsync += () =>
            {
                OnLeituraFinalizada();
                return Task.CompletedTask;
            };

        }

        private void OnLeituraFinalizada()
        {
            MainThread.BeginInvokeOnMainThread(AtualizaEstadoDQ);
        }



        public void AtualizaEstadoDQ()
        {
            // Cartão 1
            xC1_DQ0 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(0) ?? false;
            xC1_DQ1 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(1) ?? false;
            xC1_DQ2 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(2) ?? false;
            xC1_DQ3 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(3) ?? false;

            xC1_DQ4 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(4) ?? false;
            xC1_DQ5 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(5) ?? false;
            xC1_DQ6 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(6) ?? false;
            xC1_DQ7 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(7) ?? false;
            // Cartão 2
            xC2_DQ0 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(8) ?? false;
            xC2_DQ1 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(9) ?? false;
            xC2_DQ2 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(10) ?? false;
            xC2_DQ3 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(11) ?? false;

            xC2_DQ4 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(12) ?? false;
            xC2_DQ5 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(13) ?? false;
            xC2_DQ6 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(14) ?? false;
            xC2_DQ7 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(15) ?? false;
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
        public ICommand Cmd_Toggle_C1_DQ0 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(0) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(0, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ1 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(1) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(1, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ2 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(2) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(2, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ3 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(3) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(3, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ4 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(4) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(4, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ5 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(5) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(5, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ6 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(6) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(6, novoValor);
        });
        public ICommand Cmd_Toggle_C1_DQ7 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(7) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(7, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ0 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(8) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(8, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ1 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(9) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(9, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ2 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(10) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(10, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ3 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(11) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(11, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ4 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(12) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(12, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ5 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(13) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(13, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ6 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(14) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(14, novoValor);
        });
        public ICommand Cmd_Toggle_C2_DQ7 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetRead(15) ?? false);
            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(15, novoValor);
        });
    }
}
