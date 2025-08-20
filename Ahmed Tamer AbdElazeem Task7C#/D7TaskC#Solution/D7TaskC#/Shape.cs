using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7TaskC_
{
    abstract class Shape
    {

        public virtual void Draw() 
        {
            Console.WriteLine("Drawing Shape");
        }
        public abstract double CalculateArea();

    }
}
