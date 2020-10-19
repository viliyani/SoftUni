using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] options = input.Split();

                if (options[0] == "1")
                {
                    stack.Push(sb.ToString());
                    sb.Append(input.Substring(2, input.Length - 2));
                }
                else if (options[0] == "2")
                {
                    stack.Push(sb.ToString());
                    int x = int.Parse(options[1]);
                    sb.Remove(sb.Length - x, x);
                }
                else if (options[0] == "3")
                {
                    int x = int.Parse(options[1]);
                    Console.WriteLine(sb[x-1]);
                }
                else if (options[0] == "4")
                {
                    sb.Clear();
                    sb.Append(stack.Pop());
                }
            }

        }
    }
}
