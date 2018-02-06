using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums =Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new List<double>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
                {
                    result.Add(num);
                }
            }

            result.Sort(((a, b) => b.CompareTo(a)));
            Console.WriteLine(string.Join(" ", result));
            

        }
    }
}
