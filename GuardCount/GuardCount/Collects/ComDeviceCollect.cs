using System;
using System.Collections.Generic;
using System.Text;
using Modbus.Device;
using System.IO.Ports;
using Modbus.IO;
using System.Threading.Tasks;

namespace GuardCount.Collects
{
    public class ComDeviceCollect:DeviceBase
    {
        public ComDeviceCollect()
        {
            SerialPort serialPort = new SerialPort("COM2", 19200, Parity.Even, 8, StopBits.Two);
            serialPort.Open();
            serialPort.ReadTimeout = 300;
            serialPort.WriteTimeout = 300;
            this.Device = ModbusSerialMaster.CreateRtu(new SerialPortAdapter(serialPort));
            //serialPort.Close();
            //this.Device.Dispose();
        }
    }
}
