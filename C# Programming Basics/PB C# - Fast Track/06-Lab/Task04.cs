using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (true)
            {
                if (n < num)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(num);
                    num = num * 2 + 1;
                }
            }
        }
    }
}