using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> barrel = new Queue<int>();

            for (int i = 0; i < gunSize; i++)
            {
                if (bullets.Count > 0)
                {
                    barrel.Enqueue(bullets.Pop());
                }
            }

            int bulletsCounter = 0;

            while ((bullets.Count > 0 || barrel.Count > 0) && locks.Count > 0)
            {
                if (barrel.Count > 0)
                {
                    if (barrel.Peek() > locks.Peek())
                    {
                        Console.WriteLine("Ping!");
                        barrel.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Bang!");
                        barrel.Dequeue();
                        locks.Dequeue();
                    }
                    bulletsCounter++;
                }

                if (barrel.Count == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    for (int i = 0; i < gunSize; i++)
                    {
                        if (bullets.Count > 0)
                        {
                            barrel.Enqueue(bullets.Pop());
                        }
                    }
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count + barrel.Count} bullets left. Earned ${intelligence - (bulletsCounter * bulletPrice)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

        }
    }
}
