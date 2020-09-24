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

            char[,] matrix = ReadMatrix(n, n);

            char c = char.Parse(Console.ReadLine());

            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == c && isFound == false)
                    {
                        isFound = true;

                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{c} does not occur in the matrix");
            }

        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }

    }
}
