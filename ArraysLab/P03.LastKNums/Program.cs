using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.LastKNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;


            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                var start = Math.Max(0, i - k);

                for (int y = start; y <= i - 1; y++)
                {
                    sum += sequence[y];
                }

                sequence[i] = sum;
            }
            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
