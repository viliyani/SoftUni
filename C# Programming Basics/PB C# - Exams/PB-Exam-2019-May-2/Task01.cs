using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double total = chicken * 10.35 + fish * 12.40 + vegan * 8.15;
            total *= 1.20;
            total += 2.50;

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}