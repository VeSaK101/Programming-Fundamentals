using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var resultArr = new int[Math.Max(firstArr.Length, secondArr.Length)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(string.Join(" " , resultArr));
        }
    }
}
