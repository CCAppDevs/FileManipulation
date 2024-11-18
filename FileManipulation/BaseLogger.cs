using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public abstract class BaseLogger : ILogger
    {
        private string Identifier { get; set; }

        public BaseLogger(string id)
        {
            Identifier = id;
        }

        public virtual void Error(string message)
        {
            Console.WriteLine($"{ Identifier } - Error - { message }");
            OnLog($"{Identifier} - Error - {message}");
        }

        public virtual void Log(string message)
        {
            Console.WriteLine($"{Identifier} - Log - {message}");
            OnLog($"{Identifier} - Error - {message}");
        }

        public abstract void OnLog(string message);
    }
}
