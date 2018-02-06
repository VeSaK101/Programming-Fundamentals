using System;
using System.Linq;
using System.Collections.Generic;



namespace P03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specialNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = specialNums[0]; i < nums.Count; i++)
            {
                nums.RemoveAt(i);
                i--;
            }
            for (int i = specialNums[1] - 1; i >= 0; i--)
            {
                nums.RemoveAt(i);
            }
            if (nums.Contains(specialNums[2]))
            {

            }
            string answer = nums.Contains(specialNums[2]) ? answer = "Yes!" : "No!";

            Console.WriteLine(answer);
        }
    }
}
