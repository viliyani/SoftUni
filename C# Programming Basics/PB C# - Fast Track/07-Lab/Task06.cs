using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            char c;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == n)
                    {
                        c = 'L';
                    }
                    else if (i % 2 == 0)
                    {
                        c = 'O';
                    }
                    else
                    {
                        c = 'A';
                    }
                    Console.Write($"{c}{i}{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}