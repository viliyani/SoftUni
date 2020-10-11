using System;
using System.Collections.Generic;

namespace ImplementingDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            for (int i = 1; i < 10; i++)
            {
                list.Add(i);
            }

            list.Print();
            list.InsertAt(4, 111);
            list.Print();

            MyList<string> strings = new MyList<string>();
            strings.Add("Hello");
            strings.Add("Hi");
            strings.Add("Hey");
            strings.Add("Hola");
            strings.Print();

            MyStack stack = new MyStack();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine();

            stack.ForEach(x => Console.WriteLine(x));

        }
    }
}
