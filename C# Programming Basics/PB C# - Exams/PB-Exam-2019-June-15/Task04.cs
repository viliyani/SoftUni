using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSeats = int.Parse(Console.ReadLine());

            int totalPeople = 0;
            bool isFull = false;
            int income = 0;
            string input = Console.ReadLine();

            while (input != "Movie time!")
            {
                int currentPeople = int.Parse(input);

                if (currentPeople + totalPeople > freeSeats)
                {
                    isFull = true;
                    break;
                }

                totalPeople += currentPeople;
                income += currentPeople * 5;

                if (currentPeople % 3 == 0)
                {
                    income -= 5;
                }

                input = Console.ReadLine();
            }

            if (isFull)
            {
                Console.WriteLine("The cinema is full.");
            }
            else
            {
                Console.WriteLine($"There are {freeSeats - totalPeople} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}