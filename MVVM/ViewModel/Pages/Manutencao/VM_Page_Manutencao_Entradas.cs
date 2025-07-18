﻿using MAUI_Opcua.Services.Communication.Variable;
using Microsoft.Maui.Dispatching;
using Microsoft.Maui.Dispatching;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Timers;

namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao
{

    public partial class VM_Page_Manutencao_Entradas
    {

        private readonly System.Timers.Timer _timer;

        public VM_Page_Manutencao_Entradas()
        {
            IniciarlizarDescricao();
            _timer = new System.Timers.Timer(200); // 200 ms
            _timer.Elapsed += Timer_Elapsed;
            _timer.AutoReset = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(AtualizaEstadoDI);
        }

        public void StartAtualizacaoDI()
        {
            _timer?.Start();
        }

        public void StopAtualizacaoDI()
        {
            _timer?.Stop();
        }

        public void AtualizaEstadoDI()
        {
            C1_cDI0_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(0) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI1_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(1) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI2_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(2) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI3_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(3) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI4_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(4) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI5_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(5) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI6_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(6) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI7_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(7) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI8_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(8) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI9_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(9) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI10_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(10) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI11_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(11) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI12_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(12) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI13_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(13) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI14_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(14) ?? false) ? Colors.Green : Colors.Red;
            C1_cDI15_Color = (GVL.Opcua.EntradasSaidas.ImgTesteEntLog.GetRead(15) ?? false) ? Colors.Green : Colors.Red;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void IniciarlizarDescricao()
        {
            C1_sDI0_Descricao = "Forno - Porta - Sensor Indutivo: Porta Aberta";
            C1_sDI1_Descricao = "Painel - Chave: Troca de Operação Manual/Automático";
            C1_sDI2_Descricao = "Painel - Botão: Reset Emergência";
            C1_sDI3_Descricao = "Painel - Botão: Emergência";
            C1_sDI4_Descricao = "Painel - Relé de Segurança: Segurança Ativada";
            C1_sDI5_Descricao = "Bomba de Vácuo - Contatora: Acionamento Ok";
            C1_sDI6_Descricao = "Bomba de Vácuo - Vacuostato: Vácuo Atingido";
            C1_sDI7_Descricao = "Painel - Inversor do Ventilador: Acionamento Ativo";
            C1_sDI8_Descricao = "Forno - Termostato: Temperatura Ok (Retorno NF)";
            C1_sDI9_Descricao = "Forno - Porta - Sensor Indutivo: Porta Fechada";
            C1_sDI10_Descricao = "Reserva";
            C1_sDI11_Descricao = "Reserva";
            C1_sDI12_Descricao = "Reserva";
            C1_sDI13_Descricao = "Reserva";
            C1_sDI14_Descricao = "Reserva";
            C1_sDI15_Descricao = "Reserva";
        }


    }
}
