using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            int cnt = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            cnt++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

            }

            Console.WriteLine($"{cnt} cars passed the crossroads.");

        }
    }
}
