using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double total = pencils * 5.8 + markers * 7.20 + liters * 1.20;

            total -= total * (discount * 1.0 / 100);

            Console.WriteLine($"{total:f3}");
        }
    }
}