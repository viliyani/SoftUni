using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int brakeTime = int.Parse(Console.ReadLine());

            double freeTime = (5.0 / 8.0) * brakeTime;
            double episodeTimeD = episodeTime * 1.0;

            double diff = Math.Ceiling(Math.Abs(freeTime - episodeTime));

            if (freeTime >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {diff} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {diff} more minutes.");
            }
        }
    }
}