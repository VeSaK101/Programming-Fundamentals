using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').ToArray();
            var second = Console.ReadLine().Split(' ').ToArray();
            var count = 0;
            for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
            {
                if (first[i] == second[i] && count == i)
                {
                    count++;
                }
            }

            var count2 = 0;
            first = first.Reverse().ToArray();
            second = second.Reverse().ToArray();
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[i] == second[i] && count2 == i)
                {
                    count2++;
                }
            }
            Console.WriteLine(Math.Max(count,count2));
        }
    }
}
