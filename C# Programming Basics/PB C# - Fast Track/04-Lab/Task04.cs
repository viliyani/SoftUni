using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(qty * 0.5);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(qty * 0.4);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(qty * 0.45);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(qty * 0.8);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(qty * 0.7);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(qty * 0.7);
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(qty * 1.20);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(qty * 1.15);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(qty * 1.10);
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(qty * 1.45);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(qty * 1.30);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(qty * 1.35);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(qty * 1.60);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(qty * 1.50);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(qty * 1.55);
                }
            }
        }
    }
}