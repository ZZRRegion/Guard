using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GuardCount
{
    public partial class FrmMain : Form
    {
        private Collects.TcpDeviceCollect tcpDevice;
        private Dictionary<int, ReadSwitch> AllSwitch { get; set; } = new Dictionary<int, ReadSwitch>();
        private RunCollect Run { get; set; } = new RunCollect();
        //private Collects.ComDeviceCollect deviceCollect = new Collects.ComDeviceCollect();
        public FrmMain()
        {
            InitializeComponent();
            this.Text += $" [V{DevCommon.Version},{DevCommon.VersionTime}]";
            this.Run.AllVariable = Variable.GetConfig();
            this.LoadSwitch();
            this.pnl.AutoScroll = true;
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
            int top = 100;
            int left = 10;
            foreach(KeyValuePair<int, Variable> item in this.Run.AllVariable)
            {
                if (item.Value.AddressType == 1)
                {
                    ReadSwitch readSwitch = new ReadSwitch(item.Value, this.Run);
                    this.pnl.Controls.Add(readSwitch);
                    readSwitch.Location = new Point(left, top);
                    left += readSwitch.Width + 1;
                    this.AllSwitch.Add(item.Key, readSwitch);
                }
            }
            foreach(KeyValuePair<int, Variable> item in this.Run.AllVariable)
            {
                if (item.Value.Alarm)
                {
                    this.cboAlarm.Items.Add(item.Value);
                }
                if (this.cboAlarm.Items.Count > 0)
                    this.cboAlarm.SelectedIndex = 0;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.txtCountSetting.Text = StConfig.CountSetting.ToString();
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            FrmTCPConfig frmTCPConfig = new FrmTCPConfig();
            if(frmTCPConfig.ShowDialog(this) == DialogResult.OK)
            {
                this.btnStart.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.lblErrorContent.ResetText();
            this.btnStart.Enabled = false;
            this.tcpDevice = new Collects.TcpDeviceCollect(StConfig.IPAddress, StConfig.Port);
            this.tcpDevice.Run = this.Run;
            this.tcpDevice.ValueChangedEvent += this.TcpDevice_ValueChangedEvent;
            this.tcpDevice.ExceptionMessageEvent += TcpDevice_ExceptionMessageEvent;
            this.tcpDevice.Start();
            if (this.tcpDevice.Connected)
            {
                this.btnStop.Enabled = true;
            }
            else
            {
                this.btnStart.Enabled = true;
                this.btnPort.Focus();
            }
        }

        private void TcpDevice_ExceptionMessageEvent(Exception ex)
        {
            try
            {
                Action action = () =>
                {
                    this.lblErrorContent.Text = ex.Message;
                };
                this.Invoke(action);
            }
            finally
            {

            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.tcpDevice != null)
            {
                this.tcpDevice.ValueChangedEvent -= this.TcpDevice_ValueChangedEvent;
                this.tcpDevice.ExceptionMessageEvent -= this.TcpDevice_ExceptionMessageEvent;
                this.tcpDevice.Dispose();
            }
        }

        private void btnCountSetting_Click(object sender, EventArgs e)
        {
            FrmInputText frmInputText = new FrmInputText();
            frmInputText.Value = this.txtCountSetting.Text;
            if(frmInputText.ShowDialog(this) == DialogResult.OK)
            {

                int value = 0;
                if(int.TryParse(frmInputText.Value, out value) && value > 0)
                {
                    this.txtCountSetting.Text = value.ToString();
                    StConfig.CountSetting = value;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(this.tcpDevice != null)
            {
                this.tcpDevice.ValueChangedEvent -= this.TcpDevice_ValueChangedEvent;
                this.tcpDevice.ExceptionMessageEvent -= this.TcpDevice_ExceptionMessageEvent;
                this.tcpDevice.Dispose();
            }
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            this.btnStart.Focus();
        }
    }
}
