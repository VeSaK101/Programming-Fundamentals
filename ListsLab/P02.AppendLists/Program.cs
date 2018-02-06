using System;
using System.Linq;
using System.Collections.Generic;

namespace P02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lists = Console.ReadLine().Split('|').ToList();
            var resault = new List<string>();
            

            for (int i = Lists.Count - 1; i >= 0; i--)
            {
                
                resault.Add(Lists[i]);
                
            }
            var s = string.Join(" ", resault);
            var endRes = s.Split(' ').ToList();

            for (int i = 0; i < endRes.Count; i++)
            {
                endRes.Remove("");
            }
            Console.WriteLine(string.Join(" ",endRes));
            
            
        }
    }
}
