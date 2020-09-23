using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int num = 0;
            int p1Counter = 0;
            int p2Counter = 0;
            int p3Counter = 0;
            int p4Counter = 0;
            int p5Counter = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1Counter++;
                }
                if (num % 3 == 0)
                {
                    p2Counter++;
                }
                if (num % 4 == 0)
                {
                    p3Counter++;
                }
            }

            Console.WriteLine("{0:F2}%", ((p1Counter / n) * 100));
            Console.WriteLine("{0:F2}%", ((p2Counter / n) * 100));
            Console.WriteLine("{0:F2}%", ((p3Counter / n) * 100));
        }
    }
}