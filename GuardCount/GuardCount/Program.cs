using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuardCount
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            if (!string.IsNullOrEmpty(StConfig.SecretKey))
            {
                string regCode = HwEncryp.Decode(StConfig.SecretKey);
                DevCommon.IsRegister = MachineGuid.ValidRegCode(regCode);
            }
            Application.Run(new FrmMain());
            //Application.Run(new FrmSerialPortConfig());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            StLog.AddException(e.Exception);
            DevCommon.MsgBox(null, e.Exception.Message);
        }
    }
}
