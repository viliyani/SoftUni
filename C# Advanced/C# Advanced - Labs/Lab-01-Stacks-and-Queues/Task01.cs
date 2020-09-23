using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>() { };

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
