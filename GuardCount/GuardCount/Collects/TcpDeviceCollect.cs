using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace GuardCount.Collects
{
    public class TcpDeviceCollect:DeviceBase
    {
        private string IpAddress;
        private int Port;
        private TcpClient tcpClient;
        public TcpDeviceCollect(string ipaddress, int port = 502)
        {
            this.IpAddress = ipaddress;
            this.Port = port;
        }
        public override void Start()
        {
            try
            {
                this.tcpClient = new TcpClient();
                tcpClient.Connect(IPAddress.Parse(this.IpAddress), this.Port);
                this.Device = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
                this.thread = new Thread(this.RunNow);
                this.thread.Name = Guid.NewGuid().ToString();
                this.thread.IsBackground = true;
                this.thread.Start();
                this.Connected = true;
            }
            catch (Exception ex)
            {
                this.OnExceptionMessage(ex);
                this.Connected = false;
            }
        }
        /// <summary>
        /// 重连
        /// </summary>
        protected override void Reconnect()
        {
            if (!this.tcpClient.Connected)
            {
                try
                {
                    this.tcpClient.Connect(IPAddress.Parse(this.IpAddress), this.Port);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
