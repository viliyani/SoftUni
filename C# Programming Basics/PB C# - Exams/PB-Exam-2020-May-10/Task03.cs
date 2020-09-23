using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int complexity = int.Parse(Console.ReadLine());
            int hardship = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());

            if (complexity >= 80 && hardship >= 80 && pages >= 8)
            {
                Console.WriteLine("Legacy");
            }
            else if (complexity >= 80 && hardship <= 10)
            {
                Console.WriteLine("Master");
            }
            else if (complexity <= 10)
            {
                Console.WriteLine("Elementary");
            }
            else if (complexity <= 30 && pages <= 1)
            {
                Console.WriteLine("Easy");
            }
            else if (hardship >= 50 && pages >= 2)
            {
                Console.WriteLine("Hard");
            }
            else
            {
                Console.WriteLine("Regular");
            }
        }
    }
}