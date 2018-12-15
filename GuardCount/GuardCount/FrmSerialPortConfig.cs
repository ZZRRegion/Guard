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
        public ComConfigModel ComConfigModel { get; set; } = ComConfigModel.GetConfigModel();
        public FrmSerialPortConfig()
        {
            InitializeComponent();
        }

        private void FrmSerialPortConfig_Load(object sender, EventArgs e)
        {
            this.LoadPorts();
            this.nudDevNum.Value = this.ComConfigModel.SlaveAddress;
            this.cboBaudRate.Text = this.ComConfigModel.BaudRate.ToString();
            this.cboDataBits.Text = this.ComConfigModel.DataBits.ToString();
            this.cboStopBits.Text = this.ComConfigModel.StopBits.ToString();
            this.cboParity.Text = this.ComConfigModel.Parity;
        }
        /// <summary>
        /// 加载COM端口
        /// </summary>
        private void LoadPorts()
        {
            foreach(string port in SerialPort.GetPortNames())
            {
                this.cboPort.Items.Add(port);
                if(this.ComConfigModel.PortName == port)
                {
                    this.cboPort.SelectedItem = port;
                }
            }
            if (this.cboPort.SelectedIndex == -1)
                this.cboPort.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ComConfigModel.PortName = this.cboPort.SelectedItem as string;
            this.ComConfigModel.BaudRate = int.Parse(this.cboBaudRate.SelectedItem.ToString());
            this.ComConfigModel.DataBits = int.Parse(this.cboDataBits.SelectedItem.ToString());
            this.ComConfigModel.Parity = this.cboParity.SelectedItem.ToString();
            this.ComConfigModel.SlaveAddress = (byte)this.nudDevNum.Value;
            this.ComConfigModel.StopBits = int.Parse(this.cboStopBits.SelectedItem.ToString());
            this.ComConfigModel.SaveConfig();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
