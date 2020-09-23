using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int winDays = 0;
            int loseDays = 0;
            double totalMoney = 0;

            for (int i = 0; i < days; i++)
            {
                string sport = Console.ReadLine();

                double currentMoney = 0;
                int currentWins = 0;
                int currentLoses = 0;

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        currentWins++;
                        currentMoney += 20;
                    }
                    else if (result == "lose")
                    {
                        currentLoses++;
                    }

                    sport = Console.ReadLine();
                }

                if (currentWins > currentLoses)
                {
                    currentMoney += currentMoney * 0.1;
                    winDays++;
                }
                else
                {
                    loseDays++;
                }

                totalMoney += currentMoney;
            }

            if (winDays > loseDays)
            {
                totalMoney += totalMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}