using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string type = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (drink == "Espresso")
            {
                if (type == "Without")
                {
                    price = price + 0.9 * drinksCount;
                    price *= 0.65;
                }
                else if (type == "Normal")
                {
                    price = price + drinksCount * 1.00;
                }
                else if (type == "Extra")
                {
                    price = price + drinksCount * 1.20;
                }

                if (drinksCount >= 5)
                {
                    price *= 0.75;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (type == "Without")
                {
                    price = price + 1.0 * drinksCount;
                    price *= 0.65;
                }
                else if (type == "Normal")
                {
                    price = price + 1.20 * drinksCount;
                }
                else if (type == "Extra")
                {
                    price = price + 1.60 * drinksCount;
                }
            }
            else if (drink == "Tea")
            {
                if (type == "Without")
                {
                    price = price + 0.50 * drinksCount;
                    price *= 0.65;
                }
                else if (type == "Normal")
                {
                    price = price + 0.60 * drinksCount;
                }
                else if (type == "Extra")
                {
                    price = price + 0.70 * drinksCount;
                }
            }

            if (price > 15)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You bought {drinksCount} cups of {drink} for {price:F2} lv.");
        }
    }
}