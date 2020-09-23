using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQty = double.Parse(Console.ReadLine()); 
            double wineQty = double.Parse(Console.ReadLine());
            double brandyQty = double.Parse(Console.ReadLine());
            double whiskeyQty = double.Parse(Console.ReadLine());

            double brandyPrice = 0.5 * whiskeyPrice;
            double beerPrice = 0.2 * brandyPrice;
            double winePrice = 0.6 * brandyPrice;

            double total = (whiskeyPrice * whiskeyQty) + (beerPrice * beerQty) + (winePrice * wineQty) + (brandyPrice * brandyQty);

            Console.WriteLine("{0:F2}", total);
        }
    }
}