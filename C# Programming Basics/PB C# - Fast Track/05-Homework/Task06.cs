using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            string site = "";
            int fine = 0;

            for (int i = 0; i < n; i++)
            {
                site = Console.ReadLine();

                if (site == "Facebook")
                {
                    fine += 150;
                }
                else if (site == "Instagram")
                {
                    fine += 100;
                }
                else if (site == "Reddit")
                {
                    fine += 50;
                }
            }

            if (fine >= salary)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine("{0}", salary - fine);
            }
        }
    }
}