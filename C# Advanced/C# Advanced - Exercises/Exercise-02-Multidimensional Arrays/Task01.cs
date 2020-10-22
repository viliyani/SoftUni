using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(n, n);

            int sum1 = FindPrimaryDiagonalSum(matrix);
            int sum2 = FindSecondaryDiagonalSum(matrix);

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }

        static int FindPrimaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
            }

            return sum;
        }

        static int FindSecondaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;

            int n = matrix.GetLength(0);

            for (int row = 0; row < n; row++)
            {
                sum += matrix[row, n - 1 - row];
            }

            return sum;
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            return matrix;
        }
    }
}
