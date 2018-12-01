using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace GuardCount
{
    public class EvaluateModel
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public EvaluateModel(XElement item)
        {
            this.Text = item.GetAttrText();
            this.Value = item.GetAttr<string>("value");
        }
        public override string ToString()
        {
            return this.Text;
        }
        public static List<EvaluateModel> GetEvaluates()
        {
            List<EvaluateModel> lst = new List<EvaluateModel>();
            XDocument doc = XDocument.Load("Evaluate.xml");
            foreach(XElement xitem in doc.Root.Nodes())
            {
                EvaluateModel evaluateModel = new EvaluateModel(xitem);
                lst.Add(evaluateModel);
            }
            return lst;
        }
    }
}
