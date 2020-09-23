using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        private static StringBuilder ew;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int from = stack.Pop();
                    int to = i;
                    Console.WriteLine(input.Substring(from, to - from + 1));
                }
            }

        }
    }
}
