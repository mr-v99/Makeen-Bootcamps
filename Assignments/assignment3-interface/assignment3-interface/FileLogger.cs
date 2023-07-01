using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace assignment3_interface
{
    internal class FileLogger : Logger
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
