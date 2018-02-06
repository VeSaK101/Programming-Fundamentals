using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.RotateArrayAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            var sum = new int[nums.Length];

            for (int y = 0; y < k; y++)
            {
                var temp = new int[nums.Length];
                temp[0] = nums[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    temp[i + 1] = nums[i];
                    
                }
                nums = temp;
                
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] += nums[i];
                }

            }
            Console.WriteLine( string.Join(" ", sum));

        }
    }
}
