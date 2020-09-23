using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double total = days * (cooks * ((cakes * 45) + (waffles * 5.8) + (pancakes * 3.2)));
            double profit = (7.0 / 8.0) * total;

            Console.WriteLine($"{profit:F2}");
        }
    }
}