using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if (isPalindrome(i) == true)
                {
                    if (isDevisibleBy7(i))
                    {
                        if (ContainsEvenNum(i) == true)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        private static bool isPalindrome(int i)
        {
            var isPalindrome = false;
            int rev = 0;
            int dig;
            int originalNnum = i; 
            while (i > 0)
            {
                dig = i % 10;
                rev = rev * 10 + dig;
                i = i / 10;
            }
            if (rev == originalNnum)
            {
                isPalindrome = true;
            }
            return isPalindrome;

        }
        private static bool isDevisibleBy7(int i)
        {
            var isDevisible = false;
            int sum = 0;
            int dig;
            
            while (i > 0)
            {
                dig = i % 10;
                sum += dig;
                i = i / 10;
            }
            if (sum % 7 == 0)
            {
                isDevisible = true;
            }
            return isDevisible;
        }
        private static bool ContainsEvenNum(int i)
        {
            var containsEven = false;
            int dig = 1;

            while (i > 0)
            {
                dig = i % 10;
                i = i / 10;
                if (dig % 2 == 0)
                {
                    containsEven = true;
                }
            }
            
            return containsEven;
        }
    }
}
