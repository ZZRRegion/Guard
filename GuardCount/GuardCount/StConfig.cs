using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GuardCount
{
    public static class StConfig
    {
        private static string FileName => "config.json";
        private static void Write(string key, string value)
        {
            string temp = string.Empty;
            JObject json = new JObject();
            if (File.Exists(FileName))
            {
                temp = File.ReadAllText(FileName);
                json = JObject.Parse(temp);
            }
            json[key] = value;
            temp = json.ToString();
            File.WriteAllText(FileName, temp);
        }
        private static T Read<T>(string key, T defaultvalue = default(T))
        {
            if (File.Exists(FileName))
            {
                string temp = File.ReadAllText(FileName);
                if (!string.IsNullOrEmpty(temp))
                {
                    JObject json = JObject.Parse(temp);
                    if(json.Value<T>(key) != null)
                    {
                        T value = json.Value<T>(key);
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                }
            }
            return defaultvalue;
        }
        public static string IPAddress
        {
            get
            {
                return Read<string>(nameof(IPAddress), "192.168.0.25");
            }
            set
            {
                Write(nameof(IPAddress), value);
            }
        }
        public static int Port
        {
            get
            {
                return Read<int>(nameof(Port), 502);
            }
            set
            {
                Write(nameof(Port), value.ToString());
            }
        }
    }
}
