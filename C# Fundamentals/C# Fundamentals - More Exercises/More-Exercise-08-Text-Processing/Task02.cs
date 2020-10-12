using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char from = char.Parse(Console.ReadLine());
            char to = char.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > from && str[i] < to)
                {
                    sum += str[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
