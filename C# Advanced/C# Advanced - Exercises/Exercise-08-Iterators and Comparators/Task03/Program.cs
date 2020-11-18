using System;
using System.Linq;

namespace CustomStack
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MyStack stack = new MyStack();

            string[] info = Console.ReadLine().Split();

            foreach (var item in info.Skip(1))
            {
                int element = int.Parse(item.Replace(",", ""));
                stack.Push(element);
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] options = input.Split();

                try
                {
                    if (options[0] == "Pop")
                    {
                        Console.WriteLine(stack.Pop());
                    }
                    else if (options[0] == "Push")
                    {
                        stack.Push(int.Parse(options[1]));
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
