using System;
using System.Management;
using System.Security.Cryptography;
using System.Security;
using System.Collections;
using System.Text;
using Microsoft.Win32;
using System.IO;

namespace GuardCount
{
    /// <summary>
    /// Generates a 16 byte Unique Identification code of a computer
    /// Example: 4876-8DB5-EE85-69D3-FE52-8CF7-395D-2EA9
    /// </summary>
    public class MachineGuid
    {
        private static string fingerPrint = string.Empty;

        /// <summary>
        /// 完整的32位的唯一编码，一般不用
        /// </summary>
        public static string Guid
        {
            get
            {
                if (string.IsNullOrEmpty(fingerPrint))
                {
                    //    fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " +
                    //biosId() + "\nBASE >> " + baseId()
                    //                + "\nDISK >> " + diskId() + "\nVIDEO >> " +
                    //videoId() + "\nMAC >> " + macId()
                    //                         );
                    fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " +
                    biosId() + "\nBASE >> " + baseId());
                }
                return fingerPrint;
            }
        }

        /// <summary>
        /// 纯数字的更短些的机器码，用于注册
        /// </summary>
        public static string MachineCode
        {
            get
            {
                return MakeOnlyNumberCode(Guid);
            }
        }

        //去除空格的，用于云服务的
        public static string MachineCodeForHwCloud
        {
            get
            {
                return MachineCode.Replace(" ", "");
            }
        }

        private static string MakeOnlyNumberCode(string v)
        {
            string result = "";
            int index = 0;
            foreach (char c in v)
            {
                index++;
                var x = c;
                switch (c)
                {
                    case 'A':
                        x = '0';
                        break;
                    case 'B':
                        x = '1';
                        break;
                    case 'C':
                        x = '2';
                        break;
                    case 'D':
                        x = '3';
                        break;
                    case 'E':
                        x = '4';
                        break;
                    case 'F':
                        x = '5';
                        break;
                    case '-':
                        index = 0;
                        break;
                }
                if (index != 3 && index != 0)
                    result += x.ToString();
            }
            //if (result != "") result += "-";
            //result += calcRes.ToString();
            index = 0;
            string formatRes = null;
            foreach (var c in result)
            {
                if (index == 4)
                {
                    formatRes += " ";
                    index = 0;
                }
                formatRes += c.ToString();
                index++;
            }
            return formatRes;
        }

        /// <summary>
        /// 传入注册码，验证是否正确
        /// </summary>
        /// <param name="regCode"></param>
        /// <returns></returns>
        public static bool IsRegistered()
        {
            //注册码的算法是：把MachineCode进行base64编码，然后再进行md5编码，然后与机器码一样转换
            var path = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Haiwell\\Scada\\UserInfo\\user.dat");
            if (File.Exists(path))
            {
                var bytes = System.IO.File.ReadAllBytes(path);
                string regCode = System.Text.Encoding.Default.GetString(bytes);
                if (!string.IsNullOrEmpty(regCode))
                {
                    regCode = HwEncryp.Decode(regCode);
                    return ValidRegCode(regCode);
                }
            }
            return false;
        }

        public static bool WriteRegCode(string regCode)
        {
            regCode = regCode.Replace(" ", "").Replace("　", "");
            var path = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Haiwell\\Scada\\UserInfo\\user.dat");
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            regCode = HwEncryp.Encode(regCode);
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(regCode);
            File.WriteAllBytes(path, byteArray);
            return true;
        }

        public static bool ValidRegCode(string regCode)
        {
            regCode = regCode.Replace(" ", "").Replace("　", "");
            string machineCode = MachineCode.Replace(" ", "").Replace("　", "");
            var base64 = HwEncryp.Encode(machineCode);
            string hash = GetHash(base64);
            string code = MakeOnlyNumberCode(hash);
            return regCode == code.Replace(" ", "").Replace("　", "");
        }

        private static string GetHash(string s)
        {
            MD5 sec = new MD5CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] bt = enc.GetBytes(s);
            return GetHexString(sec.ComputeHash(bt));
        }
        private static string GetHexString(byte[] bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Length; i++)
            {
                byte b = bt[i];
                int n, n1, n2;
                n = (int)b;
                n1 = n & 15;
                n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + (int)'A')).ToString();
                else
                    s += n2.ToString();
                if (n1 > 9)
                    s += ((char)(n1 - 10 + (int)'A')).ToString();
                else
                    s += n1.ToString();
                if ((i + 1) != bt.Length && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }
        #region Original Device ID Getting Code
        //Return a hardware identifier
        private static string identifier
        (string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() == "True")
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            return result;
        }
        //Return a hardware identifier
        private static string identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        if (mo[wmiProperty] != null)
                            result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        private static string cpuId()
        {
            //Uses first CPU identifier available in order of preference
            //Don"t get all identifiers, as it is very time consuming
            string retVal = identifier("Win32_Processor", "UniqueId");
            if (retVal == "") //If no UniqueID, use ProcessorID
            {
                retVal = identifier("Win32_Processor", "ProcessorId");
                if (retVal == "") //If no ProcessorId, use Name
                {
                    retVal = identifier("Win32_Processor", "Name");
                    if (retVal == "") //If no Name, use Manufacturer
                    {
                        retVal = identifier("Win32_Processor", "Manufacturer");
                    }
                    //Add clock speed for extra security
                    retVal += identifier("Win32_Processor", "MaxClockSpeed");
                }
            }
            return retVal;
        }
        //BIOS Identifier
        private static string biosId()
        {
            string strBiosId = identifier("Win32_BIOS", "Manufacturer")
            + identifier("Win32_BIOS", "SMBIOSBIOSVersion")
            + identifier("Win32_BIOS", "IdentificationCode")
            + identifier("Win32_BIOS", "SerialNumber")
            + identifier("Win32_BIOS", "ReleaseDate")
            + identifier("Win32_BIOS", "Version");
            return strBiosId;
        }
        //Main physical hard drive ID
        private static string diskId()
        {
            return identifier("Win32_DiskDrive", "Model")
            + identifier("Win32_DiskDrive", "Manufacturer")
            + identifier("Win32_DiskDrive", "Signature")
            + identifier("Win32_DiskDrive", "TotalHeads");
        }
        //Motherboard ID
        private static string baseId()
        {
            string strBaseId = identifier("Win32_BaseBoard", "Model")
            + identifier("Win32_BaseBoard", "Manufacturer")
            + identifier("Win32_BaseBoard", "Name")
            + identifier("Win32_BaseBoard", "SerialNumber");
            return strBaseId;
        }
        //Primary video controller ID
        private static string videoId()
        {
            return identifier("Win32_VideoController", "DriverVersion")
            + identifier("Win32_VideoController", "Name");
        }
        //First enabled network card ID
        private static string macId()
        {
            return identifier("Win32_NetworkAdapterConfiguration",
                "MACAddress", "IPEnabled");
        }
        #endregion
    }
}