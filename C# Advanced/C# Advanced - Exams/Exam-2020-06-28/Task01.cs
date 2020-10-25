using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray());
            Stack<int> casigns = new Stack<int>(Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray());

            int bomb40 = 0;
            int bomb60 = 0;
            int bomb120 = 0;

            while (effects.Count > 0 && casigns.Count > 0)
            {
                int sum = effects.Peek() + casigns.Peek();

                bool hasBomb = false;

                if (sum == 40)
                {
                    hasBomb = true;
                    bomb40++;
                }
                else if (sum == 60)
                {
                    hasBomb = true;
                    bomb60++;
                }
                else if (sum == 120)
                {
                    hasBomb = true;
                    bomb120++;
                }

                if (hasBomb)
                {
                    effects.Dequeue();
                    casigns.Pop();
                }
                else
                {
                    casigns.Push(casigns.Pop() - 5);
                }

                if (bomb40 > 2 && bomb60 > 2 && bomb120 > 2)
                {
                    break;
                }
            }

            if (bomb40 > 2 && bomb60 > 2 && bomb120 > 2)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine("Bomb Effects: {0}", String.Join(", ", effects));
            }

            if (casigns.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine("Bomb Casings: {0}", String.Join(", ", casigns));
            }

            Console.WriteLine($"Cherry Bombs: {bomb60}");
            Console.WriteLine($"Datura Bombs: {bomb40}");
            Console.WriteLine($"Smoke Decoy Bombs: {bomb120}");
        }
    }
}
