using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> action = PrintResult;
            Func<string, int> parser = int.Parse;
            List<int> numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(parser)
                .ToList();

            action(numbers);
        }

        static void PrintResult(List<int> numbers)
        {
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
