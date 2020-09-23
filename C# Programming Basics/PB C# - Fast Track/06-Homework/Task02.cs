using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());

            string name = "";
            string lastName;
            int poorCounter = 0;
            int gradesCounter = 0;
            bool stopped = false;
            double sum = 0;

            while (true)
            {
                lastName = name;
                name = Console.ReadLine();
                if (name == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorCounter++;
                    if (poorCounter == poorGrades)
                    {
                        stopped = true;
                        break;
                    }
                }
                sum += grade;
                gradesCounter++;
            }

            if (stopped == true)
            {
                Console.WriteLine("You need a break, {0} poor grades.", poorGrades);
            }
            else
            {
                Console.WriteLine("Average score: {0:F2}", (sum / gradesCounter));
                Console.WriteLine("Number of problems: {0}", gradesCounter);
                Console.WriteLine("Last problem: {0}", lastName);
            }
        }
    }
}