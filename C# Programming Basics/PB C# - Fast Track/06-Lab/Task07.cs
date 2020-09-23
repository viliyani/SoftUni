using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int min = int.MaxValue;

            while ((i++) < n)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}