using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class ShapeFactory
    {
        public GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    return new Rectangle1 { Dimension1 = dim1, Dimension2 = dim2 };
                case "triangle":
                    return new Triangle { Dimension1 = dim1, Dimension2 = dim2 };
                default:
                    throw new ArgumentException("Unknown shape type");
            }
        }
    }
}
