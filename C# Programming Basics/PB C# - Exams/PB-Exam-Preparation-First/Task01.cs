using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double commisionRate = double.Parse(Console.ReadLine());

            double leva = bitcoins * 1168;

            double yuansToUSD = yuans * 0.15;

            leva += yuansToUSD * 1.76;

            double euro = leva / 1.95;

            double moneyForCommision = euro * commisionRate * 1.0 / 100;

            euro -= moneyForCommision;

            Console.WriteLine($"{euro:f2}");
        }
    }
}