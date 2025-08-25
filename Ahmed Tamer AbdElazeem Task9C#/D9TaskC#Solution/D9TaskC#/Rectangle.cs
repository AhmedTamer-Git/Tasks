using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
           return $"L={Length}, W={Width}";
        }
    }
}
