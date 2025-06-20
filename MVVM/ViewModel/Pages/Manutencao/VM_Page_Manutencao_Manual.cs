using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Drivers.Opcua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{
    public partial class VM_Page_Manutencao_Manual : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public VM_Page_Manutencao_Manual()
        {
            
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
            xSwitch_Read_Dumper = GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(1) ?? false;
            sLabel_Status_Dumper = (GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(1) ?? false) ? "Aberto" : "Fechado";
            xSwitch_Read_PortaSup = GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(7) ?? false;
            sLabel_Status_PortaSup = (GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.GetRead(7) ?? false) ? "Aberta" : "Fechada";
            xSwitch_Read_BombaVacuo = GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.GetRead(5) ?? false;
            sLabel_Status_BombaVacuo = (GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.GetRead(5) ?? false) ? "Com Vácuo" : "Sem Vácuo";
            xSwitch_Read_Ventilador = GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.GetRead(3) ?? false;
            sLabel_Status_Ventilador = (GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.GetRead(3) ?? false) ? "Ligado" : "Desligado";
            xSwitch_Read_Resistencia01 = GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(1) ?? false;
            sLabel_Status_Resistencia01 = (GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(1) ?? false) ? "Ligada" : "Desligada";
            xSwitch_Read_Resistencia02 = GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(2) ?? false;
            sLabel_Status_Resistencia02 = (GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(2) ?? false) ? "Ligada" : "Desligada";
            xSwitch_Read_Resistencia03 = GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(3) ?? false;
            sLabel_Status_Resistencia03 = (GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(3) ?? false) ? "Ligada" : "Desligada";
            xSwitch_Read_Resistencia04 = GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(4) ?? false;
            sLabel_Status_Resistencia04 = (GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.GetRead(4) ?? false) ? "Ligada" : "Desligada";

            fLabel_CorrenteR = GVL.Opcua.GVL_Energia.fCorrenteFaseA.Read ?? 0;
            fLabel_CorrenteS = GVL.Opcua.GVL_Energia.fCorrenteFaseB.Read ?? 0;
            fLabel_CorrenteT = GVL.Opcua.GVL_Energia.fCorrenteFaseC.Read ?? 0;
            fLabel_CorrenteN = GVL.Opcua.GVL_Energia.fCorrenteNeutro.Read ?? 0;

            rFrequencia_Ventilador01 = GVL.Opcua.GVL_ClpIhm.rFrequenciaAtualVentSup.Read ?? 0;
            rVelocidade_Ventilador01 = (GVL.Opcua.GVL_ClpIhm.rFrequenciaAtualVentSup.Read ?? 0) / 60 * 3600;
            iTemperaturaTermoparSup01 = (GVL.Opcua.GVL_ClpIhm.iTermoparSup01.Read ?? 0) /10;
        }




        public ICommand Cmd_Toggle_Dumper => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaDampSup.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaDampSup.Write = novoValor;
        });
        public ICommand Cmd_Toggle_PortaSup => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Write = novoValor;
        });
        public ICommand Cmd_Toggle_BombaVacuo => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaBomVac01.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaBomVac01.Write = novoValor;
        });
        public ICommand Cmd_Toggle_Ventilador => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Write = novoValor;
        });
        public ICommand Cmd_Toggle_Resistencia01 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS01.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS01.Write = novoValor;
        });
        public ICommand Cmd_Toggle_Resistencia02 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS02.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS02.Write = novoValor;
        });
        public ICommand Cmd_Toggle_Resistencia03 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS03.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS03.Write = novoValor;
        });
        public ICommand Cmd_Toggle_Resistencia04 => new Command(() =>
        {
            bool novoValor = !(GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS04.Read ?? false);
            GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS04.Write = novoValor;
        });






    }




}
