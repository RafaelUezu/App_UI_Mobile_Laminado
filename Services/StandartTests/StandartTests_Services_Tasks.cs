using App_UI_Mobile_Laminado.Services.Alarms;
using MAUI_Opcua.Services.Communication.Variable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App_UI_Mobile_Laminado.Services.StandartTests
{
    public partial class StandartTests_Services
    {
        #region Instância de AlarmEngine e registro de alarmes
        private void RegisterAlarms()
        {
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_WAR_UNID_VAC01_TROCA_OLEO",
                displayName: "Óleo da Bomba de Vácuo",
                description: "Alarme de troca de óleo da bomba de vácuo 01",
                location_Panel: string.Empty,
                location_Machine: "Bomba de Vácuo/Reservatório",
                category: AlarmInput.CategoryLevel.Maintenance,
                subCategory: AlarmInput.SubCategoryLevel.Preventive,
                functionDescription: "Indica que é necessário trocar o óleo da bomba de vácuo.",
                recommended: "Verificar o nível do óleo e proceder com a troca se necessário.",
                severity: AlarmInput.SeverityLevel.Warning,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ClpIhm.xAlarmeHorimetroB01.Read ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_WAR_UNID_VAC02_OIL",
                displayName: "Óleo da Bomba de Vácuo",
                description: "Alarme de troca de óleo da bomba de vácuo 02",
                location_Panel: string.Empty,
                location_Machine: "Bomba de Vácuo/Reservatório",
                category: AlarmInput.CategoryLevel.Maintenance,
                subCategory: AlarmInput.SubCategoryLevel.Preventive,
                functionDescription: "Indica que é necessário trocar o óleo da bomba de vácuo.",
                recommended: "Verificar o nível do óleo e proceder com a troca se necessário.",
                severity: AlarmInput.SeverityLevel.Warning,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ClpIhm.xAlarmeHorimetroB02.Read ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_SAF_PNL_EMER01",
                displayName: "Botão de Emergência",
                description: "Botão de Emergência Pressionado",
                location_Panel: "Painel/Porta",
                location_Machine: string.Empty,
                category: AlarmInput.CategoryLevel.Safety,
                subCategory: AlarmInput.SubCategoryLevel.Emergency,
                functionDescription: "Indica que o botão de emergência foi pressionado",
                recommended: "Confirmar segurança das pessoas e da máquina, em seguida desarmar o botão de emergência e pressionar o botão de reset",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ClpIhm.xEmergencia.Read ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_GATE01",
                displayName: "Porta fora de posição",
                description: "Porta do forno esta fora de posição",
                location_Panel: "Válvula",
                location_Machine: "Forno/Porta/Pistões",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Positioning,
                functionDescription: "Indica que a porta ou não abriu ou não fechou",
                recommended: "Verificar circuito pneumático ou comando da válvula",
                severity: AlarmInput.SeverityLevel.Low,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmGeral.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_GATE02",
                displayName: "Porta Inferior do Forno em Falha",
                description: "Problema no pistão ou válvula",
                location_Panel: "Válvula",
                location_Machine: "Forno/Porta/Pistões",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Positioning,
                functionDescription: "Indica que a porta ou não abriu ou não fechou",
                recommended: "Verificar circuito pneumático ou comando da válvula",
                severity: AlarmInput.SeverityLevel.Low,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmGeral.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_MEL_MT01",
                displayName: "Elevador em falha",
                description: "Motor ou inversor do elevador em falha",
                location_Panel: "Painel/Inversor",
                location_Machine: "Mesa Elevatória/Motor",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Positioning,
                functionDescription: "Indica que o inversor não detectou ação da parte do motor",
                recommended: "Verificar circuito do inversor e motor",
                severity: AlarmInput.SeverityLevel.Low,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmMotor.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_MT01",
                displayName: "Falha na ventilação superior",
                description: "Motor ou inversor do ventilador em falha",
                location_Panel: "Painel/Inversor",
                location_Machine: "Forno/Ventilador/Motor",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Ventilation,
                functionDescription: "Indica que o inversor não detectou ação da parte do motor",
                recommended: "Verificar circuito do inversor e motor",
                severity: AlarmInput.SeverityLevel.Hi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmMotor.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_MT02",
                displayName: "Falha na ventilação inferior",
                description: "Motor ou inversor do ventilador em falha",
                location_Panel: "Painel/Inversor",
                location_Machine: "Forno/Ventilador/Motor",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Ventilation,
                functionDescription: "Indica que o inversor não detectou ação da parte do motor",
                recommended: "Verificar circuito do inversor e motor",
                severity: AlarmInput.SeverityLevel.Hi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmMotor.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_UNID_VAC01",
                displayName: "Falha na Unidade de Vácuo 01",
                description: "Falha ao acionar a unidade de vácuo",
                location_Panel: "Painel/Contatora",
                location_Machine: "Bomba de Vácuo/Motor",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Ventilation,
                functionDescription: "Indica que o inversor não detectou ação da parte do motor",
                recommended: "Verificar circuito do inversor e motor",
                severity: AlarmInput.SeverityLevel.Hi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmMotor.GetRead(4) ?? false;
                    return new ValueTask<bool>(v);
                }));


            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_SAF_FN_THER01_HIHOT",
                displayName: "Temperatura do forno superior excedida",
                description: "Temperatura do forno superior excedida",
                location_Panel: "Painel/Porta/Controlador de Temperatura superior",
                location_Machine: "Forno/Termopar superior",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Signals,
                functionDescription: "Indica super aquecimento",
                recommended: "Verificar termopar e controlador de temperatura",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmTemperaturaExcedeuSuperior.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_SAF_FN_THER02_HIHOT",
                displayName: "Temperatura do forno inferior excedida",
                description: "Temperatura do forno inferior excedida",
                location_Panel: "Painel/Porta/Controlador de Temperatura inferior",
                location_Machine: "Forno/Termopar inferior",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Signals,
                functionDescription: "Indica super aquecimento",
                recommended: "Verificar termopar e controlador de temperatura",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmTemperaturaExcedeuInferior.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_SAF_FN_THER01_OPEN",
                displayName: "Termopar superior aberto",
                description: "Termopar superior aberto",
                location_Panel: "Painel/Porta/Controlador de Temperatura superior",
                location_Machine: "Forno/Termopar superior",
                category: AlarmInput.CategoryLevel.Safety,
                subCategory: AlarmInput.SubCategoryLevel.Signals,
                functionDescription: "Indica que o controlador parou de receber o sinal do termopar",
                recommended: "Verificar termopar e controlador de temperatura",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmTermoparAbertoSuperior.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_SAF_FN_THER02_OPEN",
                displayName: "Termopar inferior aberto",
                description: "Termopar inferior aberto",
                location_Panel: "Painel/Porta/Controlador de Temperatura inferior",
                location_Machine: "Forno/Termopar inferior",
                category: AlarmInput.CategoryLevel.Safety,
                subCategory: AlarmInput.SubCategoryLevel.Signals,
                functionDescription: "Indica que o controlador parou de receber o sinal do termopar",
                recommended: "Verificar termopar e controlador de temperatura",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.AlmTermoparAbertoInferior.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_RES01_OPEN",
                displayName: "Resistência 01 Rompida",
                description: "Resistência 01 Rompida",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que a resistência esta aberta",
                recommended: "Verificar circuito da resistência",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeResistRompidaSuperior.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_RES02_OPEN",
                displayName: "Resistência 02 Rompida",
                description: "Resistência 02 Rompida",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que a resistência esta aberta",
                recommended: "Verificar circuito da resistência",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeResistRompidaSuperior.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_RES03_OPEN",
                displayName: "Resistência 03 Rompida",
                description: "Resistência 03 Rompida",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que a resistência esta aberta",
                recommended: "Verificar circuito da resistência",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeResistRompidaSuperior.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_RES04_OPEN",
                displayName: "Resistência 04 Rompida",
                description: "Resistência 04 Rompida",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que a resistência esta aberta",
                recommended: "Verificar circuito da resistência",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeResistRompidaInferior.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_RES05_OPEN",
                displayName: "Resistência 05 Rompida",
                description: "Resistência 05 Rompida",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que a resistência esta aberta",
                recommended: "Verificar circuito da resistência",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeResistRompidaInferior.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_FN_RES06_OPEN",
                displayName: "Resistência 06 Rompida",
                description: "Resistência 06 Rompida",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que a resistência esta aberta",
                recommended: "Verificar circuito da resistência",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeResistRompidaInferior.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR01_OPENED",
                displayName: "SSR 01 Aberto",
                description: "SSR 01 Aberto",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta aberto",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrSuperiorAberto.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR02_OPENED",
                displayName: "SSR 02 Aberto",
                description: "SSR 02 Aberto",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta aberto",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrSuperiorAberto.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR03_OPENED",
                displayName: "SSR 03 Aberto",
                description: "SSR 03 Aberto",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta aberto",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrSuperiorAberto.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR04_OPENED",
                displayName: "SSR 04 Aberto",
                description: "SSR 04 Aberto",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta aberto",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrInferiorAberto.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR05_OPENED",
                displayName: "SSR 05 Aberto",
                description: "SSR 05 Aberto",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta aberto",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrInferiorAberto.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ =_alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR06_OPENED",
                displayName: "SSR 06 Aberto",
                description: "SSR 06 Aberto",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta aberto",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrInferiorAberto.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR01_CLOSED",
                displayName: "SSR 01 fechado",
                description: "SSR 01 em curto circuito",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta Fechado",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrSuperiorFechado.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR02_CLOSED",
                displayName: "SSR 02 fechado",
                description: "SSR 02 em curto circuito",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta em curto circuito",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrSuperiorFechado.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR03_CLOSED",
                displayName: "SSR 03 fechado",
                description: "SSR 03 em curto circuito",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta em curto circuito",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrSuperiorFechado.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR04_CLOSED",
                displayName: "SSR 04 fechado",
                description: "SSR 04 em curto circuito",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta em curto circuito",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrInferiorFechado.GetRead(1) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR05_CLOSED",
                displayName: "SSR 05 fechado",
                description: "SSR 05 em curto circuito",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta em curto circuito",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrInferiorFechado.GetRead(2) ?? false;
                    return new ValueTask<bool>(v);
                }));
            _ = _alarmEngine.AddAlarm(new AlarmInput(
                id: "ALM_PRO_PN_SSR06_CLOSED",
                displayName: "SSR 06 fechado",
                description: "SSR 06 em curto circuito",
                location_Panel: "Painel/SSR",
                location_Machine: "Forno/Resistência",
                category: AlarmInput.CategoryLevel.Process,
                subCategory: AlarmInput.SubCategoryLevel.Heating,
                functionDescription: "Indica que o SSR esta em curto circuito",
                recommended: "Verificar circuito do SSR",
                severity: AlarmInput.SeverityLevel.HiHi,

                readAsync: ct =>
                {
                    bool v = GVL.Opcua.GVL_ImagensAlarmes.xAlarmeSsrInferiorFechado.GetRead(3) ?? false;
                    return new ValueTask<bool>(v);
                }));








        }
        #endregion
        bool Ackall;

        private async Task DoWorkOnceAsync(CancellationToken ct)
        {
            await _alarmEngine.ScanOnceAsync(ct);
            var snapshot = _alarmEngine.Snapshot();
            var nowLocal = DateTimeOffset.Now;
            
            if (Ackall == true)
            {
                var whenUtc = DateTimeOffset.UtcNow;
                _ = _alarmEngine.Acknowledge("ALM_GERAL_1", whenUtc);
            }
            foreach (var a in snapshot)
            {
                var lastChangeLocal = a.LastChangeUtc?.ToLocalTime();
                var lastActLocal = a.LastActivatedUtc?.ToLocalTime();
                var lastClrLocal = a.LastClearedUtc?.ToLocalTime();
                var lastAckLocal = a.LastAcknowledgedUtc?.ToLocalTime();

                string since =
                    lastChangeLocal.HasValue
                        ? (nowLocal - lastChangeLocal.Value).ToString(@"hh\:mm\:ss\.fff")
                        : "-";

                string err = a.LastReadError is null ? "-" : a.LastReadError.Message;

                Debug.WriteLine(
                    $"[{DateTime.Now:HH:mm:ss.fff}] " +
                    $"Id={a.Id} | Nome={a.DisplayName} | Ativo={a.IsActive} | Ack={a.IsAcknowledged} | " +
                    $"UltMudanca={(lastChangeLocal?.ToString("HH:mm:ss.fff") ?? "-")} (+{since}) | " +
                    $"Subida={(lastActLocal?.ToString("HH:mm:ss.fff") ?? "-")} | " +
                    $"Descida={(lastClrLocal?.ToString("HH:mm:ss.fff") ?? "-")} | " +
                    $"AckTime={(lastAckLocal?.ToString("HH:mm:ss.fff") ?? "-")} | " +
                    $"Erro={err}"
                );
            }



        }
    }
}
