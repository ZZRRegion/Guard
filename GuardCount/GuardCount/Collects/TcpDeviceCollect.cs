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
        public TcpDeviceCollect(string ipaddress, int port = 502)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse(ipaddress), port);
            this.Device = Modbus.Device.ModbusIpMaster.CreateIp(tcpClient);
        }
        public void Start()
        {
            this.thread = new Thread(this.Run);
            this.thread.IsBackground = true;
            this.thread.Start();
        }
        private void Run()
        {
            this.AutoResetEvent.Reset();
            while (!this.IsExit)
            {
                try
                {
                    lock (this.locakobj)
                    {
                        foreach (KeyValuePair<int, bool> item in this.WriteVar)
                        {
                            Variable variable = this.AllVariable[item.Key];
                            switch (variable.AddressType)
                            {
                                case 0:
                                    this.Device.WriteSingleCoil(variable.SlaveAddress, variable.Address, item.Value);
                                    break;
                                case 2:
                                    break;

                            }
                        }
                        this.WriteVar.Clear();
                    }
                    bool[] bs = null;
                    foreach (KeyValuePair<int, Variable> item in this.AllVariable)
                    {
                        switch (item.Value.AddressType)
                        {
                            case 0:
                                bs = this.Device.ReadCoils(item.Value.SlaveAddress, item.Value.Address, 1);
                                if (item.Value.BoolValue != bs[0])
                                {
                                    item.Value.BoolValue = bs[0];
                                    item.Value.ChangedCount++;
                                    this.OnValueChanged(item.Value);
                                }
                                break;
                            case 1:
                                bs = this.Device.ReadInputs(item.Value.SlaveAddress, item.Value.Address, 1);
                                if (item.Value.BoolValue != bs[0])
                                {
                                    item.Value.BoolValue = bs[0];
                                    item.Value.ChangedCount++;
                                    this.OnValueChanged(item.Value);
                                }
                                break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    StLog.AddException(ex);
                }
                DevCommon.Sleep(10);
            }
            this.AutoResetEvent.Set();
        }
    }
}
