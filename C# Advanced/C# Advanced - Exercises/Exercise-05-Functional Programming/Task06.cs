using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            Predicate<int> isDivisible = x => x % n == 0;

            numbers.RemoveAll(isDivisible);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
