using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            // 1. Find the price per night
            double pricePerNight = 0.0;

            if (cruise == "Mediterranean")
            {
                switch (cabin)
                {
                    case "standard cabin":
                        pricePerNight = 27.50;
                        break;
                    case "cabin with balcony":
                        pricePerNight = 30.20;
                        break;
                    case "apartment":
                        pricePerNight = 40.50;
                        break;
                }
            }
            else if (cruise == "Adriatic")
            {
                switch (cabin)
                {
                    case "standard cabin":
                        pricePerNight = 22.99;
                        break;
                    case "cabin with balcony":
                        pricePerNight = 25.00;
                        break;
                    case "apartment":
                        pricePerNight = 34.99;
                        break;
                }
            }
            else if (cruise == "Aegean")
            {
                switch (cabin)
                {
                    case "standard cabin":
                        pricePerNight = 23;
                        break;
                    case "cabin with balcony":
                        pricePerNight = 26.60;
                        break;
                    case "apartment":
                        pricePerNight = 39.80;
                        break;
                }
            }

            // 2. Calculate total price for 4 people
            double total = pricePerNight * nights * 4;

            // 3. Check discount
            if (nights > 7)
            {
                total -= total * 0.25;
            }

            // 4. Output
            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {total:f2} lv.");
        }
    }
}