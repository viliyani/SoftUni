using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());

            int current = goal - 35;
            int counter = 0;

            bool flagFail = false;

            while (!flagFail)
            {
                current += 5;
                flagFail = true;
                int jump = 0;

                for (int i = 0; i < 3; i++)
                {
                    jump = int.Parse(Console.ReadLine());
                    counter++;

                    if (jump > current)
                    {
                        if (current >= goal)
                        {
                            Console.WriteLine("Tihomir succeeded, he jumped over {0}cm after {1} jumps.", goal, counter);
                            return;
                        }
                        flagFail = false;
                        break;
                    }
                    
                }
            }

            Console.WriteLine("Tihomir failed at {0}cm after {1} jumps.", (current), counter);
        }
    }
}