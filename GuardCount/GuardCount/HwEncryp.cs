using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
namespace GuardCount
{
    /// <summary>
    /// 加密和解密
    /// </summary>
    public class HwEncryp
    {
        /**/
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="key">ASCII 16位</param>
        /// <param name="iv">ASCII 16位</param>
        /// <param name="data">欲加密数据</param>
        /// <returns>返回密文</returns>
        public static string Encode(string data)
        {
            byte[] byKey = Encoding.ASCII.GetBytes("1536223031236991");
            byte[] byIv = Encoding.ASCII.GetBytes("0996321303222950");

            RijndaelManaged rm = new RijndaelManaged();
            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, rm.CreateEncryptor(byKey, byIv), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cst);
            sw.Write(data);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }

        /**/
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="key">ASCII 16位</param>
        /// <param name="iv">ASCII 16位</param>
        /// <param name="data">欲解密数据</param>
        /// <returns>明文</returns>
        public static string Decode(string data)
        {
            byte[] byKey = Encoding.ASCII.GetBytes("1536223031236991");
            byte[] byIv = Encoding.ASCII.GetBytes("0996321303222950");
            byte[] byEnc;
            try
            {
                byEnc = Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }
            RijndaelManaged rm = new RijndaelManaged();
            MemoryStream ms = new MemoryStream(byEnc);

            CryptoStream cst = new CryptoStream(ms, rm.CreateDecryptor(byKey, byIv), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cst);
            return sr.ReadToEnd();
        }
    }
}
