using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuardCount
{
    /// <summary>
    /// 运行数据收集
    /// </summary>
    public class RunCollect
    {
        /// <summary>
        /// 线程同步锁
        /// </summary>
        public object LockObj = new object();
        /// <summary>
        /// 所有变量
        /// </summary>
        public Dictionary<int, Variable> AllVariable { get; set; }
        /// <summary>
        /// 写开关量
        /// </summary>
        public Dictionary<int, bool> WriteBOOLValue { get; set; } = new Dictionary<int, bool>();
        /// <summary>
        /// 写模拟量
        /// </summary>
        public Dictionary<int, ushort> WriteUshorValue { get; set; } = new Dictionary<int, ushort>();
        /// <summary>
        /// 连续报警次数
        /// </summary>
        public ushort AlarmCount { get; set; }
        /// <summary>
        /// 报警输出变量
        /// </summary>
        public Variable AlarmOutput { get; set; }
        public RunCollect()
        {

        }
    }
}
