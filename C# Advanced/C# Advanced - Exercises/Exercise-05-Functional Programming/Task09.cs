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
            List<int> numbers = Enumerable.Range(1, n).ToList();

            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var cond = numbers.Where(x => x % 1 == 0);

            foreach (var item in dividers)
            {
                cond = cond.Where(x => x % item == 0);
            }

            Console.WriteLine(String.Join(" ", cond.ToList()));
        }
    }
}
