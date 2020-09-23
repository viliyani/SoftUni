using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double rocketPrice = double.Parse(Console.ReadLine());
            int rocketCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double shoesPrice = (1.0 / 6.0) * rocketPrice;

            double total = (rocketPrice * rocketCount) + (shoesPrice * shoesCount);
            total *= 1.2;

            Console.WriteLine("Price to be paid by Djokovic {0}", Math.Floor(total * (1.0/8.0)));
            Console.WriteLine("Price to be paid by sponsors {0}", Math.Ceiling(total * (7.0/8.0)));
        }
    }
}