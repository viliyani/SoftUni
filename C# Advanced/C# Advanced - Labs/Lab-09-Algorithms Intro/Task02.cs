using System;
using System.Linq;

namespace AlgorithmsIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(x));
        }

        private static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            return x * Factorial(x - 1);
        }
    }
}
