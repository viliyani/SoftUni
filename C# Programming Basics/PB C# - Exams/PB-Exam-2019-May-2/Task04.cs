using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            int counter = 1;

            string productName = Console.ReadLine();
            while (productName != "Stop")
            {
                double price = double.Parse(Console.ReadLine());

                if (counter++ % 3 == 0)
                {
                    price *= 0.5;
                }

                if (price + totalPrice > budget)
                {
                    double diff = Math.Abs(budget - (price + totalPrice));
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {diff:f2} leva!");
                    break;
                }

                totalPrice += price;

                productName = Console.ReadLine();
            }

            if (productName == "Stop")
            {
                Console.WriteLine($"You bought {--counter} products for {totalPrice:f2} leva.");
            }
        }
    }
}