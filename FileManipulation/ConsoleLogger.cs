using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public class ConsoleLogger : ILogger
    {
        public string Identifier { get; set; }

        public ConsoleLogger(string id)
        {
            Identifier = id;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{Identifier}] LOG - {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"[{Identifier}] ERROR - {message}");
        }

        public void SetupConsole()
        {

        }
    }
}
