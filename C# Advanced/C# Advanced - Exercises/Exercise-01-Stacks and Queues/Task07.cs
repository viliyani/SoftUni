using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Pump
    {
        public int Amount { get; set; }
        public int Distance { get; set; }
        public int Idx { get; set; }

        public Pump(int amount, int distance, int idx)
        {
            this.Amount = amount;
            this.Distance = distance;
            this.Idx = idx;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pump> queue = new Queue<Pump>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(new Pump(nums[0], nums[1], i));
            }

            int totalFuel = 0;

            for (int i = 0; i < n; i++)
            {
                Pump current = queue.Dequeue();

                var fuel = current.Amount;
                var distance = current.Distance;
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                queue.Enqueue(current);
            }

            Console.WriteLine(queue.Dequeue().Idx);

        }
    }
}
