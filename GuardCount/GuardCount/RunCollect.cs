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
        public object LockObj = new object();
        public Dictionary<int, Variable> AllVariable { get; set; }
        public Dictionary<int, bool> WriteBOOLValue { get; set; } = new Dictionary<int, bool>();
        public Dictionary<int, ushort> WriteUshorValue { get; set; } = new Dictionary<int, ushort>();
        /// <summary>
        /// 连续报警次数
        /// </summary>
        public ushort AlarmCount { get; set; }
        public Variable AlarmOutput { get; set; }
        public RunCollect()
        {

        }
    }
}
