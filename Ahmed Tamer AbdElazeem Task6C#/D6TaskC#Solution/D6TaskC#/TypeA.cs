using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6TaskC_
{
    internal class TypeA
    {

        private int F = 1;
        internal int G = 2;
        public int H = 3;

        public void ShowValues()
        {
            Console.WriteLine($"F = {F}, G = {G}, H = {H}");
        }
    }
}
