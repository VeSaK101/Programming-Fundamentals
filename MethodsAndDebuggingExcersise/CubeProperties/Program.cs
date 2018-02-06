using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            switch (property)
            {
                case "volume": volume(side); break;
                case "area":area(side); break;
                case "space":space(side); break;
                case "face":face(side); break;
                default:
                    break;
            }
            

        }

        private static void volume(double side)
        {
            Console.WriteLine($"{side * side * side:f2}"); 
        }
        private static void area(double side)
        {
            Console.WriteLine($"{6*(side*side):f2}");
        }
        private static void face(double side)
        {
            Console.WriteLine($"{Math.Sqrt(2*(side*side)):f2}");
        }
        private static void space(double side)
        {
            Console.WriteLine($"{Math.Sqrt(3 * (side * side)):f2}");
        }

    }
}
