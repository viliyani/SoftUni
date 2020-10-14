using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bitAtPosition = -1;

            n = n >> p;

            bitAtPosition = n & 1;

            Console.WriteLine(bitAtPosition);
        }
    }
}
