using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double totalSum = 0;
            int presentationsCounter = 0;

            while (presentationName != "Finish")
            {

                // Marks
                double currentSum = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double currentMark = double.Parse(Console.ReadLine());
                    currentSum += currentMark;
                }

                totalSum += currentSum / juryCount;
                presentationsCounter++;

                Console.WriteLine("{0} - {1:F2}.", presentationName, (currentSum / juryCount));

                presentationName = Console.ReadLine();
            }

            Console.WriteLine("Student's final assessment is {0:F2}.", (totalSum / presentationsCounter));
        }
    }
}