using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
