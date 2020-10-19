using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                int min = int.MaxValue;
                bool isFound = false;

                while (stack.Count > 0)
                {
                    int num = stack.Pop();

                    if (num == x)
                    {
                        isFound = true;
                        break;
                    }
                    else
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                }

                if (isFound == false)
                {
                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
