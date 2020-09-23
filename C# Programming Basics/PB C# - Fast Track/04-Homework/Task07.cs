using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            if (op == "+")
            {
                int result = n1 + n2;
                string parity = "";
                if (result % 2 == 0)
                {
                    parity = "even";
                }
                else
                {
                    parity = "odd";
                }
                Console.WriteLine($"{n1} {op} {n2} = {result} - {parity}");
            }
            else if (op == "-")
            {
                int result = n1 - n2;
                string parity = "";
                if (result % 2 == 0)
                {
                    parity = "even";
                }
                else
                {
                    parity = "odd";
                }
                Console.WriteLine($"{n1} {op} {n2} = {result} - {parity}");
            }
            else if (op == "*")
            {
                int result = n1 * n2;
                string parity = "";
                if (result % 2 == 0)
                {
                    parity = "even";
                }
                else
                {
                    parity = "odd";
                }
                Console.WriteLine($"{n1} {op} {n2} = {result} - {parity}");
            }
            else if (op == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double result = (n1 * 1.0) / (n2 * 1.0);
                    Console.WriteLine($"{n1} {op} {n2} = {result:F2}");
                }
            }
            else if (op == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    int result = n1 % n2;
                    Console.WriteLine($"{n1} {op} {n2} = {result}");
                }
            }
        }
    }
}