using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int secs1 = int.Parse(Console.ReadLine());
            int secs2 = int.Parse(Console.ReadLine());
            int secs3 = int.Parse(Console.ReadLine());

            int total = secs1 + secs2 + secs3;

            int minutes = total / 60;
            int seconds = total % 60;

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}