using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int winCounter = 0;
            int loseCounter = 0;

            string tournamentName = Console.ReadLine();

            while (tournamentName != "End of tournaments")
            {
                int matchesCount = int.Parse(Console.ReadLine());

                for (int i = 1; i <= matchesCount; i++)
                {
                    int desiTeamPoints = int.Parse(Console.ReadLine());
                    int otherTeamPoints = int.Parse(Console.ReadLine());

                    if (desiTeamPoints > otherTeamPoints)
                    {
                        winCounter++;
                        Console.WriteLine("Game {0} of tournament {1}: win with {2} points.", i, tournamentName, (desiTeamPoints - otherTeamPoints));
                    }
                    else
                    {
                        loseCounter++;
                        Console.WriteLine("Game {0} of tournament {1}: lost with {2} points.", i, tournamentName, (otherTeamPoints - desiTeamPoints));
                    }
                }

                tournamentName = Console.ReadLine();
            }

            Console.WriteLine("{0:F2}% matches win", (winCounter * 1.0 / (winCounter + loseCounter) * 100));
            Console.WriteLine("{0:F2}% matches lost", (loseCounter * 1.0 / (winCounter + loseCounter) * 100));
        }
    }
}