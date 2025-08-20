using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7TaskC_
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Methods
        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        #endregion
    }
}
