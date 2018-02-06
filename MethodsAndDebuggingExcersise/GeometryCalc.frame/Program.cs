using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle": CalcTriangleArea(); break;
                case "square": CalcSquareArea(); break;
                case "rectangle": CalcRectangleArea(); break;
                case "circle": CalcCircleArea(); break;
                default:
                    break;
            }
        }
        static void CalcTriangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(a * ha) / 2:f2}");
        }
        static void CalcSquareArea()
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(a * a):f2}");
        }
        static void CalcRectangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(a * b):f2}");
        }
        static void CalcCircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(Math.PI * (r * r)):f2}");
        }
    }
}
