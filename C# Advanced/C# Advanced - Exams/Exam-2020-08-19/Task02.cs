using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static int beeRow = -1;
        static int beeCol = -1;
        static int flowersCollected = 0;
        static bool isLost = false;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (!Move(matrix, command))
                {
                    break;
                }
            }

            if (isLost)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (flowersCollected >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersCollected} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowersCollected} flowers more");
            }
            PrintMatrix(matrix);
        }

        static bool Move(char[,] matrix, string command)
        {
            matrix[beeRow, beeCol] = '.';

            if (command == "up")
            {
                beeRow--;
            }
            else if (command == "down")
            {
                beeRow++;
            }
            else if (command == "left")
            {
                beeCol--;
            }
            else if (command == "right")
            {
                beeCol++;
            }

            if (!IsValid(matrix, beeRow, beeCol))
            {
                isLost = true;
                return false;
            }

            if (matrix[beeRow, beeCol] == 'f')
            {
                flowersCollected++;
            }

            if (matrix[beeRow, beeCol] == 'O')
            {
                Move(matrix, command);
            }

            matrix[beeRow, beeCol] = 'B';

            return true;
        }

        static bool IsValid(char[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }

            if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
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
