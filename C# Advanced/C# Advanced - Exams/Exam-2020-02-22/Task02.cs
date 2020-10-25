using System;

namespace Practice
{
    class Program
    {
        static private int rowIdx = 0;
        static private int colIdx = 0;
        static private bool hasWon = false;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];

                    if (matrix[row, col] == 'f')
                    {
                        rowIdx = row;
                        colIdx = col;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                DoMove(matrix, command);

                if (hasWon)
                {
                    Console.WriteLine("Player won!");
                    PrintMatrix(matrix);
                    return;
                }
            }

            Console.WriteLine("Player lost!");
            PrintMatrix(matrix);
        }

        static void DoMove(char[,] matrix, string command)
        {
            int directionRow = rowIdx;
            int directionCol = colIdx;

            if (command == "up")
            {
                directionRow--;

                if (directionRow < 0)
                {
                    directionRow = matrix.GetLength(0) - 1;
                }
            }
            else if (command == "down")
            {
                directionRow++;

                if (directionRow == matrix.GetLength(0))
                {
                    directionRow = 0;
                }
            }
            else if (command == "left")
            {
                directionCol--;

                if (directionCol < 0)
                {
                    directionCol = matrix.GetLength(1) - 1;
                }
            }
            else if (command == "right")
            {
                directionCol++;

                if (directionCol == matrix.GetLength(1))
                {
                    directionCol = 0;
                }
            }

            if (matrix[directionRow, directionCol] == 'F')
            {
                // player won
                matrix[rowIdx, colIdx] = '-';
                matrix[directionRow, directionCol] = 'f';

                hasWon = true;
                return;
            }
            else if (matrix[directionRow, directionCol] == 'B')
            {
                matrix[rowIdx, colIdx] = '-';
                rowIdx = directionRow;
                colIdx = directionCol;
                DoMove(matrix, command);
            }
            else if (matrix[directionRow, directionCol] == '-')
            {
                if (matrix[rowIdx, colIdx] == 'f')
                {
                    matrix[rowIdx, colIdx] = '-';
                }

                matrix[directionRow, directionCol] = 'f';
                rowIdx = directionRow;
                colIdx = directionCol;
            }
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
