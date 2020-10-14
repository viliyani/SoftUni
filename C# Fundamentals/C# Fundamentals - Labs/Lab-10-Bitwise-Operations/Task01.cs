using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int binaryDigit = int.Parse(Console.ReadLine());

            List<int> binaryNumber = new List<int>();

            int reminder = 0;

            while (decimalNumber != 0)
            {
                reminder = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binaryNumber.Add(reminder);
            }

            binaryNumber.Reverse();

            int counter = 0;

            for (int i = 0; i < binaryNumber.Count; i++)
            {
                if (binaryNumber[i] == binaryDigit)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
