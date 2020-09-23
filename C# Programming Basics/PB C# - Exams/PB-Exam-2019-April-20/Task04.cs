using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsOne = int.Parse(Console.ReadLine());
            int eggsTwo = int.Parse(Console.ReadLine());

            string winner = Console.ReadLine();
            bool hasWinner = false;

            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    eggsTwo--;
                    if (eggsTwo == 0)
                    {
                        Console.WriteLine("Player two is out of eggs. Player one has {0} eggs left.", eggsOne);
                        hasWinner = true;
                        break;
                    }
                }
                else if (winner == "two")
                {
                    eggsOne--;
                    if (eggsOne == 0)
                    {
                        Console.WriteLine("Player one is out of eggs. Player two has {0} eggs left.", eggsTwo);
                        hasWinner = true;
                        break;
                    }
                }

                winner = Console.ReadLine();
            }

            if (!hasWinner)
            {
                Console.WriteLine($"Player one has {eggsOne} eggs left.");
                Console.WriteLine($"Player two has {eggsTwo} eggs left.");
            }
        }
    }
}