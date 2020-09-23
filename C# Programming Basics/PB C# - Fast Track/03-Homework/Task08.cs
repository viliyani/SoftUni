using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double awardSocial = 0;
            double awardSuccess = 0;

            if (income < minSalary && mark > 4.5)
            {
                awardSocial = minSalary * 0.35;
            }

            if (mark >= 5.5)
            {
                awardSuccess = mark * 25;
            }

            awardSocial = Math.Floor(awardSocial);
            awardSuccess = Math.Floor(awardSuccess);

            if (awardSuccess >= awardSocial && awardSuccess > 0)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", awardSuccess);
            }
            else if (awardSocial > awardSuccess && awardSocial > 0)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", awardSocial);
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}