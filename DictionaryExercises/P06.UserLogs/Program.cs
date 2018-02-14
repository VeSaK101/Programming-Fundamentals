using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var usageLog = new SortedDictionary<string, Dictionary<string, int>>();
            while (!command[0].Equals("end"))
            {
                var username = command[5];
                var ip = command[1];
                var counter = 1;

                if (!usageLog.ContainsKey(username))
                {
                    usageLog[username] = new Dictionary<string, int>();
                }
                if (!usageLog[username].ContainsKey(ip))
                {
                    usageLog[username][ip] = counter;
                }
                else
                {
                    usageLog[username][ip]++;

                }
                command = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var user in usageLog)
            {
                Console.WriteLine(user.Key + ":");
                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {              ///////////////////////
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
