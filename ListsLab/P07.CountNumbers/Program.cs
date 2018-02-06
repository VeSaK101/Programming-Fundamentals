using System;
using System.Collections.Generic;
using System.Linq;
namespace P07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            nums.Sort();
            var count = 1;

            for (int y = 0; y < nums.Count ; y++)
            {
                if (y < nums.Count-1)
                {
                    while (nums[y] == nums[y + 1])
                    {
                        count++;
                        y++;
                        if (y == nums.Count - 1)
                        {
                            break;
                        }
                    }
                }
               
                Console.WriteLine("{0} -> {1}", nums[y], count);
                count = 1;
            }
        }
    }
}
