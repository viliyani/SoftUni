using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int max = int.MinValue;

            while ((i++) < n)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}