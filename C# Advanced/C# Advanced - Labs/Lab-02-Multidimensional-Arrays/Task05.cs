using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = ReadMatrix(rows, cols);

            int[,] bestSubMatrix = new int[2, 2];
            int[,] currentSubMatrix = new int[2, 2];
            int bestSum = 0;
            int currentSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSubMatrix[0, 0] = matrix[row, col];
                    currentSubMatrix[0, 1] = matrix[row, col + 1];
                    currentSubMatrix[1, 0] = matrix[row + 1, col];
                    currentSubMatrix[1, 1] = matrix[row + 1, col + 1];

                    currentSum = CalculateMatrixSum(currentSubMatrix);

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestSubMatrix = (int[,])currentSubMatrix.Clone();
                    }
                }
            }

            PrintMatrix(bestSubMatrix);
            Console.WriteLine(bestSum);
        }

        static int CalculateMatrixSum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
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
