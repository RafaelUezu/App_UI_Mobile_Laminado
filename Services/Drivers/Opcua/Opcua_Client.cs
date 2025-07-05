using MAUI_Opcua.Services.Communication.Variable;
using MAUI_Opcua.Services.Net.Tools;
using Newtonsoft.Json.Linq;
using Opc.Ua;
using Opc.Ua.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao.VM_Page_Manutencao_Saidas;

namespace MAUI_Opcua.Services.Drivers.Opcua
{
    public static class OpcUaEvents
    {
        public static event Func<Task>? LeituraFinalizadaAsync;

        public static async Task DispararLeituraFinalizadaAsync()
        {
            if (LeituraFinalizadaAsync != null)
            {
                var handlers = LeituraFinalizadaAsync.GetInvocationList().Cast<Func<Task>>();
                foreach (var handler in handlers)
                {
                    await handler();
                }
            }
        }
    }

    public class Opcua_Client
    {
        public static string? ExtractIpFromUrl(string opcUaUrl)
        {
            if (string.IsNullOrWhiteSpace(opcUaUrl))
                return null;

            // Remove o prefixo opc.tcp://
            var withoutProtocol = opcUaUrl.Replace("opc.tcp://", "");

            // Quebra no ':'
            var parts = withoutProtocol.Split(':');

            // O IP deve ser a primeira parte
            return parts.Length > 0 ? parts[0] : null;
        }

        private CancellationTokenSource _cts;
        private Task _backgroundTask;
       

        public bool IsRunning
        {
            get
            {
                return _backgroundTask != null &&
                       !_backgroundTask.IsCompleted &&
                       !_backgroundTask.IsCanceled &&
                       !_backgroundTask.IsFaulted;
            }
        }

        public void Start()
        {
            if (IsRunning) return;


            _cts = new CancellationTokenSource();
            GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Iniciando";
            OpcUaEvents.DispararLeituraFinalizadaAsync();
            _backgroundTask = Task.Run(() => RunLoop(_cts.Token, GVL.ConfSuper.iTimeOutPing.ReadWrite ?? 1000, GVL.ConfSuper.sUrlOpcUa.ReadWrite ?? "opc.tcp://10.10.210.20:4840", GVL.ConfSuper.iTimeRequest.ReadWrite ?? 700));
        }

        public async Task StopAsync()
        {
            if (!IsRunning)
                
                return;

            try
            {
                _cts?.Cancel();
                if (_backgroundTask != null)
                    await _backgroundTask;
                GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Parado";
                await OpcUaEvents.DispararLeituraFinalizadaAsync();
            }
            catch (Exception ex)
            {
                // Log se necessário
                System.Diagnostics.Debug.WriteLine($"Erro ao parar o driver: {ex.Message}");
                GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro ao parar";
                await OpcUaEvents.DispararLeituraFinalizadaAsync();
            }
            finally
            {
                _backgroundTask = null;
                GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Finalizado";
                await OpcUaEvents.DispararLeituraFinalizadaAsync();
                _cts = null;
            }
        }
        private bool _rebootRequested = false;

        public class OpcWriteItem
        {
            public string NodeIdString { get; set; } = string.Empty;

            // Índice opcional, se for um item de vetor
            public int? Index { get; set; }

            // Função que retorna o valor atual
            public Func<int?, object?> GetValue { get; set; } = _ => null;

            // Função que limpa o valor de escrita
            public Action<int?> ClearWriteFlag { get; set; } = _ => { };

            // Método utilitário para limpar
            public void Clear()
            {
                ClearWriteFlag(Index);
            }
        }

        private async Task RunLoop(CancellationToken token, int timeout_Ping_Ip, string urlopcua, int delay_request)
        {

            System.Diagnostics.Debug.WriteLine("Inicializando o Driver: " + urlopcua);

            if(delay_request <= 300)
            {
                delay_request = 300;
            }
            if (timeout_Ping_Ip <= 500)
            {
                timeout_Ping_Ip = 500;
            }
            string Ip = ExtractIpFromUrl(urlopcua);
            var Ping_Ip = new TCP_IP.Ping_IP(timeout_Ping_Ip, Ip); // IP, timeout (ms), porta
            bool online;
            int Error = 0;

            try
            {
                while (!token.IsCancellationRequested)
                {
                    Error = 0;
                    online = await Ping_Ip.PingHostAsync();
                    
                    if (online)
                    {
                        try
                        {
                            Opc.Ua.ApplicationConfiguration configuration = new Opc.Ua.ApplicationConfiguration();
                            ClientConfiguration clientConfiguration = new ClientConfiguration();
                            configuration.ClientConfiguration = clientConfiguration;
                            Stopwatch stopwatch_Total = Stopwatch.StartNew();
                            EndpointDescription endpointDescription = CoreClientUtils.SelectEndpoint(urlopcua, false); //Schneider: false, Delta: true
                            EndpointConfiguration endpointConfiguration = EndpointConfiguration.Create(configuration);
                            ConfiguredEndpoint endpoint = new ConfiguredEndpoint(null, endpointDescription, endpointConfiguration);
                            bool updateBeforeConnect = false;
                            bool checkDomain = false;
                            string sessionName = configuration.ApplicationName;
                            uint sessionTimeout = 60000;
                            UserIdentity user = new UserIdentity();
                            List<string>? preferredLocales = null;

                            // Create the session

                            Session session = Session.Create(
                                 configuration,
                                 endpoint,
                                 updateBeforeConnect,
                                 checkDomain,
                                 sessionName,
                                 sessionTimeout,
                                 user,
                                 preferredLocales
                             ).Result;

                            List<ReadValueId> nodesToRead_GVL_EntradasSaidas = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_EntradasSaidas.ImgTesteEntLog"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_EntradasSaidas.ImgForceSaiLog"), AttributeId = Attributes.Value },//0
                            };


                            List<ReadValueId> nodesToRead_GVL_Ihm_Manual = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtAbreFechaDampSup"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtAbreFechaPortaSup"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaBomVac01"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaVentSup"), AttributeId = Attributes.Value },//3
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS01"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS03"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS04"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS05"), AttributeId = Attributes.Value },//7

                            };

                            List<ReadValueId> nodesToRead_GVL_ImagensAlarmes = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ImagensAlarmes.ImgGeral"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ImagensAlarmes.ImgRetornoSsrSuperior"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ImagensAlarmes.ImgMotor"), AttributeId = Attributes.Value },//2

                            };

                            List<ReadValueId> nodesToRead_GVL_Energia = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteFaseA"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteFaseB"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteFaseC"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteNeutro"), AttributeId = Attributes.Value },//3

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteMaximaFaseA"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteMaximaFaseB"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteMaximaFaseC"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteMaximaNeutro"), AttributeId = Attributes.Value },//7

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoAN"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoBN"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoCN"), AttributeId = Attributes.Value },//10

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoAB"), AttributeId = Attributes.Value },//11
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoBC"), AttributeId = Attributes.Value },//12
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoCA"), AttributeId = Attributes.Value },//13

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaAN"), AttributeId = Attributes.Value },//14
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaBN"), AttributeId = Attributes.Value },//15
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaCN"), AttributeId = Attributes.Value },//16

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaAB"), AttributeId = Attributes.Value },//17
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaBC"), AttributeId = Attributes.Value },//18
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaCA"), AttributeId = Attributes.Value },//10

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoAvgLL"), AttributeId = Attributes.Value },//20
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteAvg"), AttributeId = Attributes.Value },//21
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fPotenciaAtivaTotal"), AttributeId = Attributes.Value },//22
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fEnergiaAtivaAcumulada"), AttributeId = Attributes.Value },//23
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fAtualDemanda"), AttributeId = Attributes.Value },//24
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fPicoDemanda"), AttributeId = Attributes.Value },//25
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fFatorPotenciaTotal"), AttributeId = Attributes.Value },//26
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fFrequencia"), AttributeId = Attributes.Value },//27
                            };

                            List<ReadValueId> nodesToRead_GVL_ClpIhm = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPortaEsq"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.xVacuo01Ok"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.rFrequenciaAtualVentSup"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iTermoparSup01"), AttributeId = Attributes.Value },//3

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa01Sup"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa02Sup"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa03Sup"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa04Sup"), AttributeId = Attributes.Value },//7
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa05Sup"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa06Sup"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa07Sup"), AttributeId = Attributes.Value },//10
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorRampa08Sup"), AttributeId = Attributes.Value },//11

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa01Sup"), AttributeId = Attributes.Value },//12
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa02Sup"), AttributeId = Attributes.Value },//13
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa03Sup"), AttributeId = Attributes.Value },//14
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa04Sup"), AttributeId = Attributes.Value },//15
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa05Sup"), AttributeId = Attributes.Value },//16
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa06Sup"), AttributeId = Attributes.Value },//17
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa07Sup"), AttributeId = Attributes.Value },//18
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorRampa08Sup"), AttributeId = Attributes.Value },//19

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa01Sup"), AttributeId = Attributes.Value },//20
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa02Sup"), AttributeId = Attributes.Value },//21
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa03Sup"), AttributeId = Attributes.Value },//22
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa04Sup"), AttributeId = Attributes.Value },//23
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa05Sup"), AttributeId = Attributes.Value },//24
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa06Sup"), AttributeId = Attributes.Value },//25
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa07Sup"), AttributeId = Attributes.Value },//26
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorRampa08Sup"), AttributeId = Attributes.Value },//27

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam01Sup"), AttributeId = Attributes.Value },//28
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam02Sup"), AttributeId = Attributes.Value },//29
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam03Sup"), AttributeId = Attributes.Value },//30
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam04Sup"), AttributeId = Attributes.Value },//31
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam05Sup"), AttributeId = Attributes.Value },//32
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam06Sup"), AttributeId = Attributes.Value },//33
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam07Sup"), AttributeId = Attributes.Value },//34
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorPatam08Sup"), AttributeId = Attributes.Value },//35

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam01Sup"), AttributeId = Attributes.Value },//36
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam02Sup"), AttributeId = Attributes.Value },//37
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam03Sup"), AttributeId = Attributes.Value },//38
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam04Sup"), AttributeId = Attributes.Value },//39
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam05Sup"), AttributeId = Attributes.Value },//40
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam06Sup"), AttributeId = Attributes.Value },//41
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam07Sup"), AttributeId = Attributes.Value },//42
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorPatam08Sup"), AttributeId = Attributes.Value },//43

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam01Sup"), AttributeId = Attributes.Value },//44
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam02Sup"), AttributeId = Attributes.Value },//45
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam03Sup"), AttributeId = Attributes.Value },//46
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam04Sup"), AttributeId = Attributes.Value },//47
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam05Sup"), AttributeId = Attributes.Value },//48
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam06Sup"), AttributeId = Attributes.Value },//49
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam07Sup"), AttributeId = Attributes.Value },//50
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorPatam08Sup"), AttributeId = Attributes.Value },//51

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.uStatusAquecimentoSup"), AttributeId = Attributes.Value },//52

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa01Sup"), AttributeId = Attributes.Value },//53
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa02Sup"), AttributeId = Attributes.Value },//54
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa03Sup"), AttributeId = Attributes.Value },//55
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa04Sup"), AttributeId = Attributes.Value },//56
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa05Sup"), AttributeId = Attributes.Value },//57
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa06Sup"), AttributeId = Attributes.Value },//58
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa07Sup"), AttributeId = Attributes.Value },//59
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusRampa08Sup"), AttributeId = Attributes.Value },//60

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorTasbSup"), AttributeId = Attributes.Value },//61
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorTasbSup"), AttributeId = Attributes.Value },//62

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorResfrSup"), AttributeId = Attributes.Value },//63
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorResfrSup"), AttributeId = Attributes.Value },//64

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorAbPortSup"), AttributeId = Attributes.Value },//65
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorAbPortSup"), AttributeId = Attributes.Value },//66

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorDecorTotalSup"), AttributeId = Attributes.Value },//67
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinDecorTotalSup"), AttributeId = Attributes.Value },//68
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iSegDecorTotalSup"), AttributeId = Attributes.Value },//69

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar01Sup"), AttributeId = Attributes.Value },//70
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar02Sup"), AttributeId = Attributes.Value },//71
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar03Sup"), AttributeId = Attributes.Value },//72
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar04Sup"), AttributeId = Attributes.Value },//73
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar05Sup"), AttributeId = Attributes.Value },//74
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar06Sup"), AttributeId = Attributes.Value },//75
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar07Sup"), AttributeId = Attributes.Value },//76
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPatamar08Sup"), AttributeId = Attributes.Value },//77

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iHorProgTotalSup"), AttributeId = Attributes.Value },//78
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iMinProgTotalSup"), AttributeId = Attributes.Value },//79
                            };
                            List<ReadValueId> nodesToRead_GVL_Permanentes = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa01"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa02"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa03"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa04"), AttributeId = Attributes.Value },//3
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa05"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa06"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa07"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iMinCxSupRampa08"), AttributeId = Attributes.Value },//7

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iTempoExaustorMinSup"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.iTempoAberturaSup"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.rTemperaturaMinimaSup"), AttributeId = Attributes.Value },//10

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLdomingo"), AttributeId = Attributes.Value },//11
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLsegunda"), AttributeId = Attributes.Value },//12
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLterca"), AttributeId = Attributes.Value },//13
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLquarta"), AttributeId = Attributes.Value },//14
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLquinta"), AttributeId = Attributes.Value },//15
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLsexta"), AttributeId = Attributes.Value },//16
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLsabado"), AttributeId = Attributes.Value },//17
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uHorProgramado"), AttributeId = Attributes.Value },//18
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uMinProgramado"), AttributeId = Attributes.Value },//19


                            };
                            List <ReadValueId> nodesToRead_GVL_IhmClp = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar01"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar02"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar03"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar04"), AttributeId = Attributes.Value },//3
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar05"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar06"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar07"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar08"), AttributeId = Attributes.Value },//7

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar01"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar02"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar03"), AttributeId = Attributes.Value },//10
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar04"), AttributeId = Attributes.Value },//11
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar05"), AttributeId = Attributes.Value },//12
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar06"), AttributeId = Attributes.Value },//13
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar07"), AttributeId = Attributes.Value },//14
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar08"), AttributeId = Attributes.Value },//15

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar01"), AttributeId = Attributes.Value },//16
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar02"), AttributeId = Attributes.Value },//17
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar03"), AttributeId = Attributes.Value },//18
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar04"), AttributeId = Attributes.Value },//19
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar05"), AttributeId = Attributes.Value },//20
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar06"), AttributeId = Attributes.Value },//21
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar07"), AttributeId = Attributes.Value },//22
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar08"), AttributeId = Attributes.Value },//23

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinTasbCxSup"), AttributeId = Attributes.Value },//24
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.BtLdVacuoMesa01"), AttributeId = Attributes.Value },//25
                            };




                            RequestHeader requestHeader_GVL_EntradasSaidas = new RequestHeader();
                            double maxAge_GVL_EntradasSaidas = 0;
                            TimestampsToReturn timestampsToReturn_GVL_EntradasSaidas = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_EntradasSaidas = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_EntradasSaidas = null;

                            RequestHeader requestHeader_GVL_Ihm_Manual = new RequestHeader();
                            double maxAge_GVL_Ihm_Manual = 0;
                            TimestampsToReturn timestampsToReturn_GVL_Ihm_Manual = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_Ihm_Manual = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_Ihm_Manual = null;

                            RequestHeader requestHeader_GVL_ImagensAlarmes = new RequestHeader();
                            double maxAge_GVL_ImagensAlarmes = 0;
                            TimestampsToReturn timestampsToReturn_GVL_ImagensAlarmes = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_ImagensAlarmes = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_ImagensAlarmes = null;

                            RequestHeader requestHeader_GVL_Energia = new RequestHeader();
                            double maxAge_GVL_Energia = 0;
                            TimestampsToReturn timestampsToReturn_GVL_Energia = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_Energia = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_Energia = null;

                            RequestHeader requestHeader_GVL_ClpIhm = new RequestHeader();
                            double maxAge_GVL_ClpIhm = 0;
                            TimestampsToReturn timestampsToReturn_GVL_ClpIhm = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_ClpIhm = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_ClpIhm = null;

                            RequestHeader requestHeader_GVL_Permanentes = new RequestHeader();
                            double maxAge_GVL_Permanentes = 0;
                            TimestampsToReturn timestampsToReturn_GVL_Permanentes = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_Permanentes = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_Permanentes = null;

                            RequestHeader requestHeader_GVL_IhmClp = new RequestHeader();
                            double maxAge_GVL_IhmClp = 0;
                            TimestampsToReturn timestampsToReturn_GVL_IhmClp = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_IhmClp = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_IhmClp = null;


                            var itemsToWrite_GVL_EntradasSaidas = new List<OpcWriteItem>();
                            for (int i = 0; i < 16; i++)
                            {
                                int idx_opc = i + 1;
                                int idx_sup = i;
                                itemsToWrite_GVL_EntradasSaidas.Add(new OpcWriteItem
                                {
                                    NodeIdString = $"ns=4;s=|var|AX-324NA0PA1P.Application.GVL_EntradasSaidas.ImgForceSaiLog_Test[{idx_opc}]",
                                    GetValue = (index) => GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetWrite(idx_sup),
                                    ClearWriteFlag = (index) => GVL.Opcua.EntradasSaidas.ImgForceSaiLog.ClearWrite(idx_sup)
                                });
                            }

                            var itemsToWrite_GVL_Ihm_Manual = new List<OpcWriteItem>()
                            {
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtAbreFechaDampSup",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaDampSup.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaDampSup.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtAbreFechaPortaSup",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaBomVac01",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaBomVac01.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaBomVac01.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaVentSup",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS01",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS01.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS01.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS02",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS02.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS02.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS03",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS03.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS03.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Ihm_Manual.xBtLigaDesligaSsrS04",
                                    GetValue = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS04.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS04.Write = null
                                },
                            };
                            var itemsToWrite_GVL_IhmClp = new List<OpcWriteItem>()
                            {
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar01",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar01.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar01.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar02",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar02.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar02.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar03",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar03.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar03.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar04",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar04.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar04.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar05",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar05.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar05.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar06",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar06.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar06.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar07",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar07.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar07.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.rTempCxSupPatamar08",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar08.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar08.Write = null
                                },

                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar01",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar02",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar02.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar02.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar03",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar03.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar03.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar04",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar04.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar04.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar05",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar05.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar05.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar06",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar06.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar06.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar07",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar07.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar07.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iHorCxSupPatamar08",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar08.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar08.Write = null
                                },
                                
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar01",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar02",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar02.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar02.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar03",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar03.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar03.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar04",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar04.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar04.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar05",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar05.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar05.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar06",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar06.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar06.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar07",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar07.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar07.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinCxSupPatamar08",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar08.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar08.Write = null
                                },

                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.iMinTasbCxSup",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.iMinTasbCxSup.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.iMinTasbCxSup.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_IhmClp.BtLdVacuoMesa01",
                                    GetValue = (_) => GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Write = null
                                },

                            };

                            var itemsToWrite_GVL_Permanentes = new List<OpcWriteItem>()
                            {
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.rTemperaturaMinimaSup",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.rTemperaturaMinimaSup.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.rTemperaturaMinimaSup.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLdomingo",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLdomingo.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLdomingo.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLsegunda",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLsegunda.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLsegunda.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLterca",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLterca.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLterca.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLquarta",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLquarta.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLquarta.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLquinta",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLquinta.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLquinta.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLsexta",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLsexta.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLsexta.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uLsabado",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uLsabado.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uLsabado.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uHorProgramado",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uHorProgramado.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uHorProgramado.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Permanentes.uMinProgramado",
                                    GetValue = (_) => GVL.Opcua.GVL_Permanentes.uMinProgramado.Write,
                                    ClearWriteFlag = (_) => GVL.Opcua.GVL_Permanentes.uMinProgramado.Write = null
                                },
                            };
                                

                            List <List<OpcWriteItem>> allItemsToWrite = new()
                            {
                                itemsToWrite_GVL_Ihm_Manual,
                                itemsToWrite_GVL_EntradasSaidas,
                                itemsToWrite_GVL_IhmClp
                            };



                            while (!token.IsCancellationRequested)
                            {
                                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("Error :" + Error));
                                if (Error >= 20)
                                {
                                    break;
                                }
                                online = await Ping_Ip.PingHostAsync();

                                if (online)
                                {
                                    try
                                    {
                                        Stopwatch sw = Stopwatch.StartNew();
                                        await ReadDataAsync();
                                        await AscribeDataAsync();
                                        await WriteDataAsync();
                                        await Task.Delay(delay_request, token); // Delay controlado
                                        GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Conectado";
                                        
                                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Métodos de leitura e escrita finalizados");
                                        sw.Stop();
                                        GVL.ConfSuper.iQueryTime.ReadWrite = sw.Elapsed.Milliseconds;
                                        await OpcUaEvents.DispararLeituraFinalizadaAsync();
                                    }
                                    catch (Exception ex)
                                    {
                                        GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro na Requisição";
                                        await OpcUaEvents.DispararLeituraFinalizadaAsync();
                                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na requisição");
                                        Error = Error++;
                                    }
                                }
                                else
                                {
                                    GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Tentando Conexão";
                                    await OpcUaEvents.DispararLeituraFinalizadaAsync();
                                    await Task.Delay(timeout_Ping_Ip, token); // Delay controlado
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Dispositivo desconectado. A leitura e escrita não serão efetuadas");
                                }
                            }

                            async Task ReadDataAsync()
                            {
                                try
                                {
                                    Stopwatch sw = Stopwatch.StartNew();

                                    ReadValueIdCollection nodesToReadCollection_GVL_EntradasSaidas = new ReadValueIdCollection(nodesToRead_GVL_EntradasSaidas);
                                    session.Read(
                                                requestHeader_GVL_EntradasSaidas,
                                                maxAge_GVL_EntradasSaidas,
                                                timestampsToReturn_GVL_EntradasSaidas,
                                                nodesToReadCollection_GVL_EntradasSaidas,
                                                out results_GVL_EntradasSaidas,
                                                out diagnosticInfos_GVL_EntradasSaidas
                                                );

                                    ReadValueIdCollection nodesToReadCollection_GVL_Ihm_Manual = new ReadValueIdCollection(nodesToRead_GVL_Ihm_Manual);
                                    session.Read(
                                                requestHeader_GVL_Ihm_Manual,
                                                maxAge_GVL_Ihm_Manual,
                                                timestampsToReturn_GVL_Ihm_Manual,
                                                nodesToReadCollection_GVL_Ihm_Manual,
                                                out results_GVL_Ihm_Manual,
                                                out diagnosticInfos_GVL_Ihm_Manual
                                                );

                                    ReadValueIdCollection nodesToReadCollection_GVL_ImagensAlarmes = new ReadValueIdCollection(nodesToRead_GVL_ImagensAlarmes);
                                    session.Read(
                                                requestHeader_GVL_ImagensAlarmes,
                                                maxAge_GVL_ImagensAlarmes,
                                                timestampsToReturn_GVL_ImagensAlarmes,
                                                nodesToReadCollection_GVL_ImagensAlarmes,
                                                out results_GVL_ImagensAlarmes,
                                                out diagnosticInfos_GVL_ImagensAlarmes
                                                );

                                    ReadValueIdCollection nodesToReadCollection_GVL_Energia = new ReadValueIdCollection(nodesToRead_GVL_Energia);
                                    session.Read(
                                                requestHeader_GVL_Energia,
                                                maxAge_GVL_Energia,
                                                timestampsToReturn_GVL_Energia,
                                                nodesToReadCollection_GVL_Energia,
                                                out results_GVL_Energia,
                                                out diagnosticInfos_GVL_Energia
                                                );


                                    ReadValueIdCollection nodesToReadCollection_GVL_ClpIhm = new ReadValueIdCollection(nodesToRead_GVL_ClpIhm);
                                    session.Read(
                                                requestHeader_GVL_ClpIhm,
                                                maxAge_GVL_ClpIhm,
                                                timestampsToReturn_GVL_ClpIhm,
                                                nodesToReadCollection_GVL_ClpIhm,
                                                out results_GVL_ClpIhm,
                                                out diagnosticInfos_GVL_ClpIhm
                                                );


                                    ReadValueIdCollection nodesToReadCollection_GVL_Permanentes = new ReadValueIdCollection(nodesToRead_GVL_Permanentes);
                                    session.Read(
                                                requestHeader_GVL_Permanentes,
                                                maxAge_GVL_Permanentes,
                                                timestampsToReturn_GVL_Permanentes,
                                                nodesToReadCollection_GVL_Permanentes,
                                                out results_GVL_Permanentes,
                                                out diagnosticInfos_GVL_Permanentes
                                                );


                                    ReadValueIdCollection nodesToReadCollection_GVL_IhmClp = new ReadValueIdCollection(nodesToRead_GVL_IhmClp);
                                    session.Read(
                                                requestHeader_GVL_IhmClp,
                                                maxAge_GVL_IhmClp,
                                                timestampsToReturn_GVL_IhmClp,
                                                nodesToReadCollection_GVL_IhmClp,
                                                out results_GVL_IhmClp,
                                                out diagnosticInfos_GVL_IhmClp
                                                );


                                    sw.Stop();
                                    System.Diagnostics.Debug.WriteLine("Tempo de Leitura" + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch
                                {
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na leitura do OPC UA");
                                    Error = Error + 1;
                                    GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro na Leitura";
                                    await OpcUaEvents.DispararLeituraFinalizadaAsync();
                                    return;
                                }

                            }

                            // Função local de escrita
                            async Task WriteDataAsync()
                            {
                                try
                                {
                                    Stopwatch sw = Stopwatch.StartNew();
                                    var allItems = allItemsToWrite.SelectMany(group => group).ToList();
                                    var validItems = new List<OpcWriteItem>();
                                    var nodesToWrite = new WriteValueCollection();


                                    foreach (var item in allItems)
                                    {
                                        var value = item.GetValue(item.Index);
                                        if (value != null)
                                        {
                                            nodesToWrite.Add(new WriteValue
                                            {
                                                NodeId = NodeId.Parse(item.NodeIdString),
                                                AttributeId = Attributes.Value,
                                                Value = new DataValue(new Variant(value))
                                            });

                                            validItems.Add(item);
                                        }
                                    }

                                    if (nodesToWrite.Count > 0)
                                    {
                                        session.Write(null, nodesToWrite, out StatusCodeCollection results, out DiagnosticInfoCollection diagnosticInfos);
                                        for (int i = 0; i < results.Count; i++)
                                        {
                                            if (StatusCode.IsGood(results[i]))
                                            {
                                                validItems[i].Clear(); // usa método .Clear() que chama o ClearWriteFlag(Index)
                                            }
                                            else
                                            {
                                                System.Diagnostics.Debug.WriteLine($"Erro ao escrever {nodesToWrite[i].NodeId}: {results[i]}");
                                            }
                                        }
                                    }



                                    sw.Stop();
                                    System.Diagnostics.Debug.WriteLine($"Tempo de Escrita " + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch (Exception ex)
                                {
                                    System.Diagnostics.Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}: Erro na escrita do OPC UA - {ex.Message}");
                                    GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro na Escrita";
                                    Error++;
                                }
                            }

                            async Task AscribeDataAsync()
                            {
                                try
                                {
                                    Stopwatch sw = Stopwatch.StartNew();
                                    if (results_GVL_EntradasSaidas[0].Value != null)
                                    {
                                        bool[] ImgTesteEntLog = results_GVL_EntradasSaidas[0].Value as bool[];
                                        for (int i = 0; i < ImgTesteEntLog.Length; i++)
                                        {
                                            GVL.Opcua.EntradasSaidas.ImgTesteEntLog.SetRead(i, (bool)ImgTesteEntLog[i]);
                                        }
                                    }
                                    if (results_GVL_EntradasSaidas[1].Value != null)
                                    {
                                        bool[] ImgForceSaiLog = results_GVL_EntradasSaidas[1].Value as bool[];
                                        for (int i = 0; i < ImgForceSaiLog.Length; i++)
                                        {
                                            GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetRead(i, (bool)ImgForceSaiLog[i]);
                                        }
                                    }
                                    if(results_GVL_Ihm_Manual[0].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaDampSup.Read = ((bool)results_GVL_Ihm_Manual[0].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[1].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtAbreFechaPortaSup.Read = ((bool)results_GVL_Ihm_Manual[1].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[2].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaBomVac01.Read = ((bool)results_GVL_Ihm_Manual[2].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[3].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaVentSup.Read = ((bool)results_GVL_Ihm_Manual[3].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[4].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS01.Read = ((bool)results_GVL_Ihm_Manual[4].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[5].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS02.Read = ((bool)results_GVL_Ihm_Manual[5].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[6].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS03.Read = ((bool)results_GVL_Ihm_Manual[6].Value);
                                    }
                                    if (results_GVL_Ihm_Manual[7].Value != null)
                                    {
                                        GVL.Opcua.GVL_Ihm_Manual.xBtLigaDesligaSsrS04.Read = ((bool)results_GVL_Ihm_Manual[7].Value);
                                    }
                                    if (results_GVL_ImagensAlarmes[0].Value != null)
                                    {
                                        bool[] ImgGeral = results_GVL_ImagensAlarmes[0].Value as bool[];
                                        for (int i = 0; i < ImgGeral.Length; i++)
                                        {
                                            GVL.Opcua.GVL_ImagensAlarmes.ImgGeral.SetRead(i, (bool)ImgGeral[i]);
                                        }
                                    }
                                    if (results_GVL_ImagensAlarmes[1].Value != null)
                                    {
                                        bool[] ImgRetornoSsrSuperior = results_GVL_ImagensAlarmes[1].Value as bool[];
                                        for (int i = 0; i < ImgRetornoSsrSuperior.Length; i++)
                                        {
                                            GVL.Opcua.GVL_ImagensAlarmes.ImgRetornoSsrSuperior.SetRead(i, (bool)ImgRetornoSsrSuperior[i]);
                                        }
                                    }
                                    if (results_GVL_ImagensAlarmes[2].Value != null)
                                    {
                                        bool[] ImgMotor = results_GVL_ImagensAlarmes[2].Value as bool[];
                                        for (int i = 0; i < ImgMotor.Length; i++)
                                        {
                                            GVL.Opcua.GVL_ImagensAlarmes.ImgMotor.SetRead(i, (bool)ImgMotor[i]);
                                        }
                                    }


                                    if (results_GVL_Energia[0].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteFaseA.Read = (float)results_GVL_Energia[0].Value;
                                    }
                                    if (results_GVL_Energia[1].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteFaseB.Read = (float)results_GVL_Energia[1].Value;
                                    }
                                    if (results_GVL_Energia[2].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteFaseC.Read = (float)results_GVL_Energia[2].Value;
                                    }
                                    if (results_GVL_Energia[3].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteNeutro.Read = (float)results_GVL_Energia[3].Value;
                                    }

                                    if (results_GVL_Energia[4].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteMaximaFaseA.Read = (float)results_GVL_Energia[4].Value;
                                    }
                                    if (results_GVL_Energia[5].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteMaximaFaseB.Read = (float)results_GVL_Energia[5].Value;
                                    }
                                    if (results_GVL_Energia[6].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteMaximaFaseC.Read = (float)results_GVL_Energia[6].Value;
                                    }
                                    if (results_GVL_Energia[7].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteMaximaNeutro.Read = (float)results_GVL_Energia[7].Value;
                                    }





                                    if (results_GVL_Energia[8].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoAN.Read = (float)results_GVL_Energia[8].Value;
                                    }
                                    if (results_GVL_Energia[9].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoBN.Read = (float)results_GVL_Energia[9].Value;
                                    }
                                    if (results_GVL_Energia[10].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoCN.Read = (float)results_GVL_Energia[10].Value;
                                    }

                                    if (results_GVL_Energia[11].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoAB.Read = (float)results_GVL_Energia[11].Value;
                                    }
                                    if (results_GVL_Energia[12].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoBC.Read = (float)results_GVL_Energia[12].Value;
                                    }
                                    if (results_GVL_Energia[13].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoCA.Read = (float)results_GVL_Energia[13].Value;
                                    }

                                    if (results_GVL_Energia[14].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaAN.Read = (float)results_GVL_Energia[14].Value;
                                    }
                                    if (results_GVL_Energia[15].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaBN.Read = (float)results_GVL_Energia[15].Value;
                                    }
                                    if (results_GVL_Energia[16].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaCN.Read = (float)results_GVL_Energia[16].Value;
                                    }

                                    if (results_GVL_Energia[17].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaAB.Read = (float)results_GVL_Energia[17].Value;
                                    }
                                    if (results_GVL_Energia[18].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaBC.Read = (float)results_GVL_Energia[18].Value;
                                    }
                                    if (results_GVL_Energia[19].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaCA.Read = (float)results_GVL_Energia[19].Value;
                                    }

                                    if (results_GVL_Energia[20].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoAvgLL.Read = (float)results_GVL_Energia[20].Value;
                                    }
                                    if (results_GVL_Energia[21].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteAvg.Read = (float)results_GVL_Energia[21].Value;
                                    }
                                    if (results_GVL_Energia[22].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fPotenciaAtivaTotal.Read = (float)results_GVL_Energia[22].Value;
                                    }
                                    if (results_GVL_Energia[23].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fEnergiaAtivaAcumulada.Read = (float)results_GVL_Energia[23].Value;
                                    }
                                    if (results_GVL_Energia[24].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fAtualDemanda.Read = (float)results_GVL_Energia[24].Value;
                                    }
                                    if (results_GVL_Energia[25].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fPicoDemanda.Read = (float)results_GVL_Energia[25].Value;
                                    }
                                    if (results_GVL_Energia[26].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fFatorPotenciaTotal.Read = (float)results_GVL_Energia[26].Value;
                                    }
                                    if (results_GVL_Energia[27].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fFrequencia.Read = (float)results_GVL_Energia[27].Value;
                                    }

                                    // GVL_ClpIhm

                                    if (results_GVL_ClpIhm[0].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPortaEsq.Read = (ushort)results_GVL_ClpIhm[0].Value;
                                    }
                                    if (results_GVL_ClpIhm[1].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.xVacuo01Ok.Read = (bool)results_GVL_ClpIhm[1].Value;
                                    }
                                    if (results_GVL_ClpIhm[2].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.rFrequenciaAtualVentSup.Read = (float)results_GVL_ClpIhm[2].Value;
                                    }
                                    if (results_GVL_ClpIhm[3].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iTermoparSup01.Read = (short)(Int16)results_GVL_ClpIhm[3].Value;
                                    }

                                    if (results_GVL_ClpIhm[4].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa01Sup.Read = (short)(Int16)results_GVL_ClpIhm[4].Value;
                                    }
                                    if (results_GVL_ClpIhm[5].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa02Sup.Read = (short)(Int16)results_GVL_ClpIhm[5].Value;
                                    }
                                    if (results_GVL_ClpIhm[6].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa03Sup.Read = (short)(Int16)results_GVL_ClpIhm[6].Value;
                                    }
                                    if (results_GVL_ClpIhm[7].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa04Sup.Read = (short)(Int16)results_GVL_ClpIhm[7].Value;
                                    }
                                    if (results_GVL_ClpIhm[8].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa05Sup.Read = (short)(Int16)results_GVL_ClpIhm[8].Value;
                                    }
                                    if (results_GVL_ClpIhm[9].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa06Sup.Read = (short)(Int16)results_GVL_ClpIhm[9].Value;
                                    }
                                    if (results_GVL_ClpIhm[10].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa07Sup.Read = (short)(Int16)results_GVL_ClpIhm[10].Value;
                                    }
                                    if (results_GVL_ClpIhm[11].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorRampa08Sup.Read = (short)(Int16)results_GVL_ClpIhm[11].Value;
                                    }
                                    if (results_GVL_ClpIhm[12].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa01Sup.Read = (short)(Int16)results_GVL_ClpIhm[12].Value;
                                    }
                                    if (results_GVL_ClpIhm[13].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa02Sup.Read = (short)(Int16)results_GVL_ClpIhm[13].Value;
                                    }
                                    if (results_GVL_ClpIhm[14].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa03Sup.Read = (short)(Int16)results_GVL_ClpIhm[14].Value;
                                    }
                                    if (results_GVL_ClpIhm[15].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa04Sup.Read = (short)(Int16)results_GVL_ClpIhm[15].Value;
                                    }
                                    if (results_GVL_ClpIhm[16].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa05Sup.Read = (short)(Int16)results_GVL_ClpIhm[16].Value;
                                    }
                                    if (results_GVL_ClpIhm[17].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa06Sup.Read = (short)(Int16)results_GVL_ClpIhm[17].Value;
                                    }
                                    if (results_GVL_ClpIhm[18].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa07Sup.Read = (short)(Int16)results_GVL_ClpIhm[18].Value;
                                    }
                                    if (results_GVL_ClpIhm[19].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorRampa08Sup.Read = (short)(Int16)results_GVL_ClpIhm[19].Value;
                                    }

                                    if (results_GVL_ClpIhm[20].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa01Sup.Read = (short)(Int16)results_GVL_ClpIhm[20].Value;
                                    }
                                    if (results_GVL_ClpIhm[21].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa02Sup.Read = (short)(Int16)results_GVL_ClpIhm[21].Value;
                                    }
                                    if (results_GVL_ClpIhm[22].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa03Sup.Read = (short)(Int16)results_GVL_ClpIhm[22].Value;
                                    }
                                    if (results_GVL_ClpIhm[23].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa04Sup.Read = (short)(Int16)results_GVL_ClpIhm[23].Value;
                                    }
                                    if (results_GVL_ClpIhm[24].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa05Sup.Read = (short)(Int16)results_GVL_ClpIhm[24].Value;
                                    }
                                    if (results_GVL_ClpIhm[25].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa06Sup.Read = (short)(Int16)results_GVL_ClpIhm[25].Value;
                                    }
                                    if (results_GVL_ClpIhm[26].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa07Sup.Read = (short)(Int16)results_GVL_ClpIhm[26].Value;
                                    }
                                    if (results_GVL_ClpIhm[27].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorRampa08Sup.Read = (short)(Int16)results_GVL_ClpIhm[27].Value;
                                    }

                                    if (results_GVL_ClpIhm[28].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam01Sup.Read = (short)(Int16)results_GVL_ClpIhm[28].Value;
                                    }
                                    if (results_GVL_ClpIhm[29].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam02Sup.Read = (short)(Int16)results_GVL_ClpIhm[29].Value;
                                    }
                                    if (results_GVL_ClpIhm[30].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam03Sup.Read = (short)(Int16)results_GVL_ClpIhm[30].Value;
                                    }
                                    if (results_GVL_ClpIhm[31].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam04Sup.Read = (short)(Int16)results_GVL_ClpIhm[31].Value;
                                    }
                                    if (results_GVL_ClpIhm[32].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam05Sup.Read = (short)(Int16)results_GVL_ClpIhm[32].Value;
                                    }
                                    if (results_GVL_ClpIhm[33].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam06Sup.Read = (short)(Int16)results_GVL_ClpIhm[33].Value;
                                    }
                                    if (results_GVL_ClpIhm[34].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam07Sup.Read = (short)(Int16)results_GVL_ClpIhm[34].Value;
                                    }
                                    if (results_GVL_ClpIhm[35].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorPatam08Sup.Read = (short)(Int16)results_GVL_ClpIhm[35].Value;
                                    }
                                    if (results_GVL_ClpIhm[36].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam01Sup.Read = (short)(Int16)results_GVL_ClpIhm[36].Value;
                                    }
                                    if (results_GVL_ClpIhm[37].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam02Sup.Read = (short)(Int16)results_GVL_ClpIhm[37].Value;
                                    }
                                    if (results_GVL_ClpIhm[38].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam03Sup.Read = (short)(Int16)results_GVL_ClpIhm[38].Value;
                                    }
                                    if (results_GVL_ClpIhm[39].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam04Sup.Read = (short)(Int16)results_GVL_ClpIhm[39].Value;
                                    }
                                    if (results_GVL_ClpIhm[40].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam05Sup.Read = (short)(Int16)results_GVL_ClpIhm[40].Value;
                                    }
                                    if (results_GVL_ClpIhm[41].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam06Sup.Read = (short)(Int16)results_GVL_ClpIhm[41].Value;
                                    }
                                    if (results_GVL_ClpIhm[42].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam07Sup.Read = (short)(Int16)results_GVL_ClpIhm[42].Value;
                                    }
                                    if (results_GVL_ClpIhm[43].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorPatam08Sup.Read = (short)(Int16)results_GVL_ClpIhm[43].Value;
                                    }

                                    if (results_GVL_ClpIhm[44].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam01Sup.Read = (short)(Int16)results_GVL_ClpIhm[44].Value;
                                    }
                                    if (results_GVL_ClpIhm[45].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam02Sup.Read = (short)(Int16)results_GVL_ClpIhm[45].Value;
                                    }
                                    if (results_GVL_ClpIhm[46].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam03Sup.Read = (short)(Int16)results_GVL_ClpIhm[46].Value;
                                    }
                                    if (results_GVL_ClpIhm[47].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam04Sup.Read = (short)(Int16)results_GVL_ClpIhm[47].Value;
                                    }
                                    if (results_GVL_ClpIhm[48].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam05Sup.Read = (short)(Int16)results_GVL_ClpIhm[48].Value;
                                    }
                                    if (results_GVL_ClpIhm[49].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam06Sup.Read = (short)(Int16)results_GVL_ClpIhm[49].Value;
                                    }
                                    if (results_GVL_ClpIhm[50].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam07Sup.Read = (short)(Int16)results_GVL_ClpIhm[50].Value;
                                    }
                                    if (results_GVL_ClpIhm[51].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorPatam08Sup.Read = (short)(Int16)results_GVL_ClpIhm[51].Value;
                                    }

                                    if (results_GVL_ClpIhm[52].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.uStatusAquecimentoSup.Read = (short)(Int16)results_GVL_ClpIhm[52].Value;
                                    }

                                    if (results_GVL_ClpIhm[53].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa01Sup.Read = (int)(ushort)results_GVL_ClpIhm[53].Value;
                                    }
                                    if (results_GVL_ClpIhm[54].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa02Sup.Read = (int)(ushort)results_GVL_ClpIhm[54].Value;
                                    }
                                    if (results_GVL_ClpIhm[55].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa03Sup.Read = (int)(ushort)results_GVL_ClpIhm[55].Value;
                                    }
                                    if (results_GVL_ClpIhm[56].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa04Sup.Read = (int)(ushort)results_GVL_ClpIhm[56].Value;
                                    }
                                    if (results_GVL_ClpIhm[57].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa05Sup.Read = (int)(ushort)results_GVL_ClpIhm[57].Value;
                                    }
                                    if (results_GVL_ClpIhm[58].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa06Sup.Read = (int)(ushort)results_GVL_ClpIhm[58].Value;
                                    }
                                    if (results_GVL_ClpIhm[59].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa07Sup.Read = (int)(ushort)results_GVL_ClpIhm[59].Value;
                                    }
                                    if (results_GVL_ClpIhm[60].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusRampa08Sup.Read = (int)(ushort)results_GVL_ClpIhm[60].Value;
                                    }

                                    if (results_GVL_ClpIhm[61].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorTasbSup.Read = (short)(Int16)results_GVL_ClpIhm[61].Value;
                                    }
                                    if (results_GVL_ClpIhm[62].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorTasbSup.Read = (short)(Int16)results_GVL_ClpIhm[62].Value;
                                    }

                                    if (results_GVL_ClpIhm[63].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorResfrSup.Read = (short)(Int16)results_GVL_ClpIhm[63].Value;
                                    }
                                    if (results_GVL_ClpIhm[64].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorResfrSup.Read = (short)(Int16)results_GVL_ClpIhm[64].Value;
                                    }

                                    if (results_GVL_ClpIhm[65].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorAbPortSup.Read = (short)(Int16)results_GVL_ClpIhm[65].Value;
                                    }
                                    if (results_GVL_ClpIhm[66].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorAbPortSup.Read = (short)(Int16)results_GVL_ClpIhm[66].Value;
                                    }

                                    if (results_GVL_ClpIhm[67].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorDecorTotalSup.Read = (short)(Int16)results_GVL_ClpIhm[67].Value;
                                    }
                                    if (results_GVL_ClpIhm[68].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinDecorTotalSup.Read = (short)(Int16)results_GVL_ClpIhm[68].Value;
                                    }
                                    if (results_GVL_ClpIhm[69].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iSegDecorTotalSup.Read = (short)(Int16)results_GVL_ClpIhm[69].Value;
                                    }
                                    if (results_GVL_ClpIhm[70].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar01Sup.Read = (int)(ushort)results_GVL_ClpIhm[70].Value;
                                    }
                                    if (results_GVL_ClpIhm[71].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar02Sup.Read = (int)(ushort)results_GVL_ClpIhm[71].Value;
                                    }
                                    if (results_GVL_ClpIhm[72].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar03Sup.Read = (int)(ushort)results_GVL_ClpIhm[72].Value;
                                    }
                                    if (results_GVL_ClpIhm[73].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar04Sup.Read = (int)(ushort)results_GVL_ClpIhm[73].Value;
                                    }
                                    if (results_GVL_ClpIhm[74].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar05Sup.Read = (int)(ushort)results_GVL_ClpIhm[74].Value;
                                    }
                                    if (results_GVL_ClpIhm[75].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar06Sup.Read = (int)(ushort)results_GVL_ClpIhm[75].Value;
                                    }
                                    if (results_GVL_ClpIhm[76].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar07Sup.Read = (int)(ushort)results_GVL_ClpIhm[76].Value;
                                    }
                                    if (results_GVL_ClpIhm[77].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.wStatusPatamar08Sup.Read = (int)(ushort)results_GVL_ClpIhm[77].Value;
                                    }

                                    if (results_GVL_ClpIhm[78].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iHorProgTotalSup.Read = (short)(Int16)results_GVL_ClpIhm[78].Value;
                                    }
                                    if (results_GVL_ClpIhm[79].Value != null)
                                    {
                                        GVL.Opcua.GVL_ClpIhm.iMinProgTotalSup.Read = (short)(Int16)results_GVL_ClpIhm[78].Value;
                                    }


                                    // GVL_Permanentes

                                    if (results_GVL_Permanentes[0].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa01.Read = (short)(Int16)results_GVL_Permanentes[0].Value;
                                    }
                                    if (results_GVL_Permanentes[1].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa02.Read = (short)(Int16)results_GVL_Permanentes[1].Value;
                                    }
                                    if (results_GVL_Permanentes[2].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa03.Read = (short)(Int16)results_GVL_Permanentes[2].Value;
                                    }
                                    if (results_GVL_Permanentes[3].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa04.Read = (short)(Int16)results_GVL_Permanentes[3].Value;
                                    }
                                    if (results_GVL_Permanentes[4].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa05.Read = (short)(Int16)results_GVL_Permanentes[4].Value;
                                    }
                                    if (results_GVL_Permanentes[5].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa06.Read = (short)(Int16)results_GVL_Permanentes[5].Value;
                                    }
                                    if (results_GVL_Permanentes[6].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa07.Read = (short)(Int16)results_GVL_Permanentes[6].Value;
                                    }
                                    if (results_GVL_Permanentes[7].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iMinCxSupRampa08.Read = (short)(Int16)results_GVL_Permanentes[7].Value;
                                    }

                                    if (results_GVL_Permanentes[8].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iTempoExaustorMinSup.Read = (short)(Int16)results_GVL_Permanentes[8].Value;
                                    }
                                    if (results_GVL_Permanentes[9].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.iTempoAberturaSup.Read = (short)(Int16)results_GVL_Permanentes[9].Value;
                                    }
                                    if (results_GVL_Permanentes[10].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.rTemperaturaMinimaSup.Read = (float)results_GVL_Permanentes[10].Value;
                                    }
                                    if (results_GVL_Permanentes[11].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLdomingo.Read = (uint)results_GVL_Permanentes[11].Value;
                                    }
                                    if (results_GVL_Permanentes[12].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLsegunda.Read = (uint)results_GVL_Permanentes[12].Value;
                                    }
                                    if (results_GVL_Permanentes[13].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLterca.Read = (uint)results_GVL_Permanentes[13].Value;
                                    }
                                    if (results_GVL_Permanentes[14].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLquarta.Read = (uint)results_GVL_Permanentes[14].Value;
                                    }
                                    if (results_GVL_Permanentes[15].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLquinta.Read = (uint)results_GVL_Permanentes[15].Value;
                                    }
                                    if (results_GVL_Permanentes[16].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLsexta.Read = (uint)results_GVL_Permanentes[16].Value;
                                    }
                                    if (results_GVL_Permanentes[17].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uLsabado.Read = (uint)results_GVL_Permanentes[17].Value;
                                    }
                                    if (results_GVL_Permanentes[18].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uHorProgramado.Read = (uint)results_GVL_Permanentes[18].Value;
                                    }
                                    if (results_GVL_Permanentes[19].Value != null)
                                    {
                                        GVL.Opcua.GVL_Permanentes.uMinProgramado.Read = (uint)results_GVL_Permanentes[19].Value;
                                    }


                                    // GVL_IhmClp

                                    if (results_GVL_IhmClp[0].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar01.Read = (float)results_GVL_IhmClp[0].Value;
                                    }
                                    if (results_GVL_IhmClp[1].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar02.Read = (float)results_GVL_IhmClp[1].Value;
                                    }
                                    if (results_GVL_IhmClp[2].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar03.Read = (float)results_GVL_IhmClp[2].Value;
                                    }
                                    if (results_GVL_IhmClp[3].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar04.Read = (float)results_GVL_IhmClp[3].Value;
                                    }
                                    if (results_GVL_IhmClp[4].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar05.Read = (float)results_GVL_IhmClp[4].Value;
                                    }
                                    if (results_GVL_IhmClp[5].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar06.Read = (float)results_GVL_IhmClp[5].Value;
                                    }
                                    if (results_GVL_IhmClp[6].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar07.Read = (float)results_GVL_IhmClp[6].Value;
                                    }
                                    if (results_GVL_IhmClp[7].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.rTempCxSupPatamar08.Read = (float)results_GVL_IhmClp[7].Value;
                                    }


                                    if (results_GVL_IhmClp[8].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar01.Read = (Int16)results_GVL_IhmClp[8].Value;
                                    }
                                    if (results_GVL_IhmClp[9].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar02.Read = (Int16)results_GVL_IhmClp[9].Value;
                                    }
                                    if (results_GVL_IhmClp[10].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar03.Read = (Int16)results_GVL_IhmClp[10].Value;
                                    }
                                    if (results_GVL_IhmClp[11].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar04.Read = (Int16)results_GVL_IhmClp[11].Value;
                                    }
                                    if (results_GVL_IhmClp[12].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar05.Read = (Int16)results_GVL_IhmClp[12].Value;
                                    }
                                    if (results_GVL_IhmClp[13].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar06.Read = (Int16)results_GVL_IhmClp[13].Value;
                                    }
                                    if (results_GVL_IhmClp[14].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar07.Read = (Int16)results_GVL_IhmClp[14].Value;
                                    }
                                    if (results_GVL_IhmClp[15].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iHorCxSupPatamar08.Read = (Int16)results_GVL_IhmClp[15].Value;
                                    }

                                    if (results_GVL_IhmClp[16].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar01.Read = (Int16)results_GVL_IhmClp[16].Value;
                                    }
                                    if (results_GVL_IhmClp[17].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar02.Read = (Int16)results_GVL_IhmClp[17].Value;
                                    }
                                    if (results_GVL_IhmClp[18].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar03.Read = (Int16)results_GVL_IhmClp[18].Value;
                                    }
                                    if (results_GVL_IhmClp[19].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar04.Read = (Int16)results_GVL_IhmClp[19].Value;
                                    }
                                    if (results_GVL_IhmClp[20].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar05.Read = (Int16)results_GVL_IhmClp[20].Value;
                                    }
                                    if (results_GVL_IhmClp[21].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar06.Read = (Int16)results_GVL_IhmClp[21].Value;
                                    }
                                    if (results_GVL_IhmClp[22].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar07.Read = (Int16)results_GVL_IhmClp[22].Value;
                                    }
                                    if (results_GVL_IhmClp[23].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinCxSupPatamar08.Read = (Int16)results_GVL_IhmClp[23].Value;
                                    }

                                    if (results_GVL_IhmClp[24].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.iMinTasbCxSup.Read = (Int16)results_GVL_IhmClp[24].Value;
                                    }

                                    if (results_GVL_IhmClp[25].Value != null)
                                    {
                                        GVL.Opcua.GVL_IhmClp.BtLdVacuoMesa01.Read = (bool)results_GVL_IhmClp[25].Value;
                                    }

                                    sw.Stop(); 
                                    System.Diagnostics.Debug.WriteLine("Tempo de passagem de valor" + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch(Exception ex)
                                {
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na passagem de valor. " + "Linha: " + ex.StackTrace);
                                    Error = Error + 1;
                                    GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro na Passagem";
                                    await OpcUaEvents.DispararLeituraFinalizadaAsync();
                                    return;
                                }
                            }
                        }
                        catch
                        {
                            System.Diagnostics.Debug.WriteLine("Inicializando o Driver por Erro 1: " + urlopcua);
                            Error = Error + 1;
                            GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro na Criação";
                            await OpcUaEvents.DispararLeituraFinalizadaAsync();
                            break;
                        }
                    }
                    else
                    {
                        GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Tentando Conexão";
                        await OpcUaEvents.DispararLeituraFinalizadaAsync();
                        await Task.Delay(timeout_Ping_Ip, token); // Delay controlado
                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Dispositivo desconectado. O serviço Driver OPCUA Client não será iniciado");
                    }
                }

            }
            catch
            {
                GVL.ConfSuper.sStatusOpcUa.ReadWrite = "Erro na Criação";
                await OpcUaEvents.DispararLeituraFinalizadaAsync();
                System.Diagnostics.Debug.WriteLine("Inicializando o Driver por Erro 2: " + urlopcua);
            }
        }
    }
}
