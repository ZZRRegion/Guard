using System;
using System.Collections.Generic;
using System.Text;
using Modbus.Device;
using System.IO.Ports;
using Modbus.IO;
using System.Threading.Tasks;
using System.Threading;

namespace GuardCount.Collects
{
    /// <summary>
    /// COM收集
    /// </summary>
    public class ComDeviceCollect:DeviceBase
    {
        public ComConfigModel ComConfigModel { get; private set; }
        public ComDeviceCollect(string portName, int baudRate, string parity, int dataBits, int stopBits)
        {
            this.ComConfigModel = new ComConfigModel();
            this.ComConfigModel.PortName = portName;
            this.ComConfigModel.BaudRate = baudRate;
            this.ComConfigModel.Parity = parity;
            this.ComConfigModel.DataBits = dataBits;
            this.ComConfigModel.StopBits = stopBits;
           
        }
        public override void Start()
        {
            try
            {
                SerialPort serialPort = new SerialPort(this.ComConfigModel.PortName,
                    this.ComConfigModel.BaudRate, this.ComConfigModel.ComParity,
                    this.ComConfigModel.DataBits, this.ComConfigModel.ComStopBits);
                serialPort.Open();
                serialPort.ReadTimeout = 300;
                serialPort.WriteTimeout = 300;
                this.Device = ModbusSerialMaster.CreateRtu(new SerialPortAdapter(serialPort));
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
    }
}
