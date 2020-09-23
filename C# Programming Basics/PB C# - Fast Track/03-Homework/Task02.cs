using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5.0;
            }
            else if (points > 1000)
            {
                bonusPoints = 0.1 * points;
            }
            else if (points > 100)
            {
                bonusPoints = 0.2 * points;
            }

            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (points % 5 == 0)
            {
                bonusPoints += 2;
            }

            double totalPoints = points + bonusPoints;

            Console.WriteLine($"{bonusPoints:F1}");
            Console.WriteLine($"{totalPoints:F1}");
        }
    }
}