using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double taxPrice = double.Parse(Console.ReadLine());
            double shezlongUnitPrice = double.Parse(Console.ReadLine());
            double umbrelaUnitPrice = double.Parse(Console.ReadLine());

            double priceShezlong = Math.Ceiling(peopleCount * 0.75) * shezlongUnitPrice;
            double priceUmbrela = Math.Ceiling(peopleCount * 1.0 / 2) * umbrelaUnitPrice;

            double totalPrice = (peopleCount * taxPrice) + priceShezlong + priceUmbrela;

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}