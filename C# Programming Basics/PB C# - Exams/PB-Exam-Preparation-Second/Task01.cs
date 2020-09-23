using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());

            double expenses = 0.3 * income;

            double savedMoney = income - expenses - moneyNeeded;
            double totalMoney = savedMoney * months;

            double percentSaved = savedMoney / income * 100;

            Console.WriteLine($"She can save {percentSaved:F2}%");
            Console.WriteLine($"{totalMoney:F2}");
        }
    }
}