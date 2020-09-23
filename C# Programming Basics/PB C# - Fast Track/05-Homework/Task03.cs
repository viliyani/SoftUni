using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double num;
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
                else
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMin != int.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }
            if (oddMax != int.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenMin != int.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }

            if (evenMax != int.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }

        }
    }
}