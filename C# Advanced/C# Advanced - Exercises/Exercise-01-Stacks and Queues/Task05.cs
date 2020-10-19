using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());
            int racksCount = 0;

            int currentRackSize = 0;

            while (queue.Count > 0)
            {
                int currentBox = queue.Dequeue();

                if (currentRackSize + currentBox > rackCapacity)
                {
                    racksCount++;
                    currentRackSize = currentBox;
                }
                else if (currentRackSize + currentBox == rackCapacity)
                {
                    racksCount++;
                    currentRackSize = 0;
                }
                else
                {
                    currentRackSize += currentBox;
                }

            }

            if (currentRackSize > 0)
            {
                racksCount++;
            }

            Console.WriteLine(racksCount);

        }
    }
}
