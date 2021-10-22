using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLogger
{
    public class LogContext
    {
        private ILogStrategy _logType;

        public ILogStrategy logType { set { _logType = value; } }
        public LogContext(ILogStrategy logStrategy) { _logType = logStrategy; }

        public void Log(string message) { _logType.RecordLog(message); }
    }
}
