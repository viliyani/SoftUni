using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double numCm = double.Parse(Console.ReadLine());
            double numInch = numCm * 2.54;

            Console.WriteLine(numInch);
        }
    }
}