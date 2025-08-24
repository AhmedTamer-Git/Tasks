using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class Circle : Shape , IShape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        #region Special for D7
        public double Area 
        {
            get { return Math.PI * radius * radius; } 
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Circle ");
        }

        //-------------------
        public override double CalculateArea()
        {
            throw new NotImplementedException(); //I Do not use it but shoud implement it ok
        }
        #endregion

        public override double GetArea()
        {
           return Math.PI * radius * radius; 
        }

        public override void Display()
        {
            Console.WriteLine("Displaying Circle");
        }
    }
}
