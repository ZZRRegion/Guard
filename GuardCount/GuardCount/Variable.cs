using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace GuardCount
{
    public class Variable
    {
        public int Id { get; set; }
        public string DataType { get; set; }
        public string Text { get; set; }
        public byte SlaveAddress { get; set; }
        public bool BoolValue { get; set; }
        public ushort UshortValue { get; set; }
        public ushort Address { get; set; }
        public byte AddressType { get; set; }
        /// <summary>
        /// 变化次数
        /// </summary>
        public int ChangedCount { get; private set; }
        public void AddChangedCount()
        {
            this.ChangedCount++;
        }
        public Variable(XElement item)
        {
            this.Address = item.GetAttrAddress();
            this.Text = item.GetAttrText();
            this.Id = Guid.NewGuid().GetHashCode();
        }
        public static Dictionary<int, Variable> GetConfig()
        {
            string fileName = "AddressConfig.xml";
            if(!File.Exists(fileName))
            {
                throw new Exception("地址配置文件不存在！");
            }
            Dictionary<int, Variable> dict = new Dictionary<int, Variable>();
            XDocument doc = XDocument.Load(fileName);
            foreach(XElement xitems in doc.Root.Nodes())
            {
                foreach(XElement xitem in xitems.Nodes())
                {
                    Variable variable = new Variable(xitem);
                    variable.DataType = xitems.GetAttr<string>(nameof(variable.DataType));
                    variable.SlaveAddress = xitems.GetAttr<byte>(nameof(variable.SlaveAddress), 1);
                    variable.AddressType = xitems.GetAttr<byte>(nameof(variable.AddressType));
                    dict.Add(variable.Id, variable);
                }
            }
            return dict;
        }
    }
}
