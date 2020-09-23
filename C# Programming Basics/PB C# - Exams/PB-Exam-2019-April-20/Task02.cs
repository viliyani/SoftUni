using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double moneyForGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guests >= 10 && guests <= 15)
            {
                moneyForGuest *= 0.85;
            }
            else if (guests > 15 && guests <= 20)
            {
                moneyForGuest *= 0.80;
            }
            else if (guests > 20)
            {
                moneyForGuest *= 0.75;
            }

            double total = guests * moneyForGuest + (budget * 0.1);

            if (budget >= total)
            {
                Console.WriteLine("It is party time! {0:F2} leva left.", (budget - total));
            }
            else
            {
                Console.WriteLine("No party! {0:F2} leva needed.", (total - budget));
            }
        }
    }
}