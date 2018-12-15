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
        private Collects.DeviceBase device;
        private Dictionary<int, StUserControl> AllSwitch { get; set; } = new Dictionary<int, StUserControl>();
        private RunCollect Run { get; set; } = new RunCollect();
        public FrmMain()
        {
            InitializeComponent();
            this.Text += $" [V{DevCommon.Version},{DevCommon.VersionTime}]";
            this.Run.AllVariable = Variable.GetConfig();
            this.LoadSwitch();
            this.LoadAlarmSelect();
            this.Run.AlarmOutput = this.cboAlarm.SelectedItem as Variable;
            this.pnl.AutoScroll = true;
        }

        private void TcpDevice_ValueChangedEvent(Variable variable)
        {
            switch (variable.AddressType)
            {
                case 0:
                case 1:
                    this.AllSwitch[variable.Id].SetValue(variable.BoolValue);
                    break;
                case 2:
                case 3:
                    switch (variable.DataType)
                    {
                        case "INT":
                            this.AllSwitch[variable.Id].SetValue(variable.IntValue);
                            break;
                        case "USHORT":
                            if(variable.Function == "AlarmCount")
                            {
                                Action action = () => {
                                    this.txtContinuityCount.Text = variable.UshortValue.ToString();
                                    this.Run.AlarmCount = variable.UshortValue;
                                };
                                this.Invoke(action);
                            }else if(variable.Function == "AlarmSelect")
                            {
                                Action action = () => {
                                    if(variable.UshortValue >= 0 && variable.UshortValue < this.cboAlarm.Items.Count)
                                    {
                                        this.cboAlarm.SelectedIndex = variable.UshortValue;
                                    }
                                };
                                this.Invoke(action);
                            }
                            else
                            {
                                this.AllSwitch[variable.Id].SetValue(variable.UshortValue);
                            }
                            break;
                    }
                    break;
            }
        }

        private void LoadSwitch()
        {
            int top = 100;
            int left = 10;
            int analogLeft = 10;
            foreach(KeyValuePair<int, Variable> item in this.Run.AllVariable)
            {
                if (item.Value.Function == "Input")
                {
                    ReadSwitch readSwitch = new ReadSwitch(item.Value, this.Run);
                    this.pnl.Controls.Add(readSwitch);
                    readSwitch.Location = new Point(left, top);
                    left += readSwitch.Width + 1;
                    this.AllSwitch.Add(item.Key, readSwitch);
                }
                else if(item.Value.Function == "Reset")
                {
                    ButtonSwitch buttonSwitch = new ButtonSwitch(item.Value, this.Run);
                    buttonSwitch.Id = item.Value.Id;
                    buttonSwitch.Location = new Point(2, 20);
                    this.pnlSetZero.Controls.Add(buttonSwitch);
                    this.AllSwitch.Add(item.Key, buttonSwitch);
                }else if(item.Value.Function == "ProductionCount")
                {
                    AnalogDisplay analogDisplay = new AnalogDisplay(item.Value, this.Run);
                    this.pnlProduction.Controls.Add(analogDisplay);
                    analogDisplay.Location = new Point(analogLeft, 3);
                    analogLeft += analogDisplay.Width + 1;
                    this.AllSwitch.Add(item.Key, analogDisplay);
                }
            }
        }
        private void LoadIsRegister(bool value)
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl != this.pnlBot)
                {
                    ctl.Enabled = value;
                }
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.LoadIsRegister(DevCommon.IsRegister);
            this.btnRegister.Visible = !DevCommon.IsRegister;
            if (DevCommon.IsRegister)
            {
                this.lblRegisterState.Text = "软件已注册";
            }
            this.lblTime.Text = DateTime.Now.ToString();
            this.timer1.Start();
        }
        private void LoadAlarmSelect()
        {
            foreach(Variable variable in this.Run.AllVariable.Values)
            {
                if(variable.Function == "AlarmOutput")
                {
                    this.cboAlarm.Items.Add(variable);
                }
            }
            if(this.cboAlarm.Items.Count > 0)
            {
                this.cboAlarm.SelectedIndex = 0;
            }
        }
        private void btnPort_Click(object sender, EventArgs e)
        {
            FrmSerialPortConfig frmSerialPortConfig = new FrmSerialPortConfig();
            if(frmSerialPortConfig.ShowDialog(this) == DialogResult.OK)
            {
                this.btnStop_Click(this.btnStop, EventArgs.Empty);
                this.StartCom();
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.lblErrorContent.ResetText();
            this.device = new Collects.TcpDeviceCollect(StConfig.IPAddress, StConfig.Port);
            this.device.Run = this.Run;
            this.device.ValueChangedEvent += this.TcpDevice_ValueChangedEvent;
            this.device.ExceptionMessageEvent += TcpDevice_ExceptionMessageEvent;
            this.device.Start();
            if (this.device.Connected)
            {
                this.btnStop.Enabled = true;
            }
            else
            {
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
            if(this.device != null)
            {
                this.device.ValueChangedEvent -= this.TcpDevice_ValueChangedEvent;
                this.device.ExceptionMessageEvent -= this.TcpDevice_ExceptionMessageEvent;
                this.device.Dispose();
            }
        }
        private void ResetValue()
        {
            lock (this.Run.LockObj)
            {
                this.Run.WriteBOOLValue.Clear();
                this.Run.WriteUshorValue.Clear();
                foreach(Variable variable in this.Run.AllVariable.Values)
                {
                    variable.ResetValue();
                }
            }
            foreach(StUserControl stUserControl in this.AllSwitch.Values)
            {
                stUserControl.ResetValue();
            }
            this.txtContinuityCount.Text = "0";
            this.lblErrorContent.Text = string.Empty;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if(this.device != null)
            {
                this.device.ValueChangedEvent -= this.TcpDevice_ValueChangedEvent;
                this.device.ExceptionMessageEvent -= this.TcpDevice_ExceptionMessageEvent;
                this.device.Dispose();
                this.ResetValue();
            }
            this.btnStop.Enabled = false;
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
        }

        private void btnContinuitySetting_Click(object sender, EventArgs e)
        {
            FrmInputText frmInputText = new FrmInputText();
            frmInputText.Value = this.txtContinuityCount.Text;
            if(frmInputText.ShowDialog(this) == DialogResult.OK)
            {
                ushort value = 0;
                if(ushort.TryParse(frmInputText.Value, out value))
                {
                    foreach (Variable variable in this.Run.AllVariable.Values)
                    {
                        if (variable.Function == "AlarmCount")
                        {
                            lock (this.Run.LockObj)
                            {
                                this.Run.WriteUshorValue.Add(variable.Id, value);
                            }
                        }
                    }
                }
            }
        }

        private void cboAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cboAlarm.SelectedIndex >= 0)
            {
                lock (this.Run.LockObj)
                {
                    foreach(Variable variable in this.Run.AllVariable.Values)
                    {
                        if(variable.Function == "AlarmSelect")
                        {
                            this.Run.WriteUshorValue[variable.Id] = (ushort)this.cboAlarm.SelectedIndex;
                        }
                    }
                    this.Run.AlarmOutput = this.cboAlarm.SelectedItem as Variable;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            if(frmRegister.ShowDialog(this) == DialogResult.OK)
            {
                this.btnRegister.Visible = false;
                this.lblRegisterState.Text = "软件已注册";
                this.LoadIsRegister(DevCommon.IsRegister);
            }
        }
        private void StartNet()
        {
            this.lblErrorContent.ResetText();
            this.device = new Collects.TcpDeviceCollect(StConfig.IPAddress, StConfig.Port);
            this.device.Run = this.Run;
            this.device.ValueChangedEvent += this.TcpDevice_ValueChangedEvent;
            this.device.ExceptionMessageEvent += TcpDevice_ExceptionMessageEvent;
            this.device.Start();
            if (this.device.Connected)
            {
                this.btnStop.Enabled = true;
            }
            else
            {
                this.btnPort.Focus();
            }
        }
        private void StartCom()
        {
            ComConfigModel comConfigModel = ComConfigModel.GetConfigModel();
            this.device = new Collects.ComDeviceCollect(comConfigModel.PortName,
                comConfigModel.BaudRate, comConfigModel.Parity, comConfigModel.DataBits, comConfigModel.StopBits);
            foreach(Variable item in this.Run.AllVariable.Values)
            {
                item.SlaveAddress = comConfigModel.SlaveAddress;
            }
            this.device.Run = this.Run;
            this.device.ValueChangedEvent += this.TcpDevice_ValueChangedEvent;
            this.device.ExceptionMessageEvent += TcpDevice_ExceptionMessageEvent;
            this.device.Start();
            if (this.device.Connected)
            {
                this.btnStop.Enabled = true;
            }
            else
            {
                this.btnPort.Focus();
            }
        }
        private void btnNet_Click(object sender, EventArgs e)
        {
            FrmTCPConfig frmTCPConfig = new FrmTCPConfig();
            if (frmTCPConfig.ShowDialog(this) == DialogResult.OK)
            {
                this.btnStop_Click(this.btnStop, EventArgs.Empty);
                this.StartNet();
            }
        }
    }
}
