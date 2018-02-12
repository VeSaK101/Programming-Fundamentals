using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.HandsOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
            //reads hands and saves all values
            var draw = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var name = draw[0];
            
            var dealtCards = new List<string>();
            var initialHands = new Dictionary<string, string>();
            while (name != "JOKER")
            {
                draw = draw[1].Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (initialHands.ContainsKey(name) == false)
                {
                    initialHands[name] = "";
                }
                for (int index = 0; index < draw.Count; index++)
                {
                    initialHands[name] += draw[index] + " ";
                }
                draw = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                name = draw[0];
            }
            //removes unwanted values and calculates points
            var refinedHands = new Dictionary<string, int>();
            foreach (var kvp in initialHands)
            {
                var cleanResult = kvp.Value.Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                for (int index = 0; index < cleanResult.Count; index++)
                {
                    var points = PointsPerCard(cleanResult[index]);
                    if (refinedHands.ContainsKey(kvp.Key) == false)
                    {
                        refinedHands[kvp.Key] = 0;
                    }
                    refinedHands[kvp.Key] += points;
                }
            }
            //write
            foreach (var kvp in refinedHands)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }
        //calculates points per single card 
        private static int PointsPerCard(string card)
        {
            var singleChars = new List<string>();
            foreach (var charecter in card)
            {
                singleChars.Add(charecter.ToString());
            }

            int value;
            var isNumber = int.TryParse(singleChars[0], out value);
            int suiteMultiplayer = 1;
            switch (singleChars[singleChars.Count - 1])
            {
                case "S": suiteMultiplayer = 4; break;
                case "H": suiteMultiplayer = 3; break;
                case "D": suiteMultiplayer = 2; break;
                case "C": suiteMultiplayer = 1; break;
                default:
                    break;
            }
            int pointsPerCard;
            if (isNumber && value != 1)
            {
                return pointsPerCard = value * suiteMultiplayer;
            }
            else
            {
                switch (singleChars[0])
                {
                    case "J": value = 11; break;
                    case "Q": value = 12; break;
                    case "K": value = 13; break;
                    case "A": value = 14; break;
                    case "1": value = 10; break;
                    default:
                        break;
                }
                return pointsPerCard = value * suiteMultiplayer;
            }
        }
    }
}
