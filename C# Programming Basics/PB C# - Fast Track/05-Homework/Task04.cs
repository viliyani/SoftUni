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

                if (num < 200)
                {
                    p1Counter++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2Counter++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3Counter++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4Counter++;
                }
                else if (num >= 800)
                {
                    p5Counter++;
                }
            }

            Console.WriteLine("{0:F2}%", ((p1Counter / n) * 100));
            Console.WriteLine("{0:F2}%", ((p2Counter / n) * 100));
            Console.WriteLine("{0:F2}%", ((p3Counter / n) * 100));
            Console.WriteLine("{0:F2}%", ((p4Counter / n) * 100));
            Console.WriteLine("{0:F2}%", ((p5Counter / n) * 100));
        }
    }
}