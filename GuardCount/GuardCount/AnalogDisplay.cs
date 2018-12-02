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
    public partial class AnalogDisplay : StUserControl
    {
        public AnalogDisplay(Variable variable, RunCollect run)
            :base(variable, run)
        {
            InitializeComponent();
            this.lblMemo.Text = variable.Text;
        }
        public override void SetValue(int value)
        {
            Action action = () => {
                this.txtCount.Text = value.ToString();
            };
            this.Invoke(action);
        }
        public override void ResetValue()
        {
            this.SetValue(0);
        }
    }
}
