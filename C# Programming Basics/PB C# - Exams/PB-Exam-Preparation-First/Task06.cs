using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int winDays = 0;
            int lostDays = 0;
            double totalMoney = 0;

            for (int i = 0; i < days; i++)
            {

                string sport = Console.ReadLine();
                double currentMoney = 0;
                int currentWins = 0;
                int currentLosts = 0;


                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        currentMoney += 20;
                        currentWins++;
                    }
                    else
                    {
                        currentLosts++;
                    }

                    sport = Console.ReadLine();
                }

                if (currentWins > currentLosts)
                {
                    currentMoney *= 1.10;
                    winDays++;
                }
                else
                {
                    lostDays++;
                }

                totalMoney += currentMoney;
            }

            if (winDays > lostDays)
            {
                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}