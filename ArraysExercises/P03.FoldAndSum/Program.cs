using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstHalfOfRow1 = new int[nums.Length / 4];
            var secondHalfOfRow1 = new int[nums.Length / 4];
            var secondRow = new int[nums.Length / 2];

            for (int i = 0; i < nums.Length / 4; i++)
            {
                firstHalfOfRow1[i] = nums[i];
            }
            Array.Reverse(firstHalfOfRow1);
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = nums[i + firstHalfOfRow1.Length];
            }
            Array.Reverse(nums);
            for (int i = 0; i < nums.Length / 4; i++)
            {
                secondHalfOfRow1[i] = nums[i];
            }
            int[] FirstRow = firstHalfOfRow1.Concat(secondHalfOfRow1).ToArray();
            for (int i = 0; i < FirstRow.Length; i++)
            {
                secondRow[i] += FirstRow[i];
            }
            Console.WriteLine(string.Join(" ",secondRow));



        }
    }
}
