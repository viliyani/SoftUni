using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Bomb
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Bomb(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(n, n);

            List<Bomb> bombs = new List<Bomb>();

            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                string[] info = item.Split(',');

                bombs.Add(new Bomb(int.Parse(info[0]), int.Parse(info[1])));
            }

            foreach (var bomb in bombs)
            {
                DoExplosion(matrix, bomb);
            }

            PrintActiveBombsAndSum(matrix);
            PrintMatrix(matrix);
        }

        static void PrintActiveBombsAndSum(int[,] matrix)
        {
            int counter = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        counter++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {counter}");
            Console.WriteLine($"Sum: {sum}");
        }

        static void DoExplosion(int[,] matrix, Bomb bomb)
        {
            int row = bomb.Row;
            int col = bomb.Col;

            if (IsValidPosition(matrix, row, col))
            {

                if (IsValidPosition(matrix, row - 1, col - 1))
                {
                    matrix[row - 1, col - 1] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row - 1, col))
                {
                    matrix[row - 1, col] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row - 1, col + 1))
                {
                    matrix[row - 1, col + 1] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row, col - 1))
                {
                    matrix[row, col - 1] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row, col + 1))
                {
                    matrix[row, col + 1] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row + 1, col - 1))
                {
                    matrix[row + 1, col - 1] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row + 1, col))
                {
                    matrix[row + 1, col] -= matrix[row, col];
                }

                if (IsValidPosition(matrix, row + 1, col + 1))
                {
                    matrix[row + 1, col + 1] -= matrix[row, col];
                }

                matrix[row, col] = 0;
            }
        }

        static bool IsValidPosition(int[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                if (matrix[row, col] > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
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

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
