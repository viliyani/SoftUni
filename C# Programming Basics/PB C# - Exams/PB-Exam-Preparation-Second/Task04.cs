using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPoints = int.Parse(Console.ReadLine());

            int movesCounter = 0;

            while (initialPoints > 0)
            {
                string section = Console.ReadLine();
                movesCounter++;

                if (section == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {movesCounter} moves!");
                    break;
                }

                int currentPoints = int.Parse(Console.ReadLine());

                switch (section)
                {
                    case "number section":
                        initialPoints -= currentPoints;
                        break;
                    case "double ring":
                        initialPoints -= 2 * currentPoints;
                        break;
                    case "triple ring":
                        initialPoints -= 3 * currentPoints;
                        break;
                }

                if (initialPoints == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {movesCounter} moves!");
                    break;
                }

                if (initialPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(initialPoints)}.");
                    break;
                }
            }
        }
    }
}