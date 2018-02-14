using System;
using System.Linq;
using System.Collections.Generic;

namespace P08.LogsAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var log = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var userTrack = Console.ReadLine().Split().ToArray();
                var ip = userTrack[0];
                var username = userTrack[1];
                var upTime = int.Parse(userTrack[2]);
                if (!log.ContainsKey(username))
                {
                    log[username] = new SortedDictionary<string, int>();
                }
                if (!log[username].ContainsKey(ip))
                {
                    log[username][ip] = upTime;
                }
                else
                {
                    log[username][ip] += upTime;
                }
            }
            foreach (var user in log)
            {
                var ipList = new List<string>();
                var duration = 0;
                foreach (var ip in user.Value)
                {
                    ipList.Add(ip.Key);
                    duration += ip.Value;
                }
                Console.WriteLine($"{user.Key}: {duration} [{string.Join(", ",ipList.Distinct())}]");
            }
        }
    }
}
