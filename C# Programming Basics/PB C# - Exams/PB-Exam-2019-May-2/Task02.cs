using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersNeeded = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double total = litersNeeded * 2.10 + 100;

            if (day == "Saturday")
            {
                total *= 0.90;
            }
            else if (day == "Sunday")
            {
                total *= 0.80;
            }

            double diff = Math.Abs(total - budget);

            if (budget >= total)
            {
                Console.WriteLine($"Safari time! Money left: {diff:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {diff:f2} lv.");
            }
        }
    }
}