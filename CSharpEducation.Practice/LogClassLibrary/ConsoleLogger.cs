using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogClassLibrary
{
    class ConsoleLogger : ILogger
    {
        private string className;
        public string Class { get { return this.className; } set { this.className = value; } }

        public void Trace(string str)
        {
            Log(str, LogLevel.Trace);
        }

        public void Info(string str)
        {
            Log(str, LogLevel.Trace);
        }

        public void Debug(string str)
        {
            Log(str, LogLevel.Trace);
        }

        public void Warning(string str)
        {
            Log(str, LogLevel.Trace);
        }

        public void Error(string str)
        {
            Log(str, LogLevel.Trace);
        }

        public void Fatal(string str)
        {
            Log(str, LogLevel.Trace);
        }
        
        public void Log(string str, LogLevel level)
        {
            Console.WriteLine($"{DateTime.Now} | {Class} | {level} | {str}");
        }

        public ConsoleLogger(string className = "Неизвестно!")
        {
            Class = className;
        }
    }
}
