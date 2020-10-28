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

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
                else if (input == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToList();
                }
                else if (input == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if (input == "print")
                {
                    Console.WriteLine(String.Join(" ", numbers));
                }
            }
        }
    }
}
