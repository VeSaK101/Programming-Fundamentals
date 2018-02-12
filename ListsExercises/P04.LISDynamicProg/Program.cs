using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.LISDynamicProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var subsequences = new string[inputNums.Count];
            for (int i = 0; i < subsequences.Length; i++)
            {
                subsequences[i] = "0";
            }

            subsequences[0] = Convert.ToString(inputNums[0]);

            for (int i = 1; i < inputNums.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((inputNums[j] < inputNums[i]) && (subsequences[i].Length < subsequences[j].Length + 1))
                    {
                        subsequences[i] = subsequences[j] + " " + inputNums[i];

                    }
                    else if (j == 0)
                    {
                        subsequences[i] = Convert.ToString(inputNums[i]);
                    }
                }
            }
            var count = 0;
            string longest = "";

            for (int index = 0; index < subsequences.Length; index++)
            {
                var counter = subsequences[index].Split(' ').Select(int.Parse).ToList();
                if (counter.Count > count)
                {
                    count = counter.Count;
                    longest = string.Join(" ", counter);
                }
            }

            Console.WriteLine(longest);
        }
    }
}
