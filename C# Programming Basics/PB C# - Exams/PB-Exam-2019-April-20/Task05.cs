using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int redCounter = 0;
            int orangeCounter = 0;
            int blueCounter = 0;
            int greenCounter = 0;

            for (int i = 0; i < n; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    redCounter++;
                }
                else if (color == "orange")
                {
                    orangeCounter++;
                }
                else if (color == "blue")
                {
                    blueCounter++;
                }
                else if (color == "green")
                {
                    greenCounter++;
                }
            }

            int total = redCounter + orangeCounter + blueCounter + greenCounter;

            int max = redCounter;
            string maxColor = "red";
            if (orangeCounter > max)
            {
                max = orangeCounter;
                maxColor = "orange";
            }
            if (blueCounter > max)
            {
                max = blueCounter;
                maxColor = "blue";
            }
            if (greenCounter > max)
            {
                max = greenCounter;
                maxColor = "green";
            }

            Console.WriteLine($"Red eggs: {redCounter}");
            Console.WriteLine($"Orange eggs: {orangeCounter}");
            Console.WriteLine($"Blue eggs: {blueCounter}");
            Console.WriteLine($"Green eggs: {greenCounter}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");
        }
    }
}