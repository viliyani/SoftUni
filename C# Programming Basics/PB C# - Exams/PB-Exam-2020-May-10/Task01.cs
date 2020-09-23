using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int tasks = int.Parse(Console.ReadLine());

            double submissions = students * Math.Ceiling((tasks * 2.8));
            submissions += students * Math.Floor(tasks * 1.0 / 3);

            double memory = Math.Ceiling(submissions / 10) * 5;

            Console.WriteLine($"{memory} KB needed");
            Console.WriteLine($"{submissions} submissions");
        }
    }
}