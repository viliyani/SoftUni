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

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "1")
                {
                    stack.Push(int.Parse(input[1]));
                }
                else if (input[0] == "2")
                {
                    stack.Pop();
                }
                else if (input[0] == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (input[0] == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine(String.Join(", ", stack.ToArray()));
            }

        }
    }
}
