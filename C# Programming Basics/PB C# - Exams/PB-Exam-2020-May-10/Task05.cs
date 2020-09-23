using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int tasks = int.Parse(Console.ReadLine());
            int enegergy = int.Parse(Console.ReadLine());

            int totalTasksSolved = 0;
            int totalQuestionsAnswered = 0;

            int currentQuestions = 0;
            int inputTasks = tasks;

            while (true)
            {
                totalTasksSolved += tasks;
                enegergy += tasks * 2;
                students -= tasks;

                currentQuestions = students * 2;
                totalQuestionsAnswered += currentQuestions;

                enegergy -= currentQuestions * 3;

                if (students < 10)
                {
                    Console.WriteLine("The students are too few!");
                    Console.WriteLine($"Problems solved: {totalTasksSolved}");
                    return;
                }

                if (enegergy < 0)
                {
                    Console.WriteLine("The trainer is too tired!");
                    Console.WriteLine($"Questions answered: {totalQuestionsAnswered}");
                    return;
                }

                students += students / 10;
            }
        }
    }
}