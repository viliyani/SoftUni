 using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = days - 1;
            int nightPrice = 0;
            int percentDiscount = 0;

            // Price for 1 night
            if (type == "room for one person")
            {
                nightPrice = 18;
            }
            else if (type == "apartment")
            {
                nightPrice = 25;
            }
            else if (type == "president apartment")
            {
                nightPrice = 35;
            }

            // Percent Discount
            if (type == "apartment")
            {
                if (days < 10)
                {
                    percentDiscount += 30;
                }
                else if (days >= 10 && days <= 15)
                {
                    percentDiscount += 35;
                }
                else if (days > 15)
                {
                    percentDiscount += 50;
                }
            }
            else if (type == "president apartment")
            {
                if (days < 10)
                {
                    percentDiscount += 10;
                }
                else if (days >= 10 && days <= 15)
                {
                    percentDiscount += 15;
                }
                else if (days > 15)
                {
                    percentDiscount += 20;
                }
            }

            // Price
            double price = 0;
            if (percentDiscount > 0)
            {
                price = (nights * nightPrice) * ((100.00 - percentDiscount) / 100.00);
            }
            else
            {
                price = (nights * nightPrice);
            }

            // Rating
            if (rating == "positive")
            {
                price = price * 1.25;
            }
            else if (rating == "negative")
            {
                price = price * 0.9;
            }

            // Print
            Console.WriteLine("{0:F2}", price);
        }
    }
}