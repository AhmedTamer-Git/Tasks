using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    abstract class Shape
    {

        #region Special for D7
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
        public abstract double CalculateArea();
        #endregion
        
        
        
        public abstract double GetArea();

        public virtual void Display()
        {
            Console.WriteLine("Displaying shape...");
        }

    }
}
