using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Net.Tools;
using Opc.Ua.Client;
using Opc.Ua;
using MAUI_Opcua.Services.Communication.Variable;
using Newtonsoft.Json.Linq;

namespace MAUI_Opcua.Services.Drivers.Opcua
{
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
            _backgroundTask = Task.Run(() => RunLoop(_cts.Token, "192.168.1.100", 4840, 1000, "opc.tcp://192.168.1.100:4840", 800));
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
            public string NodeIdString { get; set; }
            public Func<object?> GetValue { get; set; } = () => null!;
            public Action ClearWriteFlag { get; set; } = () => { };
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

                            List<ReadValueId> nodesToRead_GVL_Test = new List<ReadValueId>
                            {
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI0"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI1"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI2"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI3"), AttributeId = Attributes.Value },//3
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI4"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI5"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI6"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI7"), AttributeId = Attributes.Value },//7
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI8"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI9"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI10"), AttributeId = Attributes.Value },//10
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI11"), AttributeId = Attributes.Value },//11
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI12"), AttributeId = Attributes.Value },//12
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI13"), AttributeId = Attributes.Value },//13
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI14"), AttributeId = Attributes.Value },//14
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DI15"), AttributeId = Attributes.Value },//15

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ0"), AttributeId = Attributes.Value },//16
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ1"), AttributeId = Attributes.Value },//17
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ2"), AttributeId = Attributes.Value },//18
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ3"), AttributeId = Attributes.Value },//19
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ4"), AttributeId = Attributes.Value },//20
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ5"), AttributeId = Attributes.Value },//21
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ6"), AttributeId = Attributes.Value },//22
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ7"), AttributeId = Attributes.Value },//23

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ0"), AttributeId = Attributes.Value },//24
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ1"), AttributeId = Attributes.Value },//25
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ2"), AttributeId = Attributes.Value },//26
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ3"), AttributeId = Attributes.Value },//27
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ4"), AttributeId = Attributes.Value },//28
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ5"), AttributeId = Attributes.Value },//29
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ6"), AttributeId = Attributes.Value },//30
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ7"), AttributeId = Attributes.Value },//31

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.iTest"), AttributeId = Attributes.Value },//32
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.rTest"), AttributeId = Attributes.Value },//33
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.sTest"), AttributeId = Attributes.Value },//34
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.iCount"), AttributeId = Attributes.Value },//35
                            };

                            var itemsToWrite = new List<OpcWriteItem>
                            {
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ0",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ0.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ0.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ1",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ1.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ1.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ2",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ2.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ2.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ3",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ3.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ3.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ4",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ4.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ4.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ5",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ5.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ5.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ6",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ6.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ6.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C1_DQ7",
                                    GetValue = () => GVL.Opcua.Test.xC1_DQ7.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC1_DQ7.Write = null
                                },
                                 new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ0",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ0.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ0.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ1",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ1.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ1.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ2",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ2.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ2.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ3",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ3.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ3.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ4",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ4.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ4.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ5",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ5.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ5.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ6",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ6.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ6.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.C2_DQ7",
                                    GetValue = () => GVL.Opcua.Test.xC2_DQ7.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xC2_DQ7.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.sTest",
                                    GetValue = () => GVL.Opcua.Test.sTest.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.sTest.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.iTest",
                                    GetValue = () => GVL.Opcua.Test.iTest.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.iTest.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.rTest",
                                    GetValue = () => GVL.Opcua.Test.rTest.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.rTest.Write = null
                                },
                                

                            };

                            RequestHeader requestHeader_GVL_Test = new RequestHeader();
                            double maxAge_GVL_Test = 0;
                            TimestampsToReturn timestampsToReturn_GVL_Test = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_Test = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_Test = null;

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
                                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Métodos de leitura e escrita finalizados");
                                        GVL.StatusOpcua.xStatusOpcua = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na requisição");
                                        Error = Error + 1;
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
                                    ReadValueIdCollection nodesToReadCollection_GVL_Test = new ReadValueIdCollection(nodesToRead_GVL_Test);
                                    session.Read(
                                                requestHeader_GVL_Test,
                                                maxAge_GVL_Test,
                                                timestampsToReturn_GVL_Test,
                                                nodesToReadCollection_GVL_Test,
                                                out results_GVL_Test,
                                                out diagnosticInfos_GVL_Test
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

                                GVL.Opcua.Test.xC1_DQ2.Write = GVL.Opcua.Test.xC1_DQ2.Read.HasValue ? !GVL.Opcua.Test.xC1_DQ2.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC1_DQ3.Write = GVL.Opcua.Test.xC1_DQ3.Read.HasValue ? !GVL.Opcua.Test.xC1_DQ3.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC1_DQ4.Write = GVL.Opcua.Test.xC1_DQ4.Read.HasValue ? !GVL.Opcua.Test.xC1_DQ4.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC1_DQ5.Write = GVL.Opcua.Test.xC1_DQ5.Read.HasValue ? !GVL.Opcua.Test.xC1_DQ5.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC1_DQ6.Write = GVL.Opcua.Test.xC1_DQ6.Read.HasValue ? !GVL.Opcua.Test.xC1_DQ6.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC1_DQ7.Write = GVL.Opcua.Test.xC1_DQ7.Read.HasValue ? !GVL.Opcua.Test.xC1_DQ7.Read.Value : (bool?)null;

                                GVL.Opcua.Test.xC2_DQ0.Write = GVL.Opcua.Test.xC2_DQ0.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ0.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ1.Write = GVL.Opcua.Test.xC2_DQ1.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ1.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ2.Write = GVL.Opcua.Test.xC2_DQ2.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ2.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ3.Write = GVL.Opcua.Test.xC2_DQ3.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ3.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ4.Write = GVL.Opcua.Test.xC2_DQ4.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ4.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ5.Write = GVL.Opcua.Test.xC2_DQ5.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ5.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ6.Write = GVL.Opcua.Test.xC2_DQ6.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ6.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xC2_DQ7.Write = GVL.Opcua.Test.xC2_DQ7.Read.HasValue ? !GVL.Opcua.Test.xC2_DQ7.Read.Value : (bool?)null;

                                GVL.Opcua.Test.sTest.Write = "Teste";
                                GVL.Opcua.Test.iTest.Write = 112;
                                GVL.Opcua.Test.rTest.Write = (float)222.222;

                                try
                                {
                                    Stopwatch sw = Stopwatch.StartNew();
                                    var nodesToWrite = new WriteValueCollection();
                                    foreach (var item in itemsToWrite)
                                    {
                                        var value = item.GetValue();
                                        if (value != null)
                                        {
                                            nodesToWrite.Add(new WriteValue
                                            {
                                                NodeId = NodeId.Parse(item.NodeIdString),
                                                AttributeId = Attributes.Value,
                                                Value = new DataValue(new Variant(value))
                                            });
                                        }
                                    }
                                    if (nodesToWrite.Count > 0)
                                    {
                                        session.Write(null, nodesToWrite, out StatusCodeCollection results, out DiagnosticInfoCollection diagnosticInfos);
                                        
                                        for (int i = 0; i < nodesToWrite.Count; i++)
                                        {
                                            if (StatusCode.IsGood(results[i]))
                                            {
                                                itemsToWrite[i].ClearWriteFlag();
                                            }
                                            else
                                            {
                                                System.Diagnostics.Debug.WriteLine($"Erro ao escrever {nodesToWrite[i].NodeId}: {results[i]}");
                                            }
                                        }
                                    }
                                    //throw new InvalidOperationException("Erro de operação forçado.");
                                    sw.Stop();
                                    System.Diagnostics.Debug.WriteLine("Tempo de Escrita" + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch
                                {
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na escrita do OPC UA");
                                    Error = Error + 1;
                                    return;
                                }
                            }
                            
                            async Task AscribeDataAsync()
                            {
                                try
                                {
                                    Stopwatch sw = Stopwatch.StartNew();

                                    if ((bool?)results_GVL_Test[0].Value != null) { GVL.Opcua.Test.xC1_DI0.Read = (bool)results_GVL_Test[0].Value; }
                                    if ((bool?)results_GVL_Test[1].Value != null) { GVL.Opcua.Test.xC1_DI1.Read = (bool)results_GVL_Test[1].Value; }
                                    if ((bool?)results_GVL_Test[2].Value != null) { GVL.Opcua.Test.xC1_DI2.Read = (bool)results_GVL_Test[2].Value; }
                                    if ((bool?)results_GVL_Test[3].Value != null) { GVL.Opcua.Test.xC1_DI3.Read = (bool)results_GVL_Test[3].Value; }
                                    if ((bool?)results_GVL_Test[4].Value != null) { GVL.Opcua.Test.xC1_DI4.Read = (bool)results_GVL_Test[4].Value; }
                                    if ((bool?)results_GVL_Test[5].Value != null) { GVL.Opcua.Test.xC1_DI5.Read = (bool)results_GVL_Test[5].Value; }
                                    if ((bool?)results_GVL_Test[6].Value != null) { GVL.Opcua.Test.xC1_DI6.Read = (bool)results_GVL_Test[6].Value; }
                                    if ((bool?)results_GVL_Test[7].Value != null) { GVL.Opcua.Test.xC1_DI7.Read = (bool)results_GVL_Test[7].Value; }
                                    if ((bool?)results_GVL_Test[8].Value != null) { GVL.Opcua.Test.xC1_DI8.Read = (bool)results_GVL_Test[8].Value; }
                                    if ((bool?)results_GVL_Test[9].Value != null) { GVL.Opcua.Test.xC1_DI9.Read = (bool)results_GVL_Test[9].Value; }
                                    if ((bool?)results_GVL_Test[10].Value != null) { GVL.Opcua.Test.xC1_DI10.Read = (bool)results_GVL_Test[10].Value; }
                                    if ((bool?)results_GVL_Test[11].Value != null) { GVL.Opcua.Test.xC1_DI11.Read = (bool)results_GVL_Test[11].Value; }
                                    if ((bool?)results_GVL_Test[12].Value != null) { GVL.Opcua.Test.xC1_DI12.Read = (bool)results_GVL_Test[12].Value; }
                                    if ((bool?)results_GVL_Test[13].Value != null) { GVL.Opcua.Test.xC1_DI13.Read = (bool)results_GVL_Test[13].Value; }
                                    if ((bool?)results_GVL_Test[14].Value != null) { GVL.Opcua.Test.xC1_DI14.Read = (bool)results_GVL_Test[14].Value; }
                                    if ((bool?)results_GVL_Test[15].Value != null) { GVL.Opcua.Test.xC1_DI15.Read = (bool)results_GVL_Test[15].Value; }

                                    if ((bool?)results_GVL_Test[16].Value != null) { GVL.Opcua.Test.xC1_DQ0.Read = (bool)results_GVL_Test[16].Value; }
                                    if ((bool?)results_GVL_Test[17].Value != null) { GVL.Opcua.Test.xC1_DQ1.Read = (bool)results_GVL_Test[17].Value; }
                                    if ((bool?)results_GVL_Test[18].Value != null) { GVL.Opcua.Test.xC1_DQ2.Read = (bool)results_GVL_Test[18].Value; }
                                    if ((bool?)results_GVL_Test[19].Value != null) { GVL.Opcua.Test.xC1_DQ3.Read = (bool)results_GVL_Test[19].Value; }
                                    if ((bool?)results_GVL_Test[20].Value != null) { GVL.Opcua.Test.xC1_DQ4.Read = (bool)results_GVL_Test[20].Value; }
                                    if ((bool?)results_GVL_Test[21].Value != null) { GVL.Opcua.Test.xC1_DQ5.Read = (bool)results_GVL_Test[21].Value; }
                                    if ((bool?)results_GVL_Test[22].Value != null) { GVL.Opcua.Test.xC1_DQ6.Read = (bool)results_GVL_Test[22].Value; }
                                    if ((bool?)results_GVL_Test[23].Value != null) { GVL.Opcua.Test.xC1_DQ7.Read = (bool)results_GVL_Test[23].Value; }

                                    if ((bool?)results_GVL_Test[24].Value != null) { GVL.Opcua.Test.xC2_DQ0.Read = (bool)results_GVL_Test[24].Value; }
                                    if ((bool?)results_GVL_Test[25].Value != null) { GVL.Opcua.Test.xC2_DQ1.Read = (bool)results_GVL_Test[25].Value; }
                                    if ((bool?)results_GVL_Test[26].Value != null) { GVL.Opcua.Test.xC2_DQ2.Read = (bool)results_GVL_Test[26].Value; }
                                    if ((bool?)results_GVL_Test[27].Value != null) { GVL.Opcua.Test.xC2_DQ3.Read = (bool)results_GVL_Test[27].Value; }
                                    if ((bool?)results_GVL_Test[28].Value != null) { GVL.Opcua.Test.xC2_DQ4.Read = (bool)results_GVL_Test[28].Value; }
                                    if ((bool?)results_GVL_Test[29].Value != null) { GVL.Opcua.Test.xC2_DQ5.Read = (bool)results_GVL_Test[29].Value; }
                                    if ((bool?)results_GVL_Test[30].Value != null) { GVL.Opcua.Test.xC2_DQ6.Read = (bool)results_GVL_Test[30].Value; }
                                    if ((bool?)results_GVL_Test[31].Value != null) { GVL.Opcua.Test.xC2_DQ7.Read = (bool)results_GVL_Test[31].Value; }

                                    if ((Int16?)results_GVL_Test[32].Value != null) { GVL.Opcua.Test.iTest.Read = (Int16)results_GVL_Test[32].Value; }
                                    if ((float?)results_GVL_Test[33].Value != null) { GVL.Opcua.Test.rTest.Read = (float)results_GVL_Test[33].Value; }
                                    if ((string?)results_GVL_Test[34].Value != null) { GVL.Opcua.Test.sTest.Read = (string)results_GVL_Test[34].Value; }
                                    if ((Int16?)results_GVL_Test[35].Value != null) { GVL.Opcua.Test.iCount.Read = (Int16)results_GVL_Test[35].Value; }

                                    sw.Stop();
                                    System.Diagnostics.Debug.WriteLine("Tempo de passagem de valor" + " - " + sw.Elapsed.Milliseconds + ":" + sw.Elapsed.Microseconds + ":" + sw.Elapsed.Nanoseconds);
                                }
                                catch
                                {
                                    System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ": Erro na passagem de valor");
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
