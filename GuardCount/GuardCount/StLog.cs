using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GuardCount
{
    public static class StLog
    {
        public static string FileName => "log.txt";
        public static void AddLog(string msg)
        {
            msg += $"{DateTime.Now}{Environment.NewLine}{msg}{Environment.NewLine}";
            File.AppendAllText(FileName, msg);
        }
        public static void AddException(Exception ex)
        {
            string msg = $"{DateTime.Now}{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";
            File.AppendAllText(FileName, msg);
        }
    }
}
