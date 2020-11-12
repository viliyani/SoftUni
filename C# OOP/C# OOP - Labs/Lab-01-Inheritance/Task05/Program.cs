using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            StackOfStrings stack = new StackOfStrings();

            stack.Push("C#");
            stack.Push("Programming");
            stack.Push("OOP");
            stack.Push("Course");
            stack.Push("Hello");
            stack.Push("World");
            stack.Push("How are you?");
            stack.Push("Pesho");

            stack.AddRange(new List<string> { "My", "custom", "range", "method" });

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
