using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int mask = 7 << p;

            n = n ^ mask;

            Console.WriteLine(n);
        }
    }
}
