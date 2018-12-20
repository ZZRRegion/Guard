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
    public partial class StUserControl : UserControl
    {
        protected Variable CurrentVariable;
        protected RunCollect Run;
        public int Id { get; set; }
        public StUserControl()
        {

        }
        public StUserControl(Variable variable, RunCollect run)
        {
            InitializeComponent();
            this.CurrentVariable = variable;
            this.Run = run;
        }
        public virtual void SetValue(bool value)
        {

        }
        public virtual void SetValue(int value)
        {

        }
        public virtual void ResetValue()
        {

        }
        public virtual void Save()
        {

        }
    }
}
