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

            Console.WriteLine(String.Join(" ", names.Where(name => name.ToCharArray().Sum(x => x) >= n).First()));
        }
    }
}
