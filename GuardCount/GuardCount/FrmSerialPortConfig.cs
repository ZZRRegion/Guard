using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace GuardCount
{
    public partial class FrmSerialPortConfig : FrmBaseDocument
    {
        public FrmSerialPortConfig()
        {
            InitializeComponent();
        }

        private void FrmSerialPortConfig_Load(object sender, EventArgs e)
        {
            this.LoadPorts();
        }
        private void LoadPorts()
        {
            foreach(string port in SerialPort.GetPortNames())
            {
            }
        }
    }
}
