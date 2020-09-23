using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double money = 0;
            double add = 9;
            int toys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += add;
                    add += 10;
                }
                else
                {
                    toys++;
                }
            }

            money += (toys * p);

            if (money >= price)
            {
                Console.WriteLine("Yes! {0:F2}", (money - price));
            }
            else
            {
                Console.WriteLine("No! {0:F2}", (price - money));
            }
        }
    }
}