using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                {
                    break;
                }

                string[] options = input.Split();

                if (options[0] == "add")
                {
                    stack.Push(int.Parse(options[1]));
                    stack.Push(int.Parse(options[2]));
                }
                else if (options[0] == "remove")
                {
                    int cnt = int.Parse(options[1]);

                    if (cnt <= stack.Count)
                    {
                        for (int i = 0; i < cnt; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

            }

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
