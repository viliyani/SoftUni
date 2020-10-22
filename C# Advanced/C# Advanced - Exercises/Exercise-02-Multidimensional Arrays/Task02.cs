using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            char[,] matrix = ReadMatrix(rows, cols);

            Console.WriteLine(FindSubMatrixEqualsCharsCount(matrix));
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(elements[col]);
                }
            }

            return matrix;
        }

        static int FindSubMatrixEqualsCharsCount(char[,] matrix)
        {
            int count = 0;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char c1 = matrix[row, col];
                    char c2 = matrix[row, col + 1];
                    char c3 = matrix[row + 1, col];
                    char c4 = matrix[row + 1, col + 1];

                    if (c1 == c2 && c2 == c3 && c3 == c4)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
