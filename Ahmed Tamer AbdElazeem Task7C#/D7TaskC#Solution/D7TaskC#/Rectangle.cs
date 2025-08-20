using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7TaskC_
{
    internal class Rectangle : Shape
    {
        #region Properties
        public double Width { get; set; }
        public double Height { get; set; }
        #endregion

        #region Constructor
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }
        #endregion

        #region Methods
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
        #endregion

    }
}
