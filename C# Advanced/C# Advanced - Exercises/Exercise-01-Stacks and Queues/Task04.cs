using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            int max = int.MinValue;

            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();

                if (foodQuantity - currentOrder >= 0)
                {
                    foodQuantity -= currentOrder;
                    queue.Dequeue();

                    if (currentOrder > max)
                    {
                        max = currentOrder;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(max);

            if (queue.Count > 0)
            {
                Console.WriteLine("Orders left: {0}", String.Join(" ", queue.ToArray()));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
