﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6TaskC_
{
    internal struct Point
    {
        public int X;
        public int Y;

        // Parameterized Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        // Override ToString
        public override string ToString()
        {
            return $"({X}, {Y})";
        }


        //used in problem4
        public Point(int x)
        {
            X = x;
            Y = 0;
        }

    }
}
