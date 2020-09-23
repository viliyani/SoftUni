using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            
            while (i < n)
            {
                string found = Console.ReadLine();
                if (book == found)
                {
                    break;
                }
                i++;
            }

            if (i == n)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine("You checked {0} books.", n);
            }
            else
            {
                Console.WriteLine("You checked {0} books and found it.", i);
            }
        }
    }
}