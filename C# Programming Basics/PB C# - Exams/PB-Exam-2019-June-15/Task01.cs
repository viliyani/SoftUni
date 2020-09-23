using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            double total = Math.Floor(seasons * (episodes * (minutes + minutes * 0.20) + 10));

            Console.WriteLine($"Total time needed to watch the {name} series is {total} minutes.");
        }
    }
}