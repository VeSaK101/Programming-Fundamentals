using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.ReverseDecimals
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            nums.Sort();
            Console.Write(string.Join(" <= ",nums));
            Console.WriteLine();
        }
    }
}
