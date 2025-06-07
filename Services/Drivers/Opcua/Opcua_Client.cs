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
            _backgroundTask = Task.Run(() => RunLoop(_cts.Token, "192.168.1.100", 4840, 1000, "opc.tcp://192.168.1.100:4840", 700));
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
                                new ReadValueId { NodeId = NodeId.Parse("ns=4;s=|var|AX-324NA0PA1P.Application.GVL_EntradasSaidas.ImgForceSaiLog"), AttributeId = Attributes.Value },//0
                            };

                            var itemsToWrite = new List<OpcWriteItem>()
                            {
   
     
                            };

                            for (int i = 1; i < 16; i++)
                            {
                                int idx = i;
                                itemsToWrite.Add(new OpcWriteItem
                                {
                                    NodeIdString = $"ns=4;s=|var|AX-324NA0PA1P.Application.GVL_EntradasSaidas.ImgForceSaiLog_Test[{idx}]",
                                    GetValue = (index) => GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetWrite(idx),
                                    ClearWriteFlag = (index) => GVL.Opcua.EntradasSaidas.ImgForceSaiLog.ClearWrite(idx)
                                });
                            }



                            RequestHeader requestHeader_GVL_EntradasSaidas = new RequestHeader();
                            double maxAge_GVL_EntradasSaidas = 0;
                            TimestampsToReturn timestampsToReturn_GVL_EntradasSaidas = TimestampsToReturn.Both;
                            DataValueCollection? results_GVL_EntradasSaidas = null;
                            DiagnosticInfoCollection? diagnosticInfos_GVL_EntradasSaidas = null;

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
                                    ReadValueIdCollection nodesToReadCollection_GVL_EntradasSaidas = new ReadValueIdCollection(nodesToRead_GVL_EntradasSaidas);
                                    session.Read(
                                                requestHeader_GVL_EntradasSaidas,
                                                maxAge_GVL_EntradasSaidas,
                                                timestampsToReturn_GVL_EntradasSaidas,
                                                nodesToReadCollection_GVL_EntradasSaidas,
                                                out results_GVL_EntradasSaidas,
                                                out diagnosticInfos_GVL_EntradasSaidas
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


                                bool? aaaaa8 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetWrite(8);
                                bool? aaaaa9 = GVL.Opcua.EntradasSaidas.ImgForceSaiLog.GetWrite(9);
                                GVL.Opcua.EntradasSaidas.ImgForceSaiLog.SetWrite(15, false);
                                

                                try
                                {
                                    Stopwatch sw = Stopwatch.StartNew();

                                    var validItems = new List<OpcWriteItem>();
                                    var nodesToWrite = new WriteValueCollection();

                                    foreach (var item in itemsToWrite)
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
                                    System.Diagnostics.Debug.WriteLine($"Tempo de Escrita - {sw.Elapsed.TotalMilliseconds:F2} ms");
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
