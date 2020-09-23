using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyForPlayer = int.Parse(Console.ReadLine());

            int income = 0;
            int totalGuests = 0;
            string input = Console.ReadLine();

            while (input != "The restaurant is full")
            {
                int peopleInGroup = int.Parse(input);

                totalGuests += peopleInGroup;

                if (peopleInGroup >= 5)
                {
                    income += peopleInGroup * 70;
                }
                else
                {
                    income += peopleInGroup * 100;
                }

                input = Console.ReadLine();
            }

            int diff = Math.Abs(income - moneyForPlayer);

            if (income >= moneyForPlayer)
            {
                Console.WriteLine($"You have {totalGuests} guests and {diff} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalGuests} guests and {income} leva income, but no singer.");
            }
        }
    }
}