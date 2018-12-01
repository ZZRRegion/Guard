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
            Application.Run(new FrmMain());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            StLog.AddException(e.Exception);
            DevCommon.MsgBox(null, e.Exception.Message);
        }
    }
}
