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
            this.thread = new Thread(this.RunNow);
            this.thread.IsBackground = true;
            this.thread.Start();
        }
        private void RunNow()
        {
            this.AutoResetEvent.Reset();
            while (!this.IsExit)
            {
                try
                {
                    lock (this.Run.LockObj)
                    {
                        foreach (KeyValuePair<int, bool> item in this.Run.WriteBOOLValue)
                        {
                            Variable variable = this.Run.AllVariable[item.Key];
                            switch (variable.AddressType)
                            {
                                case 0:
                                    this.Device.WriteSingleCoil(variable.SlaveAddress, variable.Address, item.Value);
                                    break;
                            }
                        }
                        this.Run.WriteBOOLValue.Clear();
                        foreach (KeyValuePair<int, ushort> item in this.Run.WriteUshorValue)
                        {
                            Variable variable = this.Run.AllVariable[item.Key];
                            switch (variable.AddressType)
                            {
                                case 2:
                                    this.Device.WriteSingleRegister(variable.SlaveAddress, variable.Address, item.Value);
                                    break;
                            }
                        }
                    }
                    bool[] bs = null;
                    ushort[] us = null;
                    foreach (KeyValuePair<int, Variable> item in this.Run.AllVariable)
                    {
                        switch (item.Value.AddressType)
                        {
                            case 0:
                                bs = this.Device.ReadCoils(item.Value.SlaveAddress, item.Value.Address, 1);
                                if (item.Value.BoolValue != bs[0])
                                {
                                    item.Value.BoolValue = bs[0];
                                    item.Value.AddChangedCount();
                                    this.OnValueChanged(item.Value);
                                }
                                break;
                            case 1:
                                bs = this.Device.ReadInputs(item.Value.SlaveAddress, item.Value.Address, 1);
                                if (item.Value.BoolValue != bs[0])
                                {
                                    item.Value.BoolValue = bs[0];
                                    item.Value.AddChangedCount();
                                    this.OnValueChanged(item.Value);
                                }
                                break;
                            case 2:
                                us = this.Device.ReadHoldingRegisters(item.Value.SlaveAddress, item.Value.Address, 1);
                                if (item.Value.UshortValue != us[0])
                                {
                                    item.Value.UshortValue = us[0];
                                    item.Value.AddChangedCount();
                                    this.OnValueChanged(item.Value);
                                }
                                break;
                            case 3:
                                us = this.Device.ReadInputRegisters(item.Value.SlaveAddress, item.Value.Address, 1);
                                if (item.Value.UshortValue != us[0])
                                {
                                    item.Value.UshortValue = us[0];
                                    item.Value.AddChangedCount();
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
