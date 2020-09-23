using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            for (int i = 0; i < input.Count / 2; i++)
            {
                string temp = input[i];
                input[i] = input[input.Count - 1 - i];
                input[input.Count - 1 - i] = temp;
            }

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    stack.Push((first+second).ToString());
                }
                else if (sign == "-")
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
