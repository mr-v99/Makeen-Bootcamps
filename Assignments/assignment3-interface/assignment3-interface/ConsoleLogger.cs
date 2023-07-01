using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_interface
{
    internal class ConsoleLogger : Logger
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
