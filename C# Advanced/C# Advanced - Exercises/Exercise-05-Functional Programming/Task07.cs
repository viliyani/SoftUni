using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, bool> predicate = x => x.Length <= n;

            Console.WriteLine(String.Join(Environment.NewLine, names.Where(predicate)));
        }
    }
}
