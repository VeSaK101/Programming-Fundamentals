using System;
using System.Collections.Generic;
using System.Linq;


namespace P03.SumAdjesentEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            //input = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();


            for (int i = 0; i < nums.Count-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums.Remove(nums[i]);
                    nums[i] *= 2;
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
