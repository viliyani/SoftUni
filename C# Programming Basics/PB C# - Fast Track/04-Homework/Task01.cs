using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool check1, check2;
            if (y2 > y1)
            {
                check2 = y > y1 && y < y2;

            }
            else
            {
                check2 = y >= y2 && y <= y1;
            }


            // Position
            if (((y == y1 || y == y2) && check1) || ((x == x1 || x == x2) && check2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}