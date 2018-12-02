using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardCount
{
    public partial class ButtonSwitch : StUserControl
    {
        public ButtonSwitch(Variable variable, RunCollect run)
            :base(variable, run)
        {
            InitializeComponent();
            this.btnSwitch.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnSwitch.Text = variable.Text;
        }
        public override void SetValue(bool value)
        {
            Action action = () => {
                if (value)
                {
                    this.btnSwitch.BackColor = Color.Red;
                }
                else
                {
                    this.btnSwitch.BackColor = Color.Green;
                }
                this.btnSwitch.Refresh();
            };
            this.Invoke(action);
        }
        private void btnSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            lock (this.Run.LockObj)
            {
                if(this.Run.AllVariable.ContainsKey(this.Id))
                {
                    Variable variable = this.Run.AllVariable[this.Id];
                    if(variable.AddressType == 0)
                    {
                        //variable.BoolValue = true;
                        //this.SetValue(true);
                        if (this.Run.WriteBOOLValue.ContainsKey(this.Id))
                        {
                            this.Run.WriteBOOLValue[this.Id] = true;
                        }
                        else
                        {
                            this.Run.WriteBOOLValue.Add(this.Id, true);
                        }
                    }
                }
            }
        }

        private void btnSwitch_MouseUp(object sender, MouseEventArgs e)
        {
            lock (this.Run.LockObj)
            {
                if (this.Run.AllVariable.ContainsKey(this.Id))
                {
                    Variable variable = this.Run.AllVariable[this.Id];
                    if(variable.AddressType == 0)
                    {
                        //variable.BoolValue = false;
                        //this.SetValue(false);
                        if (this.Run.WriteBOOLValue.ContainsKey(this.Id))
                        {
                            this.Run.WriteBOOLValue[this.Id] = false;
                        }
                        else
                        {
                            this.Run.WriteBOOLValue.Add(this.Id, false);
                        }
                    }
                }
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {

        }
        public override void ResetValue()
        {
            this.SetValue(false);
        }
    }
}
