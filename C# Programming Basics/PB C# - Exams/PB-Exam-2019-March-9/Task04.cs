using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            int points1 = 0;
            int points2 = 0;

            string input1;

            while (true)
            {
                input1 = Console.ReadLine();
                if (input1 == "End of game")
                {
                    Console.WriteLine("{0} has {1} points", name1, points1);
                    Console.WriteLine("{0} has {1} points", name2, points2);
                    break;
                }

                int card1 = int.Parse(input1);
                int card2 = int.Parse(Console.ReadLine());

                if (card1 > card2)
                {
                    points1 += card1 - card2;
                }
                else if (card1 < card2)
                {
                    points2 += card2 - card1;
                }
                else if (card1 == card2)
                {
                    int againCard1 = int.Parse(Console.ReadLine());
                    int againCard2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Number wars!");

                    if (againCard1 > againCard2)
                    {
                        Console.WriteLine("{0} is winner with {1} points", name1, points1);
                    }
                    else
                    {
                        Console.WriteLine("{0} is winner with {1} points", name2, points2);
                    }

                    break;
                }
            }
        }
    }
}