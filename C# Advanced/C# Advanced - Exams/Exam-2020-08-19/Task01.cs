using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray());
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray());

            int wreathCount = 0;
            int flowersStored = 0;

            while (roses.Count > 0 && lilies.Count > 0)
            {
                int sum = roses.Peek() + lilies.Peek();

                if (sum == 15)
                {
                    wreathCount++;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else if (sum > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                }
                else if (sum < 15)
                {
                    flowersStored += sum;
                    roses.Dequeue();
                    lilies.Pop();
                }
            }

            wreathCount += flowersStored / 15;

            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }
        }
    }
}
