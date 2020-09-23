using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine()); // secs in meter

            double more = distance / 15;
            more = Math.Floor(more);
            double additionalTime = more * 12.5;
            double totalTime = (distance * seconds) + additionalTime;

            if (totalTime < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", (totalTime - record));
            }
        }
    }
}