using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    public class Rectangle : Object2D
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public Rectangle(double a, double b)
        {
            x = a;
            y = b;
        }

        public override double Area()
        {
            return x * y;
        }
        public override String ToString()
        {
            Console.WriteLine("Rectangle:\na = {0}\nb = {1}\nArea = {2}", x, y, Area());
        }
    }
}
