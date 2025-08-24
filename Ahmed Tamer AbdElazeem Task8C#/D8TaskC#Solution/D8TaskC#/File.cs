using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading file...");
        }

        public void Write()
        {
            Console.WriteLine("Writing file...");
        }
    }
}
