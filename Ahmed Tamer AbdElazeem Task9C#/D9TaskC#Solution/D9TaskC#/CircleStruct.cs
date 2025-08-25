using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9TaskC_
{
    internal struct CircleStruct
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CircleStruct c)
                return Radius == c.Radius && Color == c.Color;
            return false;
        }


        public static bool operator ==(CircleStruct left, CircleStruct right)
        {
          return   left.Equals(right);
        }
        public static bool operator !=(CircleStruct left, CircleStruct right)
        { 
            return !left.Equals(right);
        }    

        public override int GetHashCode() 
        {
          return  (Radius, Color).GetHashCode();
        }
    
    }
}
