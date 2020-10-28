using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> findMin = numbers => numbers.Min();
            Console.WriteLine(findMin(Console.ReadLine().Split().Select(int.Parse).ToList()));
        }
    }
}
