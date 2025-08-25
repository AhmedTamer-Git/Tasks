using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal class Utility
    {
        public static int RectanglePerimeter(int length, int width)
        {
            return 2 * (length + width);
        }

        public static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
        public static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;

    }
}
