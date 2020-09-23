using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int animalsCount = int.Parse(Console.ReadLine());

            double price = dogsCount * 2.50 + animalsCount * 4;
            string result = String.Format("{0:0.00}", price);
            Console.WriteLine($"{result} lv.");
        }
    }
}