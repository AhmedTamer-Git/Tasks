using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal class CircleClass
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CircleClass c)
                return Radius == c.Radius && Color == c.Color;
            return false;
        }

        public override int GetHashCode()
        {
            return (Radius, Color).GetHashCode();
        }

    }
}
