using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioUnitPrice = 0.0;
            double apartmentUnitPrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioUnitPrice = 50;
                apartmentUnitPrice = 65;

                if (nights > 7 && nights <= 14)
                {
                    studioUnitPrice *= 0.95;
                }
                else if (nights > 14)
                {
                    studioUnitPrice *= 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioUnitPrice = 75.20;
                apartmentUnitPrice = 68.70;

                if (nights > 14)
                {
                    studioUnitPrice *= 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioUnitPrice = 76;
                apartmentUnitPrice = 77;
            }

            if (nights > 14)
            {
                apartmentUnitPrice *= 0.90;
            }

            Console.WriteLine("Apartment: {0:F2} lv.", (nights * apartmentUnitPrice));
            Console.WriteLine("Studio: {0:F2} lv.", (nights * studioUnitPrice));
        }
    }
}