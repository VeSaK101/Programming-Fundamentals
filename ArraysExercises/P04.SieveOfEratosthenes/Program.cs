using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int index = 0; index < n + 1; index++)
            {
                primes[index] = true;
            }
            primes[0] = primes[1] = false;

            for (int index = 2; index <= Math.Sqrt(n); index++)
            {
                if (primes[index] == true)
                {
                    for (int i = index * index; i <= n + 1; i += index)
                    {
                        primes[i] = false;
                    }
                }
            }


        }
    }
}
