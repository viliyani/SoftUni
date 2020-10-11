using System;

namespace ImplementingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            list.ForEach();

            Console.WriteLine();
            Console.WriteLine(String.Join("-", list.ToArray()));

            list.RemoveFirst();
            list.RemoveLast();

            Console.WriteLine(String.Join("-", list.ToArray()));
        }
    }
}
