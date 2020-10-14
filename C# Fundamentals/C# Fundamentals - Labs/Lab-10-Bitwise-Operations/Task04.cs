using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int a = 1;
            a = a << p;
            a = ~a;

            n = n & a;

            Console.WriteLine(n);

        }
    }
}
