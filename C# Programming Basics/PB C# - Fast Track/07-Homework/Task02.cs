using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;
            int temp;
            bool isEven = false;

            for (int i = a; i <= b; i++)
            {
                sumEven = 0;
                sumOdd = 0;
                temp = i;

                while (temp > 0)
                {
                    int lastDigit = temp % 10;
                    temp = temp / 10;

                    if (isEven == true)
                    {
                        sumEven += lastDigit;
                        isEven = false;
                    }
                    else
                    {
                        sumOdd += lastDigit;
                        isEven = true;
                    }
                }

                if (sumEven == sumOdd)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}