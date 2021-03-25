using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    public class Elipse : Object2D
    {
        public double r1 { get; private set; }
        public double r2 { get; private set; }
        public Elipse(double a, double b)
        {
            r1 = a;
            r2 = b;
        }

        public override double Area()
        {
            return Math.PI * r1 * r2;
        }
        public override String ToString()
        {
            return string.Format("Elipse:\nr1 = {0}\nr2 = {1}\nArea = {2}", r1, r2, Area());
        }
    }
}
