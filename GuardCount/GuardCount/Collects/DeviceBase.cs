using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modbus.Device;
using System.Threading;

namespace GuardCount.Collects
{
    public abstract class DeviceBase:IDisposable
    {
        /// <summary>
        /// 连接状态
        /// </summary>
        public bool Connected { get; protected set; }
        public RunCollect Run { get; set; }
        public delegate void ValueChangedEventHandle(Variable variable);
        public event ValueChangedEventHandle ValueChangedEvent;
        public delegate void ExceptionMessageEventHandle(Exception ex);
        public event ExceptionMessageEventHandle ExceptionMessageEvent;
        public void OnExceptionMessage(Exception ex)
        {
            this.ExceptionMessageEvent?.Invoke(ex);
        }
        public void OnValueChanged(Variable variable)
        {
            this.ValueChangedEvent?.Invoke(variable);
            DevCommon.WriteLine("变量变更了！" + variable.Text + variable.BoolValue);
        }
        public bool IsExit { get; set; }
        public Thread thread { get; protected set; }
        public AutoResetEvent AutoResetEvent { get; set; } = new AutoResetEvent(true);
        public ModbusMaster Device { get; set; }
        protected void RunNow()
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
                            catch (Exception ex)
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
                            catch (Exception ex)
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
                                        if (bs[0])
                                            variable.AddChangedCount();
                                        if (variable.ChangedCount == this.Run.AlarmCount)
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
                                            if (variable.IntValue != value)
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
                        catch (Exception ex)
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
                catch (Exception ex)
                {
                    StLog.AddException(ex);
                    this.OnExceptionMessage(new Exception($"{variable?.Text}写入出错"));
                    this.Reconnect();
                }
                DevCommon.Sleep(5);
            }
            this.AutoResetEvent.Set();
        }
        public virtual void Start()
        {
            
        }
        /// <summary>
        /// 重连
        /// </summary>
        protected virtual void Reconnect()
        {
            
        }
        public virtual void Dispose()
        {
            this.IsExit = true;
            this.AutoResetEvent.WaitOne(1000);
            this.Device?.Dispose();
        }
    }
}
