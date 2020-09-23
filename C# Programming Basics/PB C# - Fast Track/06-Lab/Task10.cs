using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;
            int usedSpace = 0;

            string input = "";
            bool stopped = false;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int num = int.Parse(input);

                usedSpace += num;
                if (usedSpace > freeSpace)
                {
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", (usedSpace - freeSpace));
                    stopped = true;
                    break;
                }
            }

            if (stopped == false)
            {
                Console.WriteLine("{0} Cubic meters left.", (freeSpace - usedSpace));
            }
        }
    }
}