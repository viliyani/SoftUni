using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string packet = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double unitPrice = 0.0;

            if (movie == "John Wick")
            {
                switch (packet)
                {
                    case "Drink":
                        unitPrice = 12;
                        break;
                    case "Popcorn":
                        unitPrice = 15;
                        break;
                    case "Menu":
                        unitPrice = 19;
                        break;
                }
            }
            else if (movie == "Star Wars")
            {
                switch (packet)
                {
                    case "Drink":
                        unitPrice = 18;
                        break;
                    case "Popcorn":
                        unitPrice = 25;
                        break;
                    case "Menu":
                        unitPrice = 30;
                        break;
                }

                if (tickets >= 4)
                {
                    unitPrice -= unitPrice * 0.30;
                }
            }
            else if (movie == "Jumanji")
            {
                switch (packet)
                {
                    case "Drink":
                        unitPrice = 9;
                        break;
                    case "Popcorn":
                        unitPrice = 11;
                        break;
                    case "Menu":
                        unitPrice = 14;
                        break;
                }

                if (tickets == 2)
                {
                    unitPrice -= unitPrice * 0.15;
                }
            }

            double total = tickets * unitPrice;

            Console.WriteLine($"Your bill is {total:f2} leva.");
        }
    }
}