using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                for (int y = i+1; y < seq.Length; y++)
                {
                    if (seq[i] == seq[y] + diff || seq[i] == seq[y] - diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}
