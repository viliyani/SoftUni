using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainingPrice = int.Parse(Console.ReadLine());

            double shoesPrice = trainingPrice * 0.6;
            double teamPrice = shoesPrice * 0.8;
            double ballPrice = teamPrice * 0.25;
            double accPrice = ballPrice * 0.2;

            double total = trainingPrice + shoesPrice + teamPrice + ballPrice + accPrice;

            Console.WriteLine("{0:F2}", total);
        }
    }
}