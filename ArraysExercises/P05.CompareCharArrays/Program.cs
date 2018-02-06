using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var row1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var row2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
           // var biggerByLetters = new char[Math.Max(row1.Length,row2.Length)];
            bool AreEqualLetters = true;

            for (int i = 0; i < Math.Min(row1.Length, row2.Length); i++)
            {
                
                if (row1[i] == row2[i])
                {
                    continue;
                }

                else
                {
                    AreEqualLetters = false;
                    if (row1[i] > row2[i])
                    {
                        Console.WriteLine(string.Join("", row2));
                        Console.WriteLine(string.Join("", row1));
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", row1));
                        Console.WriteLine(string.Join("", row2));
                    }
                    break;
                }
            }

            if (AreEqualLetters == true)
            {
                if (row1.Length > row2.Length)
                {
                    Console.WriteLine(string.Join("", row2));
                    Console.WriteLine(string.Join("", row1));
                }
                else if (row1.Length < row2.Length)
                {
                    Console.WriteLine(string.Join("", row1));
                    Console.WriteLine(string.Join("", row2));
                }
                else
                {
                    Console.WriteLine(string.Join("", row1));
                    Console.WriteLine(string.Join("", row1));

                }
            }

        }

        
    }
}
