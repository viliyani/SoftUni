using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());

            int hearthstoneCounter = 0;
            int fortniteCounter = 0;
            int overwatchCounter = 0;
            int othersCounter = 0;

            for (int i = 0; i < gamesCount; i++)
            {
                string game = Console.ReadLine();

                switch (game)
                {
                    case "Hearthstone":
                        hearthstoneCounter++;
                        break;
                    case "Fornite":
                        fortniteCounter++;
                        break;
                    case "Overwatch":
                        overwatchCounter++;
                        break;
                    default:
                        othersCounter++;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {hearthstoneCounter * 1.0 / gamesCount * 100:f2}%");
            Console.WriteLine($"Fornite - {fortniteCounter * 1.0 / gamesCount * 100:f2}%");
            Console.WriteLine($"Overwatch - {overwatchCounter * 1.0 / gamesCount * 100:f2}%");
            Console.WriteLine($"Others - {othersCounter * 1.0 / gamesCount * 100:f2}%");
        }
    }
}