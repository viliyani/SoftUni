using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilogramrs = int.Parse(Console.ReadLine());

            int availableGrams = kilogramrs * 1000;
            int totalGrams = 0;

            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                int currentGrams = int.Parse(input);

                totalGrams += currentGrams;

                input = Console.ReadLine();
            }

            int diff = Math.Abs(totalGrams - availableGrams);

            if (availableGrams >= totalGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }

        }
    }
}