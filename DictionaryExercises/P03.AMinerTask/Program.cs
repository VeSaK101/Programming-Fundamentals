using System;
using System.Linq;
using System.Collections.Generic;

namespace P03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var count = 1;
            var inventory = new Dictionary<string, int>();
            var prevCommand = "";

            while (command != "stop")
            {
                if (count % 2 != 0)
                {
                    if (inventory.Keys.Contains(command) == false)
                    {
                        inventory.Add(command, 0);
                        prevCommand = command;
                    }
                    else prevCommand = command;
                }
                else
                {
                    var quantity = int.Parse(command);
                    inventory[prevCommand] += quantity;
                }
                count++;
                command = Console.ReadLine();
            }

            foreach (var kvp in inventory)
            {
                Console.WriteLine("{0} -> {1}",kvp.Key,kvp.Value);
            }
        }
    }
}
