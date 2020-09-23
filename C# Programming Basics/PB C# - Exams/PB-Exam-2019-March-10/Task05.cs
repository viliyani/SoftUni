using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int proteinShakeCounter = 0;
            int proteinBarCounter = 0;

            for (int i = 0; i < visitors; i++)
            {
                string action = Console.ReadLine();

                if (action == "Back")
                {
                    backCounter++;
                }
                else if (action == "Chest")
                {
                    chestCounter++;
                }
                else if (action == "Legs")
                {
                    legsCounter++;
                }
                else if (action == "Abs")
                {
                    absCounter++;
                }
                else if (action == "Protein shake")
                {
                    proteinShakeCounter++;
                }
                else if (action == "Protein bar")
                {
                    proteinBarCounter++;
                }
            }

            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{proteinShakeCounter} - protein shake");
            Console.WriteLine($"{proteinBarCounter} - protein bar");

            int trainings = backCounter + chestCounter + legsCounter + absCounter;
            double trainingsPercent = (trainings * 1.0 / visitors) * 100;
            Console.WriteLine($"{trainingsPercent:F2}% - work out");
            Console.WriteLine("{0:F2}% - protein", ((proteinShakeCounter + proteinBarCounter) * 1.0 / visitors * 100));
        }
    }
}