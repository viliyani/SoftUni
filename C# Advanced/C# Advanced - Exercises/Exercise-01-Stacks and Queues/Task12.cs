using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> cups = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse().ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int wastedWater = 0;
            int bottleRemaining = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int cup = cups.Pop();
                int bottle = bottles.Pop();
                int totalBottle = bottleRemaining + bottle;
                bottleRemaining = 0;

                if (cup > bottle)
                {
                    int remaining = cup - bottle;
                    cups.Push(remaining);
                }
                else
                {
                    wastedWater += bottle - cup;
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups.ToArray())}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles.ToArray())}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");

        }
    }
}
