using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serials = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            for (int i = 0; i < serials; i++)
            {
                string serialName = Console.ReadLine();
                double serialPrice = double.Parse(Console.ReadLine());

                if (serialName == "Thrones")
                {
                    serialPrice *= 0.5;
                }
                else if (serialName == "Lucifer")
                {
                    serialPrice *= 0.6;
                }
                else if (serialName == "Protector")
                {
                    serialPrice *= 0.7;
                }
                else if (serialName == "TotalDrama")
                {
                    serialPrice *= 0.8;
                }
                else if (serialName == "Area")
                {
                    serialPrice *= 0.9;
                }

                totalPrice += serialPrice;
            }

            double diff = Math.Abs(totalPrice - budget);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {diff:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {diff:f2} lv. more to buy the series!");
            }
        }
    }
}