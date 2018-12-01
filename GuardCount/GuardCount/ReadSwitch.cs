using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GuardCount
{
    public partial class ReadSwitch : UserControl
    {
        private Dictionary<int, bool> WriteVar;
        public Variable CurrentVariable { get; private set; }
        public ReadSwitch(Variable variable, Dictionary<int, bool> writeVar)
        {
            InitializeComponent();
            this.CurrentVariable = variable;
            this.lblMemo.Text = variable.Text;
            this.WriteVar = writeVar;
        }

        private void ReadSwitch_Load(object sender, EventArgs e)
        {
            this.SetValue(this.CurrentVariable.BoolValue);
        }
        public void SetValue(bool value)
        {
            this.btnSwitch.BackColor = this.CurrentVariable.BoolValue ? Color.Green : Color.Gray;
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.CurrentVariable.BoolValue = !this.CurrentVariable.BoolValue;
            this.SetValue(this.CurrentVariable.BoolValue);
            if (this.WriteVar.ContainsKey(this.CurrentVariable.Id))
            {
                this.WriteVar[this.CurrentVariable.Id] = this.CurrentVariable.BoolValue;
            }
            else
            {
                this.WriteVar.Add(this.CurrentVariable.Id, this.CurrentVariable.BoolValue);
            }
        }
    }
}
