using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;
            double num;
            int i = 0;

            while ((i++) < n)
            {
                num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    sum += num;
                    Console.WriteLine($"Increase: {num:F2}");
                }
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}