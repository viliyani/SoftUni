using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string range = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double unitPrice = 0.0;

            if (destination == "France")
            {
                if (range == "21-23")
                {
                    unitPrice = 30;
                }
                else if (range == "24-27")
                {
                    unitPrice = 35;
                }
                else if (range == "28-31")
                {
                    unitPrice = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (range == "21-23")
                {
                    unitPrice = 28;
                }
                else if (range == "24-27")
                {
                    unitPrice = 32;
                }
                else if (range == "28-31")
                {
                    unitPrice = 39;
                }
            }
            else if (destination == "Germany")
            {
                if (range == "21-23")
                {
                    unitPrice = 32;
                }
                else if (range == "24-27")
                {
                    unitPrice = 37;
                }
                else if (range == "28-31")
                {
                    unitPrice = 43;
                }
            }

            Console.WriteLine("Easter trip to {0} : {1:F2} leva.", destination, (unitPrice * nights));
        }
    }
}