using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Opcua.Services.Net.Tools
{
    public partial class TCP_IP
    {
        public class Ping_IP
        {
            private readonly int timeout;
            private readonly string ipAddress;
            private readonly int port;

            public Ping_IP(int timeout, string ipAddress)
            {
                if (string.IsNullOrWhiteSpace(ipAddress))
                    throw new ArgumentException("IP inválido");
                if (timeout < 0)
                    throw new ArgumentOutOfRangeException(nameof(timeout));

                this.timeout = timeout;
                this.ipAddress = ipAddress;

            }

            public Ping_IP(int timeout, string ipAddress, int port)
            {
                if (string.IsNullOrWhiteSpace(ipAddress))
                    throw new ArgumentException("IP inválido");
                if (timeout < 0)
                    throw new ArgumentOutOfRangeException(nameof(timeout));
                if (timeout <= 0)
                    throw new ArgumentOutOfRangeException(nameof(port));

                this.timeout = timeout;
                this.ipAddress = ipAddress;
                this.port = port;
            }

            public async Task<bool> PingHostAsync()
            {
                using Ping ping = new Ping();
                try
                {
                    PingReply reply = await ping.SendPingAsync(ipAddress, timeout);
                    return reply.Status == IPStatus.Success;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
