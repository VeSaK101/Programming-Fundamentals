using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int RightSum = 0;
            string exitIndex = "";

            for (int i = 0; i < seq.Length; i++)
            {
                for (int y = i - 1 ; y >= 0; y--)
                {
                    leftSum += seq[y];
                }
                for (int j = i+1; j < seq.Length; j++)
                {
                    RightSum += seq[j];
                }
                if (leftSum == RightSum)
                {
                    exitIndex = ""+i;
                }
                leftSum = 0; RightSum = 0;
            }
            if (exitIndex == "")
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(exitIndex);
            }
            
        }
    }
}
