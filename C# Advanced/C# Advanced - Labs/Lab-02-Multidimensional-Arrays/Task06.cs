using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = ReadJaggedArray(rows);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] options = input.Split();

                int r = int.Parse(options[1]);
                int c = int.Parse(options[2]);
                int val = int.Parse(options[3]);

                if (IsValidCoordinates(matrix, r, c))
                {
                    if (options[0] == "Add")
                    {
                        matrix[r][c] += val;
                    }
                    else if (options[0] == "Subtract")
                    {
                        matrix[r][c] -= val;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            PrintJaggedArray(matrix);
        }

        static bool IsValidCoordinates(int[][] matrix, int r, int c)
        {
            if (!(r >= 0 && r < matrix.Length))
            {
                return false;
            }

            if (c < 0)
            {
                return false;
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                if (!(c >= 0 && c < matrix[row].Length))
                {
                    return false;
                }
            }

            return true;
        }

        static void PrintJaggedArray(int[][] matrix)
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

        static int[][] ReadJaggedArray(int rows)
        {
            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] elements = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None).Select(int.Parse).ToArray();

                matrix[row] = new int[elements.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = elements[col];
                }
            }

            return matrix;
        }

    }
}
