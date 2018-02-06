using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.SeparateWordsByCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').ToList();
            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();
            var countLow = 0;
            var countUp = 0;

            for (int i = 0; i < input.Count; i++)
            {
                foreach (var pos in input[i])
                {
                    if (pos >= 97 && pos <= 122)
                    {
                        countLow++;
                    }
                    else if (pos >= 65 && pos <= 90)
                    {
                        countUp++;
                    }
                    else
                    {
                        countLow = 1;
                        countUp = 1;
                        break;
                    }
                }
                if (countUp != 0 && countLow != 0)
                {
                    mixedCase.Add(input[i]);
                }
                else if (countLow == 0 && countUp != 0 )
                {
                    upperCase.Add(input[i]);
                }
                else if (countUp == 0 && countLow != 0)
                {
                    lowerCase.Add(input[i]);
                }
                countUp = 0;
                countLow = 0;
            }

            Console.WriteLine("Lower-case: {0}",string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: {0}",string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ",upperCase));
            
        }
    }
}
