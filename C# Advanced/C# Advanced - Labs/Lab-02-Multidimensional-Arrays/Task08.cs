using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            string direction = "down";

            int row = 0;
            int col = -1;

            int steps = n - 1;
            int repeat = 0;
            int num = 1;

            for (int i = 0; i < n; i++)
            {
                matrix[row, ++col] = num++;
            }

            int to = n * n - n;

            for (int i = 0; i < to; i++)
            {
                if (direction == "right")
                {
                    for (int j = 0; j < steps; j++)
                    {
                        matrix[row, ++col] = num++;
                    }

                    direction = "down";
                }
                else if (direction == "down")
                {
                    for (int j = 0; j < steps; j++)
                    {
                        matrix[++row, col] = num++;
                    }

                    direction = "left";
                }
                else if (direction == "left")
                {
                    for (int j = 0; j < steps; j++)
                    {
                        matrix[row, --col] = num++;
                    }

                    direction = "up";
                }
                else if (direction == "up")
                {
                    for (int j = 0; j < steps; j++)
                    {
                        matrix[--row, col] = num++;
                    }

                    direction = "right";
                }

                repeat++;
                if (repeat == 2)
                {
                    repeat = 0;
                    steps--;
                }
            }

            PrintMatrix(matrix);

        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
