using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> stack = new Stack<string>(expression);
            Stack<double> numbers = new Stack<double>();

            PrintStack(stack);

            while (stack.Count > 0)
            {
                string current = stack.Pop();

                while (!IsOperator(current))
                {
                    numbers.Push(double.Parse(current));
                    current = stack.Pop();
                }

                double num1 = numbers.Pop();
                double num2 = numbers.Pop();

                numbers.Push(Solve(num2, num1, current));
            }
        }

        static double Solve(double num1, double num2, string op)
        {
            double result = 0;

            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }

            Console.WriteLine($"{num1} {op} {num2} = {result}");
            return result;
        }

        static bool IsOperator(string op)
        {
            if (op == "+" || op == "-" || op == "/" || op == "*" || op == "(" || op == ")" || op == "^")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
