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

            long[][] matrix = new long[n][];

            if (n == 1)
            {
                matrix[0] = new long[1];
                matrix[0][0] = 1;
            }
            else if (n > 1)
            {
                matrix[0] = new long[1];
                matrix[0][0] = 1;

                matrix[1] = new long[2];
                matrix[1][0] = 1;
                matrix[1][1] = 1;

                for (int i = 2; i < n; i++)
                {
                    matrix[i] = new long[i + 1];
                    matrix[i][0] = 1;
                    matrix[i][i] = 1;
                    for (int j = 1; j < i; j++)
                    {
                        matrix[i][j] = matrix[i - 1][j] + matrix[i - 1][j - 1];
                    }
                }
            }

            PrintJaggedArray(matrix);
        }

        static void PrintJaggedArray(long[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
