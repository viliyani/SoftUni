using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = from; i <= to; i++)
            {
                for (int j = from; j <= to; j++)
                {
                    if (i + j == number)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, number);
                        return;
                    }
                    counter++;
                }
            }

            Console.WriteLine($"{counter - 1} combinations - neither equals {number}");
        }
    }
}