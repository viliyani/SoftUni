using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int final = int.Parse(Console.ReadLine());
                    steps += final;
                    break;
                }

                int current = int.Parse(input);
                steps += current;

                if (steps >= 10000)
                {
                    break;
                }
            }

            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine("{0} more steps to reach goal.", (10000 - steps));
            }
        }
    }
}