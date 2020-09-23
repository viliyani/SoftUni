using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountUSD = double.Parse(Console.ReadLine());

            double amountBGN = amountUSD * 1.79549;
            string result = String.Format("{0:F2}", amountBGN);
            Console.WriteLine(result);
        }
    }
}