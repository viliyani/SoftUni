using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentPoints = 0;
            int maxPoints = int.MinValue;
            string maxName = "";

            while (name != "Stop")
            {
                currentPoints = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num == name[i])
                    {
                        currentPoints += 10;
                    }
                    else
                    {
                        currentPoints += 2;
                    }
                }

                if (currentPoints >= maxPoints)
                {
                    maxPoints = currentPoints;
                    maxName = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {maxName} with {maxPoints} points!");
        }
    }
}