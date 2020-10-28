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
            string option = Console.ReadLine();
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);

            Predicate<int> isEven = n => n % 2 == 0;

            Console.WriteLine(String.Join(" ", Enumerable.Range(start, end - start + 1)
                .Where(x => option == "even" ? isEven(x) : !isEven(x))
                .ToList()));
        }
    }
}
