using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLogger
{
    public class LogToConsole : ILogStrategy
    {
        private ConsoleColor _color;

        public ConsoleColor color { set { _color = value; } }

        public LogToConsole(ConsoleColor color)
        {
            _color = color;
        }
        public void RecordLog(string message) { LogSingle.Print(message, _color); }
    }
}
