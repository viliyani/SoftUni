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

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y2 - y1);

            double perimeter = 2 * a + 2 * b;
            double area = a * b;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}