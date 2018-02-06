using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "0 1 1 2 2 3 3".Split(' ').Select(int.Parse).ToArray();

            var start = input[0];
            //int bestStart = input[0];
            var count = 1;
            int bestCount = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (start == input[i]-1)
                {
                    count++;
                    
                  if (count > bestCount)
                  {
                      bestCount = count;
            //          bestStart = start;
                  }
                  start++;
                }
                else
                {
                    start = input[i];
                    count = 1;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{start-bestCount+1+i} ");
            }
        }
    }
}
