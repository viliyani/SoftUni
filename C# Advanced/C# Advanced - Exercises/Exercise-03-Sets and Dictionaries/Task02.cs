using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> set2 = new HashSet<string>();
            HashSet<string> set3 = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                set2.Add(Console.ReadLine());
            }

            set1.IntersectWith(set2);

            Console.WriteLine(String.Join(" ", set1));
        }
    }
}
