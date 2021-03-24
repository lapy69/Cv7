using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    public abstract class Object2D : I2D, IComparable
    {
        public abstract double Area();
        public int CompareTo(object obj);
        {
            return 1;
        }
    }
}
