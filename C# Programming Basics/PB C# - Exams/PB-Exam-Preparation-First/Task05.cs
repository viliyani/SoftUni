using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            int counter = 1;
            string input = Console.ReadLine();

            while (input != "End")
            {
                double currentVolume = double.Parse(input);

                if (counter % 3 == 0)
                {
                    currentVolume *= 1.10;
                }

                if (currentVolume > capacity)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                capacity -= currentVolume;

                counter++;

                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {--counter} suitcases loaded.");
        }
    }
}