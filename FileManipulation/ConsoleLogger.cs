using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public class ConsoleLogger : BaseLogger
    {
        public ConsoleLogger(string id) : base(id)
        {
        }

        public override void OnLog(string message)
        {
            // intentionaly left blank
        }
    }
}
