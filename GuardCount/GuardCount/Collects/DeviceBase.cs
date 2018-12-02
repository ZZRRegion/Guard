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
            //Thread thread = new Thread(() => {
                this.ValueChangedEvent?.Invoke(variable);
            //});
            //thread.IsBackground = true;
            //thread.Start();
            DevCommon.WriteLine("变量变更了！" + variable.Text + variable.BoolValue);
        }
        public bool IsExit { get; set; }
        public Thread thread;
        public AutoResetEvent AutoResetEvent { get; set; } = new AutoResetEvent(true);
        public ModbusMaster Device { get; set; }
        public void Dispose()
        {
            this.IsExit = true;
            this.AutoResetEvent.WaitOne(1000);
            this.Device?.Dispose();
        }
    }
}
