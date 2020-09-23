using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            double unitPrice = 0;
            bool invalidData = false;
            bool isWeekend = false;

            // Check is weekend
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    isWeekend = false;
                    break;
                case "Saturday":
                case "Sunday":
                    isWeekend = true;
                    break;
                default:
                    invalidData = true;
                    break;
            }

            // Calculate price
            if (isWeekend)
            {
                // prices for weekend
                switch (product)
                {
                    case "banana":
                        unitPrice = 2.70;
                        break;
                    case "apple":
                        unitPrice = 1.25;
                        break;
                    case "orange":
                        unitPrice = 0.90;
                        break;
                    case "grapefruit":
                        unitPrice = 1.60;
                        break;
                    case "kiwi":
                        unitPrice = 3.00;
                        break;
                    case "pineapple":
                        unitPrice = 5.60;
                        break;
                    case "grapes":
                        unitPrice = 4.20;
                        break;
                    default:
                        invalidData = true;
                        break;
                }
            }
            else
            {
                switch (product)
                {
                    case "banana":
                        unitPrice = 2.50;
                        break;
                    case "apple":
                        unitPrice = 1.20;
                        break;
                    case "orange":
                        unitPrice = 0.85;
                        break;
                    case "grapefruit":
                        unitPrice = 1.45;
                        break;
                    case "kiwi":
                        unitPrice = 2.70;
                        break;
                    case "pineapple":
                        unitPrice = 5.50;
                        break;
                    case "grapes":
                        unitPrice = 3.85;
                        break;
                    default:
                        invalidData = true;
                        break;
                }
            }

            if (invalidData == true)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:F2}", (qty * unitPrice));
            }
        }
    }
}