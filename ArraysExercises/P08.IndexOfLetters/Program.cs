using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            var len = alphabet.Length;
            for (int i = 0; i < len; i++)
            {
                alphabet[i] = (char)(i+97);
            }
            string word = Console.ReadLine();

            var wordArray = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int y = 0; y < len; y++)
                {
                    if (word[i] == alphabet[y])
                    {
                        Console.WriteLine(word[i]+" -> "+y);
                    }
                }
            }
        }
    }
}
