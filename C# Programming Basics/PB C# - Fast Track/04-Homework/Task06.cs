using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0.0;
            string destination = "";
            string holidayType = "";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = budget * 0.3;
                    holidayType = "Camp";
                }
                else
                {
                    price = budget * 0.7;
                    holidayType = "Hotel";
                }
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    price = budget * 0.4;
                    holidayType = "Camp";
                }
                else
                {
                    price = budget * 0.8;
                    holidayType = "Hotel";
                }
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                price = budget * 0.9;
                destination = "Europe";
                holidayType = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:F2}", holidayType, price);
        }
    }
}