using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Xml.XPath;

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
        public int IntValue { get; set; }
        public ushort Address { get; set; }
        public byte AddressType { get; set; }
        public ushort AddressLength { get; set; }
        public string Function { get; set; }
        /// <summary>
        /// 变化次数
        /// </summary>
        public int ChangedCount { get; private set; }
        public override string ToString()
        {
            return this.Text;
        }
        public void ResetChangedCount()
        {
            this.ChangedCount = 0;
        }
        public void AddChangedCount()
        {
            this.ChangedCount++;
        }
        public void ResetValue()
        {
            this.BoolValue = false;
            this.UshortValue = 0;
            this.IntValue = 0;
            this.ChangedCount = 0;
        }
        public Variable(XElement item)
        {
            this.Address = item.GetAttrAddress();
            this.Text = item.GetAttrText();
            this.Id = Guid.NewGuid().GetHashCode();
        }
        public static string AddressConfig => "AddressConfig.xml";
        public static Dictionary<int, Variable> GetConfig()
        {
            if(!File.Exists(AddressConfig))
            {
                throw new Exception("地址配置文件不存在！");
            }
            Dictionary<int, Variable> dict = new Dictionary<int, Variable>();
            XDocument doc = XDocument.Load(AddressConfig);
            foreach(XElement xitems in doc.Root.XPathSelectElements("//items"))
            {
                foreach(XElement xitem in xitems.Nodes())
                {
                    Variable variable = new Variable(xitem);
                    variable.AddressLength = xitems.GetAttr<ushort>(nameof(AddressLength), 1);
                    variable.Function = xitems.GetAttr<string>(nameof(Function));
                    variable.DataType = xitems.GetAttr<string>(nameof(variable.DataType));
                    variable.SlaveAddress = xitems.GetAttr<byte>(nameof(variable.SlaveAddress), 1);
                    variable.AddressType = xitems.GetAttr<byte>(nameof(variable.AddressType));
                    dict.Add(variable.Id, variable);
                }
            }
            return dict;
        }
        public void SaveIndex(int index)
        {
            XDocument doc = XDocument.Load(AddressConfig);
            XElement xele = doc.Root.XPathSelectElement($".//*[local-name()='items' and @Function='{this.Function}']");
            if(xele != null)
            {
                foreach(XElement xitem in xele.Nodes())
                {
                    ushort address = xitem.GetAttrAddress();
                    if(address == this.Address)
                    {
                        xitem.SetAttributeValue("index", index);
                        break;
                    }
                }
                doc.Save(AddressConfig);
            }
        }
        public int GetIndex()
        {
            XDocument doc = XDocument.Load(AddressConfig);
            XElement xele = doc.Root.XPathSelectElement($"//*[local-name()='items' and @Function='{this.Function}']");
            if (xele != null)
            {
                foreach (XElement xitem in xele.Nodes())
                {
                    ushort address = xitem.GetAttrAddress();
                    if (address == this.Address)
                    {
                        return xitem.GetAttr<int>("index");
                    }
                }
            }
            return 0;
        }
    }
}
