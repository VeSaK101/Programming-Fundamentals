using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.ReverseStringArray
{
    class Program
    {
        static void Main()
        {
            var sybols = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = sybols.Length - 1 ; i >= 0; i--)
            {
                Console.Write(sybols[i] + " ");
            }
        }
    }
}
