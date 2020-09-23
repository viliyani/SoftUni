using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string field = Console.ReadLine();

            int failsCounter = 0;
            int successCounter = 0;
            int remainingPoints = 301;
            bool isWon = false;

            while (field != "Retire")
            {
                int points = int.Parse(Console.ReadLine());

                if (field == "Double")
                {
                    points *= 2;
                }
                else if (field == "Triple")
                {
                    points *= 3;
                }

                if (points > remainingPoints)
                {
                    failsCounter++;
                }
                else
                {
                    successCounter++;
                    remainingPoints -= points;
                    if (remainingPoints == 0)
                    {
                        isWon = true;
                        break;
                    }
                }

                field = Console.ReadLine();
            }

            if (isWon == true)
            {
                Console.WriteLine($"{name} won the leg with {successCounter} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {failsCounter} unsuccessful shots.");
            }
        }
    }
}