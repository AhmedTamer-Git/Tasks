using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7TaskC_
{
    internal class Child : Parent
    {
        #region Propertie
        public int Z { get; set; }
        #endregion

        #region Constructor
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
        #endregion

        #region Methods

        //public new int Product()
        //{
        //    return base.Product() * Z;
        //}

        public override int Product()
        {
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        #endregion

    }
}
