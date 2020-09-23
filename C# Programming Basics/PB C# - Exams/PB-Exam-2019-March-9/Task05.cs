using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int points = startPoints;
            double wins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    points += 2000;
                    wins++;
                }
                else if (result == "F")
                {
                    points += 1200;
                }
                else if (result == "SF")
                {
                    points += 720;
                }
            }

            Console.WriteLine("Final points: {0}", points);
            Console.WriteLine("Average points: {0}", ((points - startPoints) / tournaments));
            Console.WriteLine("{0:F2}%", ((wins / tournaments) * 100));
        }
    }
}