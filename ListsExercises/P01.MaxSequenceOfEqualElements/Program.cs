using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var bestStart = nums[0];
            var bestCount = 1;
            var count = 1;

            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)
                {
                    break;
                }

                while (nums[i] == nums[i + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestStart = nums[i];
                    }
                    i++;
                    if (i == nums.Count - 1)
                    {
                        break;
                    }
                }
                count = 1;
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
