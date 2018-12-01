using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GuardCount
{
    public partial class FrmTCPConfig : FrmBaseDocument
    {
        public FrmTCPConfig()
        {
            InitializeComponent();
        }

        private void FrmTCPConfig_Load(object sender, EventArgs e)
        {
            this.txtIP.Text = StConfig.IPAddress;
            this.nudPort.Value = StConfig.Port;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            IPAddress ip = null;
            if (!IPAddress.TryParse(this.txtIP.Text, out ip))
            {
                this.MsgBox("IP地址不合法！");
                return;
            }
            StConfig.IPAddress = this.txtIP.Text;
            StConfig.Port = (int)this.nudPort.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
