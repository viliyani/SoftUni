using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlMins = int.Parse(Console.ReadLine());
            int controlSecs = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int secsPer100meters = int.Parse(Console.ReadLine());

            double additionalSecs = (length / 120) * 2.5;

            double totalSecs = ((length / 100) * secsPer100meters) - additionalSecs;
            double totalControlSecs = controlMins * 60 + controlSecs;

            if (totalSecs <= totalControlSecs)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine("His time is {0:F3}.", totalSecs);
            }
            else
            {
                Console.WriteLine("No, Marin failed! He was {0:F3} second slower.", (totalSecs - totalControlSecs));
            }

        }
    }
}