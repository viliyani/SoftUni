using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double puzzlesAmount = puzzlesCount * 2.60;
            double dollsAmount = dollsCount * 3.00;
            double bearsAmount = bearsCount * 4.10;
            double minionsAmount = minionsCount * 8.20;
            double trucksAmount = trucksCount * 2.00;

            int totalCount = puzzlesCount + dollsCount + bearsCount + minionsCount + trucksCount;
            double totalAmount = puzzlesAmount + dollsAmount + bearsAmount + minionsAmount + trucksAmount;

            if (totalCount >= 50)
            {
                totalAmount = totalAmount * 0.75;
            }

            double finalProfit = totalAmount * 0.90;

            if (finalProfit >= excursionPrice)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", (finalProfit - excursionPrice));
            } 
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", (excursionPrice - finalProfit));
            }
        }
    }
}