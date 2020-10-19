using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool flag = false;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        char d = stack.Pop();

                        if ((c == '}' && d != '{') || (c == ']' && d != '[') || (c == ')' && d != '('))
                        {
                            flag = true;
                            break;
                        }
                    }
                }
            }

            if (!flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
