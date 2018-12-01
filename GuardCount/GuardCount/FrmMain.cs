using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuardCount
{
    public partial class FrmMain : Form
    {
        private Collects.TcpDeviceCollect tcpDevice;
        private Dictionary<int, ReadSwitch> AllSwitch { get; set; } = new Dictionary<int, ReadSwitch>();
        private Dictionary<int, bool> WriteVar = new Dictionary<int, bool>();
        private RunCollect Run { get; set; } = new RunCollect();
        //private Collects.ComDeviceCollect deviceCollect = new Collects.ComDeviceCollect();
        public FrmMain()
        {
            InitializeComponent();
            this.Run.AllVariable = Variable.GetConfig();
            this.LoadSwitch();
        }

        private void TcpDevice_ValueChangedEvent(Variable variable)
        {
            if (this.AllSwitch.ContainsKey(variable.Id))
            {
                this.AllSwitch[variable.Id].SetValue(variable.BoolValue);
            }
        }

        private void LoadSwitch()
        {
            int top = 10;
            int left = 10;
            foreach(KeyValuePair<int, Variable> item in this.Run.AllVariable)
            {
                ReadSwitch readSwitch = new ReadSwitch(item.Value, this.WriteVar);
                this.pnl.Controls.Add(readSwitch);
                readSwitch.Location = new Point(left, top);
                left += readSwitch.Width + 1;
                this.AllSwitch.Add(item.Key, readSwitch);
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.timer1.Start();   
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            FrmTCPConfig frmTCPConfig = new FrmTCPConfig();
            if(frmTCPConfig.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(this.tcpDevice != null)
            {
                this.tcpDevice.ValueChangedEvent -= this.TcpDevice_ValueChangedEvent;
                this.Dispose();
            }
            this.tcpDevice = new Collects.TcpDeviceCollect(StConfig.IPAddress, StConfig.Port);
            this.tcpDevice.AllVariable = this.Run.AllVariable;
            this.tcpDevice.WriteVar = this.WriteVar;
            this.tcpDevice.ValueChangedEvent += this.TcpDevice_ValueChangedEvent;
            this.tcpDevice.Start();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tcpDevice?.Dispose();
        }
    }
}
