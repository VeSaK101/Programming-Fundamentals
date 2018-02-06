using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var len = input.Length;

            if (len == 1)
            {
                Console.WriteLine(input[0]);
            }
            else if (len % 2 == 0)
            {
                Console.WriteLine($"{{ {input[len / 2 - 1]}, {input[len / 2]} }}");
            }
            else if (len % 2 != 0)
            {
                Console.WriteLine($"{{ {input[len / 2 - 1]}, {input[len / 2]}, {input[len / 2 + 1]} }}");

            }
        }
    }
}
