using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class Shapes : IComparable<Shapes>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(Shapes other)
        {
            return this.Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"{Name} - Area: {Area}";
        }
    }
}
