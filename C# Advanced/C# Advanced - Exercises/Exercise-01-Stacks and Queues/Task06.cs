using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            Queue<string> queue = new Queue<string>();

            foreach (var item in songs)
            {
                if (!queue.Contains(item))
                {
                    queue.Enqueue(item);
                }
            }

            while (queue.Count > 0)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if (input[0] == "Add")
                {
                    string song = input[1];

                    for (int i = 2; i < input.Length; i++)
                    {
                        song += " " + input[i];
                    }

                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (input[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue.ToArray()));
                }
            }

            Console.WriteLine("No more songs!");

        }
    }
}
