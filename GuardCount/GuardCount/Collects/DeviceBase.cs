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
        protected object locakobj = new object();
        public delegate void ValueChangedEventHandle(Variable variable);
        public event ValueChangedEventHandle ValueChangedEvent;
        public void OnValueChanged(Variable variable)
        {
            this.ValueChangedEvent?.Invoke(variable);
        }
        public Dictionary<int, bool> WriteVar;
        public Dictionary<int, Variable> AllVariable { get; set; }
        public bool IsExit { get; set; }
        public Thread thread;
        public AutoResetEvent AutoResetEvent { get; set; } = new AutoResetEvent(true);
        public ModbusMaster Device { get; set; }
        public void Dispose()
        {
            this.IsExit = true;
            this.AutoResetEvent.WaitOne();
            this.Device?.Dispose();
        }
    }
}
