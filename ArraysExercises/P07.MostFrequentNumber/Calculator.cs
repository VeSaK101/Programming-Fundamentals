using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.MostFrequentNumber
{
    class Calculator
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var isSeen = new int[input.Length];
            int bestCount = 0;
            int bestRecursor = 0;

            for (int i = 0; i < input.Length; i++)
            {
                isSeen[i] = 0;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (isSeen[i] == 0)
                {
                    int count = 0;
                    for (int j = i; j < input.Length; j++)
                    {
                        if (input[j] == input[i])
                        {
                            count += 1;
                            isSeen[j] = 1;
                        }
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestRecursor = i;
                        }
                    }
                }
            }
            Console.WriteLine(input[bestRecursor]);
        }
    }
}
