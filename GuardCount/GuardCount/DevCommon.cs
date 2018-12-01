using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;

namespace GuardCount
{
    public static class DevCommon
    {
        public static string Version => "1.0.0.0";
        public static string VersionTime => "2018-11-29 22:31:00";
        public static void MsgBox(this Control @this, string msg)
        {
            MessageBox.Show(@this, msg);
        }
        public static T GetAttr<T>(this XElement @this, string attr, T defaultvalue = default(T))
        {
            XAttribute xattr = @this.Attribute(attr);
            if(xattr != null)
            {
                string value = xattr.Value;
                return (T)Convert.ChangeType(value, typeof(T));
            }
            return defaultvalue;
        }
        public static ushort GetAttrAddress(this XElement @this)
        {
            return @this.GetAttr<ushort>("address");
        }
        public static string GetAttrText(this XElement @this)
        {
            return @this.GetAttr<string>("text");
        }
        /// <summary>
        /// 休眠m毫秒
        /// </summary>
        /// <param name="millisecondsTimeout"></param>
        public static void Sleep(int millisecondsTimeout)
        {
            Thread.Sleep(millisecondsTimeout);
        }
    }
}
