using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double price = 0.0;

            // Price
            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            // Discount
            if (count <= 6)
            {
                price = price * 0.9;
            }
            else if (count > 7 && count <= 11)
            {
                price = price * 0.85;
            }
            else
            {
                price = price * 0.75;
            }

            // Extra discount
            if (count % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }

            if (budget >= price)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", (budget - price));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", (price - budget));
            }
        }
    }
}