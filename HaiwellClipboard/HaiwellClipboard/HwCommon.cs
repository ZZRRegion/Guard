using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HaiwellClipboard
{
    public static class HwCommon
    {
        public static string Md5(string content)
        {
            byte[] bbs = Md5Bytes(content);
            string temp = string.Empty;
            foreach(byte by in bbs)
            {
                temp += by.ToString("x2");
            }
            return temp;
        }
        public static string Md5(Stream stm)
        {
            byte[] bbs = Md5Bytes(stm);
            string temp = string.Empty;
            foreach(byte by in bbs)
            {
                temp += by.ToString("x2");
            }
            return temp;
        }
        public static byte[] Md5Bytes(Stream stm)
        {
            MD5 md5 = MD5.Create();
            byte[] bbs = md5.ComputeHash(stm);
            return bbs;
        }
        public static byte[] Md5Bytes(string content)
        {
            MD5 md5 = MD5.Create();
            byte[] bys = Encoding.UTF8.GetBytes(content);
            return md5.ComputeHash(bys);
        }
    }
}
