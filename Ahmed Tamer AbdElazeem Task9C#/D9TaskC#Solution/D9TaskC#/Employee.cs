using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal class Employee 
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Department Dept { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Employee e)
                return this.Id == e.Id && this.Name == e.Name;
            return false;
        }

        public override int GetHashCode()
        { 
          return  (Id, Name).GetHashCode();
        }


    }
}
