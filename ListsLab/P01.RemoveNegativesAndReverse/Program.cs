using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace P01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var resault = new List<int>();

            for (int i = numsList.Count - 1; i >= 0; i--)
            {
                if (numsList[i] < 0)
                {
                    numsList.Remove(numsList[i]);
                }
                else
                {
                    resault.Add(numsList[i]);
                }
            }
            if (resault.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resault));
            }
        }
    }
}
