using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double totalTime = distance * timePerMeter;
            double additional = Math.Floor(distance / 50) * 30;
            totalTime += additional;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}