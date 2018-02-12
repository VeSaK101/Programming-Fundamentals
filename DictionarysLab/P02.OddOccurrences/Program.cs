using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var textToConvert = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            var oddOcurrences = new Dictionary<string,int>();

            foreach (var word in textToConvert)
            {
                if (oddOcurrences.Keys.Contains(word))
                {
                    oddOcurrences[word]++;
                }
                else
                {
                    oddOcurrences[word] = 1;
                }
            }
            var toDelete = new List<string>();
            foreach (var entry in oddOcurrences)
            {
                if (entry.Value % 2 == 0)
                {
                    toDelete.Add(entry.Key);
                }
            }
            foreach (var item in toDelete)
            {
                oddOcurrences.Remove(item);
            }
            Console.WriteLine(string.Join(", ",oddOcurrences.Keys));

        }
    }
}
