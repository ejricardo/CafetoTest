using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLogger
{
    public sealed class LogSingle
    {

        private static LogSingle _instance = null;
        private string _path;
        private static object _protect = new object();
        private ILogStrategy _logType;

        public ILogStrategy logType { set { _logType = value; } }

        public static LogSingle GetInstance()
        {
            lock (_protect)
                if (_instance == null)
                    _instance = new LogSingle();
            return _instance;
        }
        public static LogSingle GetInstance(string path)
        {
            lock (_protect)
                if (_instance == null)
                    _instance = new LogSingle(path);
            return _instance;
        }

        private LogSingle(string path)
        {
            _path = path;
        }

        public LogSingle()
        {
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, $"[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "] " + message + Environment.NewLine);
        }

        public static void Print(string message , ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine( $"[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "] " + message + Environment.NewLine);
        }

      
    }
}
