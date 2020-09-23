using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string extraNet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());


            double unitPrice = 0;

            if (years == "one")
            {
                switch (type)
                {
                    case "Small":
                        unitPrice = 9.98;
                        break;
                    case "Middle":
                        unitPrice = 18.99;
                        break;
                    case "Large":
                        unitPrice = 25.98;
                        break;
                    case "ExtraLarge":
                        unitPrice = 35.99;
                        break;
                }
            }
            else if (years == "two")
            {
                switch (type)
                {
                    case "Small":
                        unitPrice = 8.58;
                        break;
                    case "Middle":
                        unitPrice = 17.09;
                        break;
                    case "Large":
                        unitPrice = 23.59;
                        break;
                    case "ExtraLarge":
                        unitPrice = 31.79;
                        break;
                }
            }

            if (extraNet == "yes")
            {
                if (unitPrice <= 10.00)
                {
                    unitPrice += 5.50;
                }
                else if (unitPrice <= 30.00)
                {
                    unitPrice += 4.35;
                }
                else if (unitPrice > 30.00)
                {
                    unitPrice += 3.85;
                }
            }

            double total = unitPrice * months;

            if (years == "two")
            {
                total -= total * 0.0375;
            }

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}