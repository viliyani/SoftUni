using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int breadCounter = int.Parse(Console.ReadLine());
            int barkCounter = int.Parse(Console.ReadLine());
            int kilograms = int.Parse(Console.ReadLine());

            double total = (breadCounter * 3.20) + (barkCounter * 4.35) + (kilograms * 5.40) + ((barkCounter * 12) * 0.15);

            Console.WriteLine($"{total:F2}");
        }
    }
}