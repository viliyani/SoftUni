using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            while (name != "Midnight")
            {
                bool isCheated = false;

                int studentPoints = 0;
                int currentPoints = 0;

                for (int i = 0; i < 6; i++)
                {
                    currentPoints = int.Parse(Console.ReadLine());
                    studentPoints += currentPoints;
                    if (currentPoints < 0)
                    {
                        Console.WriteLine($"{name} was cheating!");
                        isCheated = true;
                        break;
                    }
                }

                double result = studentPoints * 1.0 / 600 * 100;
                result = Math.Floor(result);

                double mark = result * 0.06;

                if (mark < 3.00)
                {
                    mark = 2.00;
                }

                if (isCheated == false)
                {
                    if (mark >= 5)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("|   CERTIFICATE   |");
                        Console.WriteLine($"|    {mark:f2}/6.00    |");
                        Console.WriteLine("===================");
                        Console.WriteLine($"Issued to {name}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} - {mark:f2}");
                    }
                }

                name = Console.ReadLine();
            }
        }
    }
}