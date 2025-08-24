using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class Rectangle : Shape, IShape
    {

        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        #region Special for D7
        public double Area
        {
            get { return width * height; }
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle ");
        }
        #endregion

        public override double GetArea()
        {
           return   width * height;
        }

        public override void Display()
        {
            Console.WriteLine("Displaying Rectangle");
        }

    }
}
