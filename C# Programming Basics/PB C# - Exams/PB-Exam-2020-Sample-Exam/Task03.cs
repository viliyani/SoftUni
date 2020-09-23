using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string delivery = Console.ReadLine();

            if (!(name == "Sushi Zone" || name == "Sushi Bar" || name == "Sushi Time" || name == "Asian Pub"))
            {
                Console.WriteLine($"{name} is invalid restaurant!");
                return;
            }


            double unitPrice = 0.0;

            if (type == "sashimi")
            {
                switch (name)
                {
                    case "Sushi Zone":
                        unitPrice = 4.99;
                        break;
                    case "Sushi Time":
                        unitPrice = 5.49;
                        break;
                    case "Sushi Bar":
                        unitPrice = 5.25;
                        break;
                    case "Asian Pub":
                        unitPrice = 4.50;
                        break;
                }
            }
            else if (type == "maki")
            {
                switch (name)
                {
                    case "Sushi Zone":
                        unitPrice = 5.29;
                        break;
                    case "Sushi Time":
                        unitPrice = 4.69;
                        break;
                    case "Sushi Bar":
                        unitPrice = 5.55;
                        break;
                    case "Asian Pub":
                        unitPrice = 4.80;
                        break;
                }
            }
            else if (type == "uramaki")
            {
                switch (name)
                {
                    case "Sushi Zone":
                        unitPrice = 5.99;
                        break;
                    case "Sushi Time":
                        unitPrice = 4.49;
                        break;
                    case "Sushi Bar":
                        unitPrice = 6.25;
                        break;
                    case "Asian Pub":
                        unitPrice = 5.50;
                        break;
                }
            }
            else if (type == "temaki")
            {
                switch (name)
                {
                    case "Sushi Zone":
                        unitPrice = 4.29;
                        break;
                    case "Sushi Time":
                        unitPrice = 5.19;
                        break;
                    case "Sushi Bar":
                        unitPrice = 4.75;
                        break;
                    case "Asian Pub":
                        unitPrice = 5.50;
                        break;
                }
            }

            double totalPrice = unitPrice * count;

            if (delivery == "Y")
            {
                totalPrice += totalPrice * 0.2;
            }

            totalPrice = Math.Ceiling(totalPrice);

            Console.WriteLine($"Total price: {totalPrice} lv.");
        }
    }
}