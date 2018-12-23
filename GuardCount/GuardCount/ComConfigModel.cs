using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;

namespace GuardCount
{
    /// <summary>
    /// COM配置
    /// </summary>
    public class ComConfigModel
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public Parity ComParity
        {
            get
            {
                switch (this.Parity)
                {
                    case "None":
                        return System.IO.Ports.Parity.None;
                    case "Odd":
                        return System.IO.Ports.Parity.Odd;
                    case "Even":
                        return System.IO.Ports.Parity.Even;
                    default:
                        return System.IO.Ports.Parity.None;
                }
            }
        }
        public string Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits ComStopBits
        {
            get
            {
                switch (this.StopBits)
                {
                    case 1:
                        return System.IO.Ports.StopBits.One;
                    case 2:
                        return System.IO.Ports.StopBits.Two;
                    default:
                        return System.IO.Ports.StopBits.Two;
                }
            }
        }
        public int StopBits { get; set; }
        public byte SlaveAddress { get; set; }
        private static string configFile => "AddressConfig.xml";
        public static ComConfigModel GetConfigModel()
        {
            XDocument doc = XDocument.Load(configFile);
            ComConfigModel comConfigModel = new ComConfigModel();
            comConfigModel.BaudRate = doc.Root.GetAttr<int>(nameof(BaudRate));
            comConfigModel.DataBits = doc.Root.GetAttr<int>(nameof(DataBits));
            comConfigModel.Parity = doc.Root.GetAttr<string>(nameof(Parity));
            comConfigModel.PortName = doc.Root.GetAttr<string>(nameof(PortName));
            comConfigModel.SlaveAddress = doc.Root.GetAttr<byte>(nameof(SlaveAddress));
            comConfigModel.StopBits = doc.Root.GetAttr<int>(nameof(StopBits));
            return comConfigModel;
        }
        public void SaveConfig()
        {
            XDocument doc = XDocument.Load(configFile);
            doc.Root.SetAttributeValue(nameof(PortName), this.PortName);
            doc.Root.SetAttributeValue(nameof(BaudRate), this.BaudRate);
            doc.Root.SetAttributeValue(nameof(Parity), this.Parity);
            doc.Root.SetAttributeValue(nameof(DataBits), this.DataBits);
            doc.Root.SetAttributeValue(nameof(StopBits), this.StopBits);
            doc.Root.SetAttributeValue(nameof(SlaveAddress), this.SlaveAddress);
            doc.Save(configFile);
        }
    }
}
