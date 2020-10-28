using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> comparer = (x, y) =>
            Math.Abs(x % 2) == Math.Abs(y % 2) ? (x == y ? 0 : (x < y ? -1 : 1)) : (Math.Abs(x % 2) == 0 ? 1 : -1);

            Array.Sort(numbers, (x, y) => comparer(x, y));

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
