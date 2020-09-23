using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int passangersCount = int.Parse(Console.ReadLine());
            int stationsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stationsCount; i++)
            {
                int passangersDown = int.Parse(Console.ReadLine());
                int passangersUp = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    passangersDown += 2;
                }
                else
                {
                    passangersUp += 2;
                }

                passangersCount -= passangersDown;
                passangersCount += passangersUp;
            }

            Console.WriteLine($"The final number of passengers is : {passangersCount}");
        }
    }
}