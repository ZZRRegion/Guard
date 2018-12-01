using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuardCount
{
    public class RunCollect
    {
        public Dictionary<int, Variable> AllVariable { get; set; }
        public Dictionary<int, bool> WriteValue { get; set; }
        public RunCollect()
        {

        }
    }
}
