using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int playersCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            int totalItems = 0;

            for (int i = 0; i < playersCount; i++)
            {

                string playerName = Console.ReadLine();

                double currentPrice = 0;
                int cookiesCount = 0;
                int cakesCount = 0;
                int wafflesCount = 0;

                string type = Console.ReadLine();

                while (type != "Stop baking!")
                {
                    int itemsCount = int.Parse(Console.ReadLine());

                    if (type == "cookies")
                    {
                        currentPrice = 1.50 * itemsCount;
                        cookiesCount += itemsCount;
                    }
                    else if (type == "cakes")
                    {
                        currentPrice = 7.80 * itemsCount;
                        cakesCount += itemsCount;
                    }
                    else if (type == "waffles")
                    {
                        currentPrice = 2.30 * itemsCount;
                        wafflesCount += itemsCount;
                    }

                    totalItems += itemsCount;
                    totalPrice += currentPrice;

                    type = Console.ReadLine();
                }

                Console.WriteLine($"{playerName} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");

            }

            Console.WriteLine($"All bakery sold: {totalItems}");
            Console.WriteLine($"Total sum for charity: {totalPrice:f2} lv.");
        }
    }
}