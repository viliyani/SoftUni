using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);

            List<int> result = new List<int>();

            while (queue.Count > 0)
            {
                int num = queue.Dequeue();

                if (num % 2 == 0)
                {
                    result.Add(num);
                }

            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
