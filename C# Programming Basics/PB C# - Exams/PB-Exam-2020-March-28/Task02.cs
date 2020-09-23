using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secsPerMeter = double.Parse(Console.ReadLine());

            double total = secsPerMeter * meters;
            total += Math.Floor((meters / 50)) * 30;

            double diff = Math.Abs(record - total);

            if (total < record)
            {
                Console.WriteLine($"Yes! The new record is {total:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {diff:f2} seconds slower.");
            }
        }
    }
}