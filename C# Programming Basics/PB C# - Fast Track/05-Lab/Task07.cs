using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}