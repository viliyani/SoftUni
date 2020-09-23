using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();

            while (true)
            {
                string text = Console.ReadLine();
                if (text == pass)
                {
                    Console.WriteLine($"Welcome {user}!");
                    break;
                }
            }
        }
    }
}