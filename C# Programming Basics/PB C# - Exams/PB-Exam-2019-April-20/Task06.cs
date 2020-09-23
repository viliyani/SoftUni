using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int breadCount = int.Parse(Console.ReadLine());

            int maxPoints = int.MinValue;
            string maxPointsOwner = "";

            for (int i = 0; i < breadCount; i++)
            {
                string name = Console.ReadLine();
                string markInput = Console.ReadLine();

                int currentPoints = 0;

                while (markInput != "Stop")
                {
                    int mark = int.Parse(markInput);

                    currentPoints += mark;

                    markInput = Console.ReadLine();
                }

                Console.WriteLine($"{name} has {currentPoints} points.");

                if (currentPoints > maxPoints)
                {
                    maxPoints = currentPoints;
                    maxPointsOwner = name;

                    Console.WriteLine($"{name} is the new number 1!");
                }
            }

            Console.WriteLine($"{maxPointsOwner} won competition with {maxPoints} points!");
        }
    }
}