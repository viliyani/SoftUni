using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            // 1. Calculate the prices for the items
            double umbrellaPrice = 2.0 / 3.0 * towelPrice;
            double flipFlopsPrice = 0.75 * umbrellaPrice;
            double bagPrice = 1.0 / 3.0 * (flipFlopsPrice + towelPrice);

            // 2. Calculte the total price for the items
            double totalPrice = umbrellaPrice + flipFlopsPrice + bagPrice + towelPrice;

            // 3. Make a discount
            totalPrice *= (100 - discount) * 1.0 / 100;

            // 4. Check whether her budget is enough
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Annie's sum is {totalPrice:F2} lv. She has {budget - totalPrice:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalPrice:F2} lv. She needs {totalPrice - budget:F2} lv. more.");
            }
        }
    }
}