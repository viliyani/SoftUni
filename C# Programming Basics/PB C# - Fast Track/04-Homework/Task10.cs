using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - h;
            weekendsInSofia = weekendsInSofia * 0.75;

            double total = h + weekendsInSofia + (0.67 * p);

            if (year == "leap")
            {
                total = total * 1.15;
            }

            Console.WriteLine(Math.Floor(total));
        }
    }
}