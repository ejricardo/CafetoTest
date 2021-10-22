using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigLogger;

namespace ModelLogger
{
    public class LogToFile : ILogStrategy
    {
        public void RecordLog(string message) { LogSingle.GetInstance(AssemblySetting.LogPath).Save(message); }
    }
}
