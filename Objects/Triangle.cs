using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    public class Triangle : Object2D
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public double z { get; private set; }

        private double s;
        public Triangle(double a, double b, double c)
        {
            x = a;
            y = b;
            z = c;
            s = (x + y + z) / 2;
    }
        
        public override double Area()
        {
            return Math.Sqrt(s*(s-x)*(s-y)*(s-z));
        }
            
        
        public override String ToString()
        {
            Console.WriteLine("Triangle:\na = {0}\nb = {1}\nc = {2}\nArea = {3}", x, y, z, Area());
        }
    }
}
