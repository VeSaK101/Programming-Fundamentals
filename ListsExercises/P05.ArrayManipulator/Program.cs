using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToList();
            var command = Console.ReadLine();

            command = InstructionReader(nums, command);
        }
        private static string InstructionReader(List<string> nums, string command)
        {
            while (command != "print")
            {
                var commandReader = command.Split(' ').ToList();

                if (commandReader.Contains("add"))
                {
                    nums.Insert(command[1], Convert.ToString(command[2]));
                }
                if (commandReader.Contains("Insert"))
                {
                    nums.Insert(Convert.ToInt32(commandReader[2]), commandReader[1]);
                }
                command = Console.ReadLine();
            }
            return command;
        }
    }
}
