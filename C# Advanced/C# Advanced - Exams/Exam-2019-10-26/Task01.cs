using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            int matches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int male = males.Peek();
                int female = females.Peek();

                if (male <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (female <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (male % 25 == 0)
                {
                    males.Pop();

                    if (males.Count > 0)
                    {
                        males.Pop();
                    }

                    continue;
                }

                if (female % 25 == 0)
                {
                    females.Dequeue();

                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }

                    continue;
                }

                if (male == female)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    males.Push(males.Pop() - 2);
                    females.Dequeue();
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Count > 0)
            {
                Console.WriteLine($"Males left: {String.Join(' ', males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Count > 0)
            {
                Console.WriteLine($"Females left: {String.Join(' ', females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }

        }
    }
}
