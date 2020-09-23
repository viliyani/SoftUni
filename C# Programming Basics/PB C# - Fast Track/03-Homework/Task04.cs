using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputUnit == "m" && outputUnit == "cm")
            {
                Console.WriteLine("{0:F3}", number * 100);
            }
            else if (inputUnit == "m" && outputUnit == "mm")
            {
                Console.WriteLine("{0:F3}",  number * 1000);
            }
            else if (inputUnit == "cm" && outputUnit == "mm")
            {
                Console.WriteLine("{0:F3}",  number * 10);
            }
            else if (inputUnit == "cm" && outputUnit == "m")
            {
                Console.WriteLine("{0:F3}", number / 100);
            }
            else if (inputUnit == "mm" && outputUnit == "m")
            {
                Console.WriteLine("{0:F3}", number / 1000);
            }
            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                Console.WriteLine("{0:F3}", number / 10);
            }
        }
    }
}