using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> box1 = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> box2 = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            List<int> collected = new List<int>();

            while (box1.Count > 0 && box2.Count > 0)
            {
                if ((box1.Peek() + box2.Peek()) % 2 == 0)
                {
                    collected.Add(box1.Dequeue() + box2.Pop());
                }
                else
                {
                    box1.Enqueue(box2.Pop());
                }
            }

            if (box1.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (box2.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int totalSum = collected.Sum(x => x);

            if (totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
