using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyTarget = double.Parse(Console.ReadLine());

            string coctailName = Console.ReadLine();
            double totalIncome = 0.0;
            bool isAquired = false; 

            while (coctailName != "Party!")
            {
                int coctailsCount = int.Parse(Console.ReadLine());

                double currentPrice = coctailName.Length * coctailsCount;

                if (currentPrice % 2 != 0)
                {
                    currentPrice -= currentPrice * 0.25;
                }

                totalIncome += currentPrice;

                if (totalIncome >= moneyTarget)
                {
                    isAquired = true;
                    break;
                }

                coctailName = Console.ReadLine();
            }

            double diff = Math.Abs(moneyTarget - totalIncome);

            if (isAquired)
            {
                Console.WriteLine("Target acquired.");
            }
            else
            {
                Console.WriteLine($"We need {diff:f2} leva more.");
            }

            Console.WriteLine($"Club income - {totalIncome:f2} leva.");
        }
    }
}