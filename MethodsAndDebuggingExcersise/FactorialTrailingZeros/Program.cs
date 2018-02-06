using System;
using System.Numerics;

namespace FactorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            FactorialCalc(n);
            BigInteger factorial = FactorialCalc(n);
            Console.WriteLine(CalcTrailingZeros(factorial));
        }

        private static int CalcTrailingZeros(BigInteger factorial)
        {

            BigInteger rev = 0;
            BigInteger dig;
            int count = 0;
            while (factorial > 0)
            {
                dig = factorial % 10;
                rev = rev * 10 + dig;
                factorial = factorial / 10;
                if (dig == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
            
        }

        private static BigInteger FactorialCalc(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
