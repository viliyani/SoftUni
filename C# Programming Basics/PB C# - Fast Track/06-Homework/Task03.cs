using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;
            bool isFailed = false;

            while (ownedMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (action == "spend")
                {
                    ownedMoney -= money;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                    spendingCounter++;
                    if (spendingCounter == 5)
                    {
                        isFailed = true;
                        break;
                    }
                }
                else if (action == "save")
                {
                    ownedMoney += money;
                    spendingCounter = 0;
                }
            }

            if (isFailed)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else
            {
                Console.WriteLine("You saved the money for {0} days.", daysCounter);
            }
        }
    }
}