using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //line 1 points
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var firstLine = LenghtOfLine(x1, y1, x2, y2);
            // line 2 points 
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var secondLine = LenghtOfLine(x3, y3, x4, y4);

            if (firstLine == secondLine)
            {
                CloserToZero(x1, y1, x2, y2);
                FurtherFromZero(x1, y1, x2, y2);
                Console.WriteLine();
            }
            else if (firstLine > secondLine)
            {
                CloserToZero(x1, y1, x2, y2);
                FurtherFromZero(x1, y1, x2, y2);
                Console.WriteLine();
            }
            else if (firstLine < secondLine)
            {
                CloserToZero(x3, y3, x4, y4);
                FurtherFromZero(x3, y3, x4, y4);
                Console.WriteLine();
            }

        }
        static double LenghtOfLine(double x1, double y1, double x2, double y2)
        {
            if (x1 != x2 && y1 != y2)
            {
                var lenght = (Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));

                return lenght;
            }

            else if (x1 == x2)
            {
                var lenght = Math.Abs(y1 - y2);
                return lenght;
            }
            else if (y1 == y2)
            {
                var lenght = Math.Abs(x1 - x2);
                return lenght;
            }
            else
            {
                return 0;
            }
        }
        static void CloserToZero(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
            {
                Console.Write("({0},{1})", x2, y2);
            }

            else if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
            {
                Console.Write("({0},{1})", x1, y1);
            }
            else
            {
                Console.Write("({0},{1})", x1, y1);
            }
        }
        static void FurtherFromZero(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1) + Math.Abs(y1) < Math.Abs(x2) + Math.Abs(y2))
            {
                Console.Write("({0},{1})", x2, y2);
            }

            else if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
            {
                Console.Write("({0},{1})", x1, y1);
            }
            else
            {
                Console.Write("({0},{1})", x1, y1);
            }
        }
    }
}
