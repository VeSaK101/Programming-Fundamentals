using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stats = Console.ReadLine().Split('|').ToList();
            var populationCounter = new SortedDictionary<string, SortedDictionary<string, long>>();
            while (!stats[0].Equals("report"))
            {
                var country = stats[1];
                var city = stats[0];
                var popul = int.Parse(stats[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter[country] = new SortedDictionary<string, long>();
                }
                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country][city] = popul;
                }
                else
                {
                    populationCounter[country][city] += popul;
                }
                stats = Console.ReadLine().Split('|').ToList();
            }
            foreach (var country in populationCounter.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var count = 1;
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    if (count == 1)
                    {
                        Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(y => y.Value)})");
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }
                    else
                    {
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }
                    count++;
                }
            }
        }
    }
}
