using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double areaCover = number * (length + 2 * 0.30) * (width + 2 * 0.30);
            double areaSquare = number * (length / 2) * (length / 2);

            double priceUSD = (areaCover * 7) + (areaSquare * 9);
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine($"{priceUSD:F2} USD");
            Console.WriteLine($"{priceBGN:F2} BGN");
        }
    }
}