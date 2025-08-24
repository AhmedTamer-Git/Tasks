using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"Default log: {message}");
        }
    }
}
