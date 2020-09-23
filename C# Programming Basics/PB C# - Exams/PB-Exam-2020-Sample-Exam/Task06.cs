using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string textNumber = number.ToString();

            int firstDigit = int.Parse(textNumber[0].ToString());
            int secondDigit = int.Parse(textNumber[1].ToString());
            int thirdDigit = int.Parse(textNumber[2].ToString());

            for (int i = 1; i <= thirdDigit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= firstDigit; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}