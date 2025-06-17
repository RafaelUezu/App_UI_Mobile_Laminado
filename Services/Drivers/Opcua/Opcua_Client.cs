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
using static App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao.VM_Page_Manutencao_Saidas;

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
            _backgroundTask = Task.Run(() => RunLoop(_cts.Token, "10.10.210.20", 4840, 1000, "opc.tcp://10.10.210.20:4840", 700));
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
            }
            catch (Exception ex)
            {
                // Log se necessário
                System.Diagnostics.Debug.WriteLine($"Erro ao parar o driver: {ex.Message}");
            }
            finally
            {
                _backgroundTask = null;
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

        private async Task RunLoop(CancellationToken token, string Ip, int port, int timeout_Ping_Ip, string urlopcua, int delay_request)
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
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_EntradasSaidas.ImgForceSaiLog_Test"), AttributeId = Attributes.Value },//0
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

                            };

                            List<ReadValueId> nodesToRead_GVL_Energia = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteFaseA"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteFaseB"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteFaseC"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteNeutro"), AttributeId = Attributes.Value },//3
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoAN"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoBN"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoCN"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoAB"), AttributeId = Attributes.Value },//7
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoBC"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoCA"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaAN"), AttributeId = Attributes.Value },//10
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaBN"), AttributeId = Attributes.Value },//11
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaCN"), AttributeId = Attributes.Value },//12
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaAC"), AttributeId = Attributes.Value },//13
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaBC"), AttributeId = Attributes.Value },//14
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoMaximaCA"), AttributeId = Attributes.Value },//15

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fTensaoAvgLL"), AttributeId = Attributes.Value },//16
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fCorrenteAvg"), AttributeId = Attributes.Value },//17
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fPotenciaAtivaTotal"), AttributeId = Attributes.Value },//18
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fEnergiaAtivaAcumulada"), AttributeId = Attributes.Value },//19
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fAtualDemanda"), AttributeId = Attributes.Value },//20
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fPicoDemanda"), AttributeId = Attributes.Value },//21
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fFatorPotenciaTotal"), AttributeId = Attributes.Value },//22
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Energia.fFrequencia"), AttributeId = Attributes.Value },//23
                            };

                            List<ReadValueId> nodesToRead_GVL_ClpIhm = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.wStatusPortaEsq"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.xVacuo01Ok"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.rFrequenciaAtualVentSup"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_ClpIhm.iTermoparSup01"), AttributeId = Attributes.Value },//3
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


                            List<List<OpcWriteItem>> allItemsToWrite = new()
                            {
                                itemsToWrite_GVL_Ihm_Manual,
                                itemsToWrite_GVL_EntradasSaidas
                            };



                            while (!token.IsCancellationRequested)
                            {
                                System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("Error :" + Error));
                                GVL.StatusOpcua.xStatusOpcua = false;
                                if (Error >= 20)
                                {
                                    break;
                                }
                                online = await Ping_Ip.PingHostAsync();

                                if (online)
                                {
                                    try
                                    {
                                        await ReadDataAsync();
                                        await AscribeDataAsync();
                                        await WriteDataAsync();
                                        await Task.Delay(delay_request, token); // Delay controlado
                                        await OpcUaEvents.DispararLeituraFinalizadaAsync();
                                        
                                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Métodos de leitura e escrita finalizados");
                                        GVL.StatusOpcua.xStatusOpcua = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na requisição");
                                        Error = Error++;
                                    }
                                }
                                else
                                {
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




                                    sw.Stop();
                                    System.Diagnostics.Debug.WriteLine("Tempo de Leitura" + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch
                                {
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na leitura do OPC UA");
                                    Error = Error + 1;
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
                                        GVL.Opcua.GVL_Energia.fTensaoAN.Read = (float)results_GVL_Energia[4].Value;
                                    }
                                    if (results_GVL_Energia[5].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoBN.Read = (float)results_GVL_Energia[5].Value;
                                    }
                                    if (results_GVL_Energia[6].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoCN.Read = (float)results_GVL_Energia[6].Value;
                                    }
                                    if (results_GVL_Energia[7].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoAB.Read = (float)results_GVL_Energia[7].Value;
                                    }
                                    if (results_GVL_Energia[8].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoBC.Read = (float)results_GVL_Energia[8].Value;
                                    }
                                    if (results_GVL_Energia[9].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoCA.Read = (float)results_GVL_Energia[9].Value;
                                    }
                                    if (results_GVL_Energia[10].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaAN.Read = (float)results_GVL_Energia[10].Value;
                                    }
                                    if (results_GVL_Energia[11].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaBN.Read = (float)results_GVL_Energia[11].Value;
                                    }
                                    if (results_GVL_Energia[12].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaCN.Read = (float)results_GVL_Energia[12].Value;
                                    }
                                    if (results_GVL_Energia[13].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaAB.Read = (float)results_GVL_Energia[13].Value;
                                    }
                                    if (results_GVL_Energia[14].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaBC.Read = (float)results_GVL_Energia[14].Value;
                                    }
                                    if (results_GVL_Energia[15].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoMaximaCA.Read = (float)results_GVL_Energia[15].Value;
                                    }
                                    if (results_GVL_Energia[16].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fTensaoAvgLL.Read = (float)results_GVL_Energia[16].Value;
                                    }
                                    if (results_GVL_Energia[17].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fCorrenteAvg.Read = (float)results_GVL_Energia[17].Value;
                                    }
                                    if (results_GVL_Energia[18].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fPotenciaAtivaTotal.Read = (float)results_GVL_Energia[18].Value;
                                    }
                                    if (results_GVL_Energia[19].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fEnergiaAtivaAcumulada.Read = (float)results_GVL_Energia[19].Value;
                                    }
                                    if (results_GVL_Energia[20].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fAtualDemanda.Read = (float)results_GVL_Energia[20].Value;
                                    }
                                    if (results_GVL_Energia[21].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fPicoDemanda.Read = (float)results_GVL_Energia[21].Value;
                                    }
                                    if (results_GVL_Energia[22].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fFatorPotenciaTotal.Read = (float)results_GVL_Energia[22].Value;
                                    }
                                    if (results_GVL_Energia[23].Value != null)
                                    {
                                        GVL.Opcua.GVL_Energia.fFrequencia.Read = (float)results_GVL_Energia[23].Value;
                                    }
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




                                    sw.Stop(); 
                                    System.Diagnostics.Debug.WriteLine("Tempo de passagem de valor" + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch(Exception ex)
                                {
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na passagem de valor. " + "Linha: " + ex.StackTrace);
                                    Error = Error + 1;
                                    return;
                                }
                            }
                        }
                        catch
                        {
                            System.Diagnostics.Debug.WriteLine("Inicializando o Driver por Erro 1: " + urlopcua);
                            Error = Error + 1;
                            break;
                        }
                    }
                    else
                    {
                        await Task.Delay(timeout_Ping_Ip, token); // Delay controlado
                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Dispositivo desconectado. O serviço Driver OPCUA Client não será iniciado");
                    }
                }

            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Inicializando o Driver por Erro 2: " + urlopcua);
            }
        }
    }
}
