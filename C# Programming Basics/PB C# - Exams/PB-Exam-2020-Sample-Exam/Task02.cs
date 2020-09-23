using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLenght = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double avgAstroHeight = double.Parse(Console.ReadLine());

            double roomWidth = 2;
            double roomLength = 2;
            double roomHeight = 0.40 + avgAstroHeight;

            double shipSpace = shipWidth * shipHeight * shipLenght;
            double roomSpace = roomWidth * roomHeight * roomLength;

            double totalAstros = Math.Floor(shipSpace / roomSpace);

            if (totalAstros >= 3 && totalAstros <= 10)
            {
                Console.WriteLine($"The spacecraft holds {totalAstros} astronauts.");
            }
            else if (totalAstros < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (totalAstros > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}