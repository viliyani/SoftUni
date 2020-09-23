using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double liters = (width * height * length * 0.001) * (1 - (percent * 0.01));
            string formatLiters = String.Format("{0:F3}", liters);
            Console.WriteLine(formatLiters);
        }
    }
}