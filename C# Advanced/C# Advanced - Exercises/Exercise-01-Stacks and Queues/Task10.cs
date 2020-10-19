using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            int carsCounter = 0;
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "green")
                {
                    if (queue.Count > 0)
                    {
                        int currentGreenLight = greenLightDuration;
                        int currentFreeWindow = freeWindowDuration;

                        while (currentGreenLight > 0 && queue.Count() > 0)
                        {
                            string car = queue.Dequeue();
                            currentGreenLight -= car.Length;

                            if (currentGreenLight >= 0)
                            {
                                carsCounter++;
                            }
                            else
                            {
                                currentFreeWindow += currentGreenLight;

                                if (currentFreeWindow < 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{car} was hit at {car[car.Length + currentFreeWindow]}.");
                                    return;
                                }

                                carsCounter++;
                            }
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsCounter} total cars passed the crossroads.");
        }
    }
}
