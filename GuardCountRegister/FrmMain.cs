using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardCountRegister
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtRegisterCode.Text);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtMachineCode.Text))
            {
                MessageBox.Show("机器码不能为空！");
                return;
            }
            this.txtRegisterCode.Text = GuardCount.MachineGuid.MakeRegisterCode(this.txtMachineCode.Text);
        }
    }
}
