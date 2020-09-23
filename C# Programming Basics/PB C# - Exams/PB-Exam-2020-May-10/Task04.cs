using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());

            double exam1 = Math.Ceiling(students * 0.9);
            double exam2 = Math.Ceiling(exam1 * 0.9);
            double continues = Math.Ceiling(exam2 * 0.8);
            double agains = Math.Ceiling(continues * 0.05);

            int counter = 1;

            for (int i = 1; i < seasons; i++)
            {
                counter++;

                exam1 = Math.Ceiling((continues + agains) * 0.9);
                exam2 = Math.Ceiling(exam1 * 0.9);
                continues = Math.Ceiling(exam2 * 0.8);

                if (counter % 3 == 0)
                {
                    agains = Math.Ceiling(continues * 0.15);
                }
                else
                {
                    agains = Math.Ceiling(continues * 0.05);
                }
            }

            double final = continues + agains;
            Console.WriteLine($"Students: {final}");
        }
    }
}