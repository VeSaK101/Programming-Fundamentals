using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var secontInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point firstPoint = new Point(firstInput[0],firstInput[1]);
            Point secondPoint = new Point(secontInput[0],secontInput[1]);

            Circle firstCircle = new Circle(firstInput[2],firstPoint);
            Circle secondCircle = new Circle(secontInput[2],secondPoint);

            if (Circle.IsIntersected(firstCircle,secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public  Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double Distance(Point p1 , Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X,2) + Math.Pow(p1.Y - p2.Y,2));
        }
    }

    class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }

        public Circle(double radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public static bool IsIntersected (Circle c1, Circle c2) 
        {
            if (c1.Radius+c2.Radius >= Point.Distance(c1.Center,c2.Center))
            {
                return true;
            }

            return false;
        }
    }
}
