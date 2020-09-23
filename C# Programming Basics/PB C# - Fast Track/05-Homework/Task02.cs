using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num;
            int max = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    sum += max;
                    max = num;
                }
                else
                {
                    sum += num;
                }
            }

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sum-max));
            }

        }
    }
}