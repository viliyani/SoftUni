using System;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            string snake = Console.ReadLine();

            char[,] matrix = new char[rows, cols];

            StringBuilder sb = new StringBuilder();

            int idx = 0;
            for (int i = 0; i < rows * cols; i++)
            {
                if (idx == snake.Length)
                {
                    idx = 0;
                }

                sb.Append(snake[idx++]);
            }

            string fillString = sb.ToString();
            idx = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = fillString[idx++];
                    }
                }
                else
                {
                    for (int col = cols-1; col >= 0; col--)
                    {
                        matrix[row, col] = fillString[idx++];
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
