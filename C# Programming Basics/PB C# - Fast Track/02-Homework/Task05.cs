using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());

            double hallArea = length * width;
            double squareArea = side * side;
            double benchArea = hallArea / 10;

            double freeArea = hallArea - (squareArea + benchArea); // m^2
            double freeAreaCm = freeArea * 100 * 100; // cm^2
            double personNeededArea = 7040; // cm^2

            double peopleCount = freeAreaCm / personNeededArea;

            Console.WriteLine(Math.Floor(peopleCount));
        }
    }
}