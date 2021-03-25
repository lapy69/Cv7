using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    public class Circle : Object2D
    {
        public double r { get; private set; }
        public Circle(double a)
        {
            r = a;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(r,2);
        }
        public override string ToString()
        {
            return string.Format("Circle:\nr = {0}\nArea = {1}", r, Area());
        }
    }
}
