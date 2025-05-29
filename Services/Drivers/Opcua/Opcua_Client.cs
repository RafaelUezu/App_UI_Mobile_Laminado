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
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ0"), AttributeId = Attributes.Value },//0
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ1"), AttributeId = Attributes.Value },//1
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ2"), AttributeId = Attributes.Value },//2
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ3"), AttributeId = Attributes.Value },//3
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ4"), AttributeId = Attributes.Value },//4
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ5"), AttributeId = Attributes.Value },//5
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ6"), AttributeId = Attributes.Value },//6
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ7"), AttributeId = Attributes.Value },//7

                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.iTest"), AttributeId = Attributes.Value },//8
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.rTest"), AttributeId = Attributes.Value },//9
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.sTest"), AttributeId = Attributes.Value },//10
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.iCount"), AttributeId = Attributes.Value },//11
                            };

                            var itemsToWrite = new List<OpcWriteItem>
                            {
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ0",
                                    GetValue = () => GVL.Opcua.Test.xDQ0.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ0.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ1",
                                    GetValue = () => GVL.Opcua.Test.xDQ1.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ1.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ2",
                                    GetValue = () => GVL.Opcua.Test.xDQ2.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ2.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ3",
                                    GetValue = () => GVL.Opcua.Test.xDQ3.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ3.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ4",
                                    GetValue = () => GVL.Opcua.Test.xDQ4.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ4.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ5",
                                    GetValue = () => GVL.Opcua.Test.xDQ5.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ5.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ6",
                                    GetValue = () => GVL.Opcua.Test.xDQ6.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ6.Write = null
                                },
                                new OpcWriteItem
                                {
                                    NodeIdString = "ns=4;s=|var|AX-324NA0PA1P.Application.GVL_Test.DQ7",
                                    GetValue = () => GVL.Opcua.Test.xDQ7.Write,
                                    ClearWriteFlag = () => GVL.Opcua.Test.xDQ7.Write = null
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

                                GVL.Opcua.Test.xDQ2.Write = GVL.Opcua.Test.xDQ2.Read.HasValue ? !GVL.Opcua.Test.xDQ2.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xDQ3.Write = GVL.Opcua.Test.xDQ3.Read.HasValue ? !GVL.Opcua.Test.xDQ3.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xDQ4.Write = GVL.Opcua.Test.xDQ4.Read.HasValue ? !GVL.Opcua.Test.xDQ4.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xDQ5.Write = GVL.Opcua.Test.xDQ5.Read.HasValue ? !GVL.Opcua.Test.xDQ5.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xDQ6.Write = GVL.Opcua.Test.xDQ6.Read.HasValue ? !GVL.Opcua.Test.xDQ6.Read.Value : (bool?)null;
                                GVL.Opcua.Test.xDQ7.Write = GVL.Opcua.Test.xDQ7.Read.HasValue ? !GVL.Opcua.Test.xDQ7.Read.Value : (bool?)null;

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
                                    if ((bool?)results_GVL_Test[0].Value != null) { GVL.Opcua.Test.xDQ0.Read = (bool)results_GVL_Test[0].Value; }
                                    if ((bool?)results_GVL_Test[1].Value != null) { GVL.Opcua.Test.xDQ1.Read = (bool)results_GVL_Test[1].Value; }
                                    if ((bool?)results_GVL_Test[2].Value != null) { GVL.Opcua.Test.xDQ2.Read = (bool)results_GVL_Test[2].Value; }
                                    if ((bool?)results_GVL_Test[3].Value != null) { GVL.Opcua.Test.xDQ3.Read = (bool)results_GVL_Test[3].Value; }
                                    if ((bool?)results_GVL_Test[4].Value != null) { GVL.Opcua.Test.xDQ4.Read = (bool)results_GVL_Test[4].Value; }
                                    if ((bool?)results_GVL_Test[5].Value != null) { GVL.Opcua.Test.xDQ5.Read = (bool)results_GVL_Test[5].Value; }
                                    if ((bool?)results_GVL_Test[6].Value != null) { GVL.Opcua.Test.xDQ6.Read = (bool)results_GVL_Test[6].Value; }
                                    if ((bool?)results_GVL_Test[7].Value != null) { GVL.Opcua.Test.xDQ7.Read = (bool)results_GVL_Test[7].Value; }


                                    if ((Int16?)results_GVL_Test[8].Value != null) { GVL.Opcua.Test.iTest.Read = (Int16)results_GVL_Test[8].Value; }
                                    if ((float?)results_GVL_Test[9].Value != null) { GVL.Opcua.Test.rTest.Read = (float)results_GVL_Test[9].Value; }
                                    if ((string?)results_GVL_Test[10].Value != null) { GVL.Opcua.Test.sTest.Read = (string)results_GVL_Test[10].Value; }
                                    if ((Int16?)results_GVL_Test[11].Value != null) { GVL.Opcua.Test.iCount.Read = (Int16)results_GVL_Test[11].Value; }

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
