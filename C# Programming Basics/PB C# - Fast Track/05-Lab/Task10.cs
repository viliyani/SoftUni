using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int num;
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(evenSum - oddSum));
            }
        }
    }
}