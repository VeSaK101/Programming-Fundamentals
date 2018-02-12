using System;
using System.Linq;
using System.Collections.Generic;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                var comList = command.Split().ToList();
                if (comList[0] == "A")
                {
                    var name = comList[1];
                    var number = comList[2];
                    phonebook[name] = number;
                }
                else if (comList[0] == "S")
                {
                    if (phonebook.Keys.Contains(comList[1]))
                    {
                        foreach (var kvp in phonebook.Where(x => x.Key == comList[1]))
                        {
                            Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",comList[1]);
                    }
                }
                else if (comList[0] == "ListAll")
                {
                    foreach (var kvp in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                    }
                }
                command = Console.ReadLine();

            }

        }
    }
}
