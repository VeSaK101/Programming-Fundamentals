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
            bool[] primes = new bool[n+1];
            for (int i = 0; i < n+1; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int p = 0; p <= n; p++)
            {
                if (primes[p] == true)
                {
                    Console.WriteLine(p + " ");
                    for (int i = p; i < n+1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            primes[i] = false;
                        }
                        else if (i % 3 == 0 && i != 3)
                        {
                            primes[i] = false;
                        }
                        else if (i % 5 == 0 && i != 5)
                        {
                            primes[i] = false;
                        }
                        else if (i % 7 == 0 && i !=7)
                        {
                            primes[i] = false;
                        }
                    }
                }
            }
        }
    }
}
