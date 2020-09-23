using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            int percentAdditionalCosts = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                priceNight *= 0.95;
            }

            double total = nights * priceNight;
            double freeBudget = budget * ((100 - percentAdditionalCosts) * 1.0 / 100);

            if (freeBudget >= total)
            {
                Console.WriteLine("Ivanovi will be left with {0:F2} leva after vacation.", (freeBudget - total));
            }
            else
            {
                Console.WriteLine("{0:F2} leva needed.", (total - freeBudget));
            }
        }
    }
}