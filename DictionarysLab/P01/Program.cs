using System;
using System.Collections.Generic;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsToSort = Console.ReadLine().Split().Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();

            foreach (var num in numsToSort)
            {
                if (counts.Keys.Contains(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }
            foreach (var pair in counts)
            {
                Console.WriteLine("{0} -> {1}",pair.Key,pair.Value);
            }

        }
    }
}
