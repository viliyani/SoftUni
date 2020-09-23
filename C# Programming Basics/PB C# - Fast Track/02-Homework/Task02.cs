using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double angleRad = double.Parse(Console.ReadLine());

            double angleDeg = (angleRad * 180) / Math.PI;
            Console.WriteLine(Math.Round(angleDeg));
        }
    }
}