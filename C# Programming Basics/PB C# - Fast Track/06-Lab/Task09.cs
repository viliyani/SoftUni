using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int i = 1;
            int stops = 0;
            int stoppedYear = 0;
            double total = 0;

            while (i <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    stops++;
                    if (stops == 2)
                    {
                        stoppedYear = i;
                        break;
                    }
                    continue;
                }
                stops = 0;
                total += grade;
                i++;
            }

            double avg = total / 12;

            if (stoppedYear != 0)
            {
                Console.WriteLine("{0} has been excluded at {1} grade", name, stoppedYear);
            }
            else
            {
                Console.WriteLine("{0} graduated. Average grade: {1:F2}", name, avg);
            }
        }
    }
}