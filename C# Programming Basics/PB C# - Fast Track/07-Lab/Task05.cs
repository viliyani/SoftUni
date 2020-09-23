using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double neededBudget = double.Parse(Console.ReadLine());

            double currentBudget = 0;
            bool flag = false;

            while (true)
            {
                while (currentBudget < neededBudget)
                {
                    string input = Console.ReadLine();
                    if (input == "End")
                    {
                        flag = true;
                    }
                    double amount = double.Parse(input);
                    currentBudget += amount;
                }

                if (flag == true)
                {
                    break;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }

                neededBudget = double.Parse(Console.ReadLine());
                currentBudget = 0;
            }
        }
    }
}