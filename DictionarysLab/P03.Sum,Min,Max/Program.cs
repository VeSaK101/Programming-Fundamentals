using System;
using System.Linq;

namespace P03.Sum_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}",nums.Sum());
            Console.WriteLine("Min = {0}",nums.Min());
            Console.WriteLine("Max = {0}",nums.Max());
            Console.WriteLine("Average = {0}",nums.Average());
        }
    }
}
