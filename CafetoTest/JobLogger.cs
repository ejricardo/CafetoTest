using System;
using ModelLogger;

namespace CafetoTest
{
    enum typeMessage
    {
        Message,
        Warnining,
        Error
    }
    public class JobLogger
    {
        public bool logToFile;
        public bool logToConsole;

        private static bool _logToFile;
        private static bool _logToConsole;


        public JobLogger()
        {
            _logToConsole = true;   //set Console as default logger
        }

        public JobLogger SetConsole(bool logToConsole)
        {
            _logToConsole = logToConsole;
            return this;
        }

        public JobLogger SetFileText(bool logToFile)
        {
            _logToFile = logToFile;
            return this;
        }

        public static void LogMessage(string message)
        {
            SetMessage(" Message " + message, ConsoleColor.White);
        }

        public static void LogWarning(string message)
        {
            SetMessage(" Warning " + message, ConsoleColor.Yellow);
        }

        public static void LogError(string message)
        {
            SetMessage(" Error " + message, ConsoleColor.Red);
        }

        private static void SetMessage(string message, ConsoleColor color)
        {

            LogContext _obj;

            if (_logToConsole)
            {
                _obj = new LogContext(new LogToConsole(color));
                _obj.Log(message);
            }
            if (_logToFile)
            {
                _obj = new LogContext(new LogToFile());
                _obj.Log(message);
            }
        }
    }
}
