using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking as per interface.");
        }

        public void Walk()
        {
            Console.WriteLine("Robot is walking in its own way.");
        }
    }
}
