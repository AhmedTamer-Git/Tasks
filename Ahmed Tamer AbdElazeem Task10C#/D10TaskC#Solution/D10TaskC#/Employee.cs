using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10TaskC_
{
    internal class Employee
    {

        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Salary}";
        }

    }
}
