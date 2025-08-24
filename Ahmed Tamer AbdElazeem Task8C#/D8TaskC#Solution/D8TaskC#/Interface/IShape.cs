using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal interface IShape
    {
        double Area { get; }
        void Draw();

        void PrintDetails()
        {
            Console.WriteLine($"Shape details  Area: {Area}");
        }
    }

}
