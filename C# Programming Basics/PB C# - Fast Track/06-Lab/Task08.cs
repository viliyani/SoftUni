using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int i = 0;
            double total = 0;

            while (i < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    continue;
                }
                total += grade;
                i++;
            }

            double avg = total / 12;

            Console.WriteLine("{0} graduated. Average grade: {1:F2}", name, avg);
        }
    }
}