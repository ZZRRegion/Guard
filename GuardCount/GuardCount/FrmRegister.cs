using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardCount
{
    public partial class FrmRegister : FrmBaseDocument
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.txtMachineCode.Text = MachineGuid.MachineCode;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRegister.Text))
            {
                this.MsgBox("注册码不能为空！");
                return;
            }
            if (MachineGuid.ValidRegCode(this.txtRegister.Text))
            {
                this.MsgBox("注册成功！");
                StConfig.SecretKey = HwEncryp.Encode(this.txtRegister.Text);
                DevCommon.IsRegister = true;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.MsgBox("注册码不正确！");
                return;
            }
        }
    }
}
