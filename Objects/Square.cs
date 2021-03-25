using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    public class Square : Object2D
    {
        public double x { get; private set; }
        public Square(double a)
        {
            x = a;
        }

        public override double Area()
        {
            return Math.Pow(x,2);
        }
        public override String ToString()
        {
            return string.Format("Square:\na = {0}\nArea = {1}", x, Area());
        }
    }
}
