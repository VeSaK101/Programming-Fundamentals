using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.LISDynamicProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = "0 10 20 30 30 40 1 50 2 3 4 5 6".Split(' ').Select(int.Parse).ToList();

            var subsequences = new string[inputNums.Count];
            for (int i = 0; i < subsequences.Length; i++) {
                subsequences[i] = "0"; }
            
            subsequences[0] = Convert.ToString(inputNums[0]);

            for (int i = 1; i < inputNums.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((inputNums[j] < inputNums[i]) && (subsequences[i].Length < subsequences[j].Length+1))
                    {
                        subsequences[i] = subsequences[j] +" "+inputNums[i];

                    }
                }
            }
        }
    }
}
