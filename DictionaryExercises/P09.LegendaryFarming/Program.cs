using System;
using System.Linq;
using System.Collections.Generic;

namespace P09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            var stash = new SortedDictionary<string, int>();
            var junk = new SortedDictionary<string, int>();
            stash["shards"] = 0;
            stash["fragments"] = 0;
            stash["motes"] = 0;


            while (stash["shards"] < 250 && stash["fragments"] < 250 && stash["motes"] < 250)
            {
                var input = Console.ReadLine().ToLower().Split().ToList();
                for (int i = 1; i < input.Count; i++)
                {
                    if (!junk.ContainsKey(input[i]) && !stash.ContainsKey(input[i]) && i % 2 != 0)
                    {

                        junk[input[i]] = int.Parse(input[i - 1]);
                    }
                    else if (stash.ContainsKey(input[i]) && i % 2 != 0)
                    {
                        stash[input[i]] += int.Parse(input[i - 1]);
                    }
                    var maxVal = stash.FirstOrDefault(x => x.Value == stash.Values.Max()).Value;

                    if (maxVal >= 250)
                    {
                        break;
                    }
                }
            }
            var max = stash.FirstOrDefault(x => x.Value == stash.Values.Max()).Key;
            Console.WriteLine(getLegendary(max) + " obtained!");
            stash[max] -= 250;
            foreach (var item in stash.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var junkItem in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }

        private static string getLegendary(string max)
        {
            if (max == "shards")
            {
                return "Shadowmourne";
            }
            else if (max == "fragments")
            {
                return "Valanyr";
            }
            else
            {
                return "Dragonwrath";
            }
        }
    }
}
