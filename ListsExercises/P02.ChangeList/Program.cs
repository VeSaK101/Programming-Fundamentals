using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToList();
            var command = Console.ReadLine();

            command = InstructionReader(nums, command);
            
           
            var result = nums.Select(int.Parse).ToList();

            if (command == "Odd")
            {
                PrintOddsOrEvens(result,command);
            }
            else
            {
                PrintOddsOrEvens(result, command);
            }

        }

        private static string InstructionReader(List<string> nums, string command)
        {
            while (command != "Odd" && command != "Even")
            {
                var commandReader = command.Split(' ').ToList();

                if (commandReader.Contains("Delete"))
                {
                    nums.RemoveAll(num => num == commandReader[1]);
                }
                if (commandReader.Contains("Insert"))
                {
                    nums.Insert(Convert.ToInt32(commandReader[2]), commandReader[1]);
                }
                command = Console.ReadLine();
            }
            return command;
        }

        private static void PrintOddsOrEvens(List<int> result, string command)
        {
            var moddifier = 2;
            moddifier = command == "Odd" ? moddifier = 0 : moddifier = 1;
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] % 2 == moddifier)
                {
                    result.Remove(result[i]);
                    i -= 1;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
