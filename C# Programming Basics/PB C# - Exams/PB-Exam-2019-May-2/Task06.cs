using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            for (int i = 1; i <= days; i++)
            {
                double currentPrice = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        currentPrice += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        currentPrice += 1.25;
                    }
                    else
                    {
                        currentPrice += 1;
                    }
                }

                currentPrice = Math.Round(currentPrice, 2);
                totalPrice += currentPrice;

                Console.WriteLine($"Day: {i} - {currentPrice:f2} leva");
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}