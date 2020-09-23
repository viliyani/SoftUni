using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int task = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();

            int coef = 0;

            if (task == 1)
            {
                switch (course)
                {
                    case "Basics":
                        coef = 8;
                        break;
                    case "Fundamentals":
                        coef = 11;
                        break;
                    case "Advanced":
                        coef = 14;
                        break;
                }
            }
            else if (task == 2)
            {
                switch (course)
                {
                    case "Basics":
                        coef = 9;
                        break;
                    case "Fundamentals":
                        coef = 11;
                        break;
                    case "Advanced":
                        coef = 14;
                        break;
                }
            }
            else if (task == 3)
            {
                switch (course)
                {
                    case "Basics":
                        coef = 9;
                        break;
                    case "Fundamentals":
                        coef = 12;
                        break;
                    case "Advanced":
                        coef = 15;
                        break;
                }
            }
            else if (task == 4)
            {
                switch (course)
                {
                    case "Basics":
                        coef = 10;
                        break;
                    case "Fundamentals":
                        coef = 13;
                        break;
                    case "Advanced":
                        coef = 16;
                        break;
                }
            }

            double total = points * 1.0 * (coef * 1.0 / 100);

            if (course == "Advanced")
            {
                total += total * 0.20;
            }

            if (course == "Basics" && task == 1)
            {
                total -= total * 0.20;
            }

            Console.WriteLine($"Total points: {total:f2}");
        }
    }
}