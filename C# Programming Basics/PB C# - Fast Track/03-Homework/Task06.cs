using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            double unitPrice = double.Parse(Console.ReadLine());

            double clothingPrice = 0;
            if (peopleCount >= 150)
            {
                clothingPrice = peopleCount * unitPrice * 0.90;
            }
            else
            {
                clothingPrice = peopleCount * unitPrice;
            }
            double totalNeeded = clothingPrice + (0.1 * budget);

            if (totalNeeded <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", (budget - totalNeeded));
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", (totalNeeded - budget));
            }
        }
    }
}