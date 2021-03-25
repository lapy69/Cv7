using System;
using System.Linq;


namespace Cv6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[] { 1, 5, 3, 7, 9 };
            string[] stringarray = new string[] { "string", "int", "array" };
            Circle[] circlearray = new Circle[] { new Circle(2), new Circle(4) };
            Elipse[] elipsearray = new Elipse[] { new Elipse(2, 6), new Elipse(7, 4) };
            Rectangle[] rectanglearray = new Rectangle[] { new Rectangle(1,2), new Rectangle(4,3)};
            Square[] squarearray = new Square[] { new Square(5), new Square(7) };
            Triangle[] trianglearray = new Triangle[] { new Triangle(5, 2, 3), new Triangle(7, 3, 9) };
            Object2D[] objectarray = new Object2D[] { new Circle(1), new Elipse(2,3), new Rectangle(4,5), new Square(6), new Triangle(7,8,9) };

            Console.WriteLine(Extremes.Highest(intarray));
            Console.WriteLine(Extremes.Lowest(intarray));
            Console.WriteLine(Extremes.Highest(stringarray));
            Console.WriteLine(Extremes.Lowest(stringarray));
            Console.WriteLine(Extremes.Highest(circlearray));
            Console.WriteLine(Extremes.Lowest(circlearray));
            Console.WriteLine(Extremes.Highest(elipsearray));
            Console.WriteLine(Extremes.Lowest(elipsearray));
            Console.WriteLine(Extremes.Highest(rectanglearray));
            Console.WriteLine(Extremes.Lowest(rectanglearray));
            Console.WriteLine(Extremes.Highest(squarearray));
            Console.WriteLine(Extremes.Lowest(squarearray));
            Console.WriteLine(Extremes.Highest(trianglearray));
            Console.WriteLine(Extremes.Lowest(trianglearray));
            Console.WriteLine(Extremes.Highest(objectarray));
            Console.WriteLine(Extremes.Lowest(objectarray));

            var filtered = intarray.Where(v => v > 4 && v < 8);

            Console.Write("Linq filter result: ");
            foreach (int item in filtered)
            {
                Console.Write("{0}, ", item);
            }

            Console.ReadLine();
        }
    }
}
