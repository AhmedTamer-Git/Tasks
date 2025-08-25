using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal class Department
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Department d) return this.Name == d.Name;
            return false;
        }

        public override int GetHashCode()
        { 
          return  Name.GetHashCode();
        }
    }
}
