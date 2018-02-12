using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.ShortWordSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsFromList = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(x => x.Length < 5)
                .OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", wordsFromList));
        }
    }
}
