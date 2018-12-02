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
        public bool Connected { get; private set; }
        private string IpAddress;
        private int Port;
        private TcpClient tcpClient;
        public TcpDeviceCollect(string ipaddress, int port = 502)
        {
            this.IpAddress = ipaddress;
            this.Port = port;
        }
        public void Start()
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
        private void RunNow()
        {
            this.AutoResetEvent.Reset();
            Variable variable = null;
            while (!this.IsExit)
            {
                try
                {
                    bool isOk = true;
                    lock (this.Run.LockObj)
                    {
                        foreach (KeyValuePair<int, bool> item in this.Run.WriteBOOLValue)
                        {
                            variable = this.Run.AllVariable[item.Key];
                            try
                            {
                                switch (variable.AddressType)
                                {
                                    case 0:
                                        this.Device.WriteSingleCoil(variable.SlaveAddress, variable.Address, item.Value);
                                        break;
                                }
                            }
                            catch(Exception ex)
                            {
                                isOk = false;
                                StLog.AddException(ex);
                                this.OnExceptionMessage(new Exception($"{variable?.Text}写入出错"));
                                this.Reconnect();
                            }
                        }
                        this.Run.WriteBOOLValue.Clear();
                        foreach (KeyValuePair<int, ushort> item in this.Run.WriteUshorValue)
                        {
                            variable = this.Run.AllVariable[item.Key];
                            try
                            {
                                switch (variable.AddressType)
                                {
                                    case 2:
                                        this.Device.WriteSingleRegister(variable.SlaveAddress, variable.Address, item.Value);
                                        break;
                                }
                            }
                            catch(Exception ex)
                            {
                                isOk = false;
                                StLog.AddException(ex);
                                this.OnExceptionMessage(new Exception($"{variable?.Text}写入出错"));
                                this.Reconnect();
                            }
                        }
                        this.Run.WriteUshorValue.Clear();
                    }
                    bool[] bs = null;
                    ushort[] us = null;
                    foreach (KeyValuePair<int, Variable> item in this.Run.AllVariable)
                    {
                        variable = item.Value;
                        try
                        {
                            switch (variable.AddressType)
                            {
                                case 0:
                                    bs = this.Device.ReadCoils(variable.SlaveAddress, variable.Address, 1);
                                    if (variable.BoolValue != bs[0])
                                    {
                                        variable.BoolValue = bs[0];
                                        this.OnValueChanged(variable);
                                    }
                                    break;
                                case 1:
                                    bs = this.Device.ReadInputs(variable.SlaveAddress, variable.Address, 1);
                                    if (variable.BoolValue != bs[0])
                                    {
                                        variable.BoolValue = bs[0];
                                        if(bs[0])
                                        variable.AddChangedCount();
                                        if(variable.ChangedCount == this.Run.AlarmCount)
                                        {
                                            this.Device.WriteSingleCoil(this.Run.AlarmOutput.SlaveAddress, this.Run.AlarmOutput.Address, true);
                                            variable.ResetChangedCount();
                                        }
                                        this.OnValueChanged(variable);
                                    }
                                    break;
                                case 2:
                                    us = this.Device.ReadHoldingRegisters(variable.SlaveAddress, variable.Address, variable.AddressLength);
                                    switch (variable.DataType)
                                    {
                                        case "USHORT":
                                            if (variable.UshortValue != us[0])
                                            {
                                                variable.UshortValue = us[0];
                                                this.OnValueChanged(variable);
                                            }
                                            break;
                                        case "INT":
                                            int value = DevCommon.UShortToInt(us[1], us[0]);
                                            if(variable.IntValue != value)
                                            {
                                                variable.IntValue = value;
                                                this.OnValueChanged(variable);
                                            }
                                            break;
                                    }
                                    break;
                                case 3:
                                    us = this.Device.ReadInputRegisters(variable.SlaveAddress, variable.Address, 1);
                                    switch (variable.DataType)
                                    {
                                        case "USHORT":
                                            if (variable.UshortValue != us[0])
                                            {
                                                variable.UshortValue = us[0];
                                                this.OnValueChanged(variable);
                                            }
                                            break;
                                        case "INT":
                                            int value = DevCommon.UShortToInt(us[1], us[0]);
                                            if (variable.IntValue != value)
                                            {
                                                variable.IntValue = value;
                                                this.OnValueChanged(variable);
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }
                        catch(Exception ex)
                        {
                            isOk = false;
                            StLog.AddException(ex);
                            this.OnExceptionMessage(new Exception($"{variable?.Text}读取出错"));
                            this.Reconnect();
                        }
                    }
                    if (isOk)
                    {
                        this.OnExceptionMessage(new Exception("状态良好！"));
                    }
                }
                catch(Exception ex)
                {
                    StLog.AddException(ex);
                    this.OnExceptionMessage(new Exception($"{variable?.Text}写入出错"));
                    this.Reconnect();
                }
                DevCommon.Sleep(5);
            }
            this.AutoResetEvent.Set();
        }
        /// <summary>
        /// 重连
        /// </summary>
        private void Reconnect()
        {
            if (!this.tcpClient.Connected)
            {
                try
                {
                    this.tcpClient.Connect(IPAddress.Parse(this.IpAddress), this.Port);
                }
                catch(Exception ex)
                {

                }
            }
        }
    }
}
