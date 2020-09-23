using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souveniresMoney = double.Parse(Console.ReadLine());
            double hotelDayPrice = double.Parse(Console.ReadLine());

            double gasMoney = 2 * 210 * 0.07 * 1.85;
            double hotelMoney = (hotelDayPrice * 0.9) + (hotelDayPrice * 0.85) + (hotelDayPrice * 0.8);
            souveniresMoney *= 3;
            foodMoney *= 3;

            double totalMoney = gasMoney + foodMoney + souveniresMoney + hotelMoney;

            Console.WriteLine($"Money needed: {totalMoney:f2}");
        }
    }
}