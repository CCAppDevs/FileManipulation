using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public interface ILogger
    {
        public void Log(string message);
        public void Error(string message);
        public void OnLog(string message);
    }
}
