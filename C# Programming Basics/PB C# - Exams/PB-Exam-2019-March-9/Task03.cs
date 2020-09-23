using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double difficulty = 0.0;
            double feasibility = 0.0;

            if (country == "Russia")
            {
                if (device == "ribbon")
                {
                    difficulty = 9.1;
                    feasibility = 9.4;
                }
                else if (device == "hoop")
                {
                    difficulty = 9.3;
                    feasibility = 9.8;
                }
                else if (device == "rope")
                {
                    difficulty = 9.6;
                    feasibility = 9.0;
                }
            }
            else if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    difficulty = 9.6;
                    feasibility = 9.4;
                }
                else if (device == "hoop")
                {
                    difficulty = 9.55;
                    feasibility = 9.75;
                }
                else if (device == "rope")
                {
                    difficulty = 9.5;
                    feasibility = 9.4;
                }
            }
            else if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    difficulty = 9.2;
                    feasibility = 9.5;
                }
                else if (device == "hoop")
                {
                    difficulty = 9.45;
                    feasibility = 9.35;
                }
                else if (device == "rope")
                {
                    difficulty = 9.7;
                    feasibility = 9.15;
                }
            }

            double total = difficulty + feasibility;
            double percent = 100 - ((total * 100) / 20);

            Console.WriteLine("The team of {0} get {1:F3} on {2}.", country, total, device);
            Console.WriteLine($"{percent:F2}%");
        }
    }
}