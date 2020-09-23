using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double unitPrice = 0.0;
            int discount = 0;

            // Types
            if (type == "Roses")
            {
                unitPrice = 5.0;

                if (number > 80)
                {
                    discount = 10;
                }
            }
            else if (type == "Dahlias")
            {
                unitPrice = 3.80;

                if (number > 90)
                {
                    discount = 15;
                }
            }
            else if (type == "Tulips")
            {
                unitPrice = 2.80;

                if (number > 80)
                {
                    discount = 15;
                }
            }
            else if (type == "Narcissus")
            {
                unitPrice = 3.0;

                if (number < 120)
                {
                    discount = -15;
                }
            }
            else if (type == "Gladiolus")
            {
                unitPrice = 2.50;

                if (number < 120)
                {
                    discount = -20;
                }
            }

            // Total price
            double total = unitPrice * number;

            // Discounts
            if (discount > 0)
            {
                total = total * ((100 - discount) / 100);
            }

            // Result
            if (budget >= total)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", number, type, (budget - total));
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", (total - budget));
            }
        }
    }
}