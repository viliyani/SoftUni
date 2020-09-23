using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    counter1++;
                }
                if (num % 3 == 0)
                {
                    counter2++;
                }
                if (num % 4 == 0)
                {
                    counter3++;
                }

                total++;
            }

            Console.WriteLine($"{(counter1 * 1.0 / total * 100):f2}%");
            Console.WriteLine($"{(counter2 * 1.0 / total * 100):f2}%");
            Console.WriteLine($"{(counter3 * 1.0 / total * 100):f2}%");
        }
    }
}