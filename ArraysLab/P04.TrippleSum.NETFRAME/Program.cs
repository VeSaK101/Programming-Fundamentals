using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.TrippleSum.NETFRAME
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var isCombo = false;

            for (int i = 0; i <= nums.Length; i++)
            {
                for (int y = i + 1; y < nums.Length; y++)
                {
                    if (nums.Contains(nums[i] + nums[y]))
                    {
                        Console.WriteLine($"{nums[i]} + {nums[y]} == {nums[i] + nums[y]}");
                        isCombo = true;
                    }
                }
                if (i == nums.Length && isCombo == false)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
