using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var count = 1;
            var eMail = new Dictionary<string, string>();
            var prevCommand = "";

            while (command != "stop")
            {
                if (count % 2 != 0)
                {
                    prevCommand = command;
                }
                else
                {
                   
                    eMail[prevCommand] = command;
                }
                count++;
                command = Console.ReadLine();
            }

            foreach (var kvp in eMail)
            {
                if (kvp.Value.EndsWith("us") == false && kvp.Value.EndsWith("uk") == false)
                {
                    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
