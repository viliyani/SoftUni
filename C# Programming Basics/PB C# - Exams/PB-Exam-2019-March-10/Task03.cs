using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string type = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            string wantPhoto = Console.ReadLine();

            double ticketUnitPrice = 0.0;

            if (stage == "Quarter final")
            {
                if (type == "Standard")
                {
                    ticketUnitPrice = 55.50;
                }
                else if (type == "Premium")
                {
                    ticketUnitPrice = 105.20;
                }
                else if (type == "VIP")
                {
                    ticketUnitPrice = 118.90;
                }
            }
            else if (stage == "Semi final")
            {
                if (type == "Standard")
                {
                    ticketUnitPrice = 75.88;
                }
                else if (type == "Premium")
                {
                    ticketUnitPrice = 125.22;
                }
                else if (type == "VIP")
                {
                    ticketUnitPrice = 300.40;
                }
            }
            else if (stage == "Final")
            {
                if (type == "Standard")
                {
                    ticketUnitPrice = 110.10;
                }
                else if (type == "Premium")
                {
                    ticketUnitPrice = 160.66;
                }
                else if (type == "VIP")
                {
                    ticketUnitPrice = 400;
                }
            }

            double totalPrice = ticketUnitPrice * ticketsCount;
            
            // discounts
            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice *= 0.90;
            }
            else if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
            }

            // if want photo
            if (wantPhoto == "Y" && totalPrice <= 4000)
            {
                totalPrice += (ticketsCount * 40);
            }

            // print
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}