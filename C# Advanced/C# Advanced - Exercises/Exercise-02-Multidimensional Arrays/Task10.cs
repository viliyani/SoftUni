using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }

    class Program
    {
        static private bool gameOver = false;
        static private int playerRow = 0;
        static private int playerCol = 0;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var command in commands)
            {
                SpreadBunnies(matrix);

                int directionRow = playerRow;
                int directionCol = playerCol;

                if (command == 'U')
                {
                    directionRow--;
                }
                else if (command == 'D')
                {
                    directionRow++;
                }
                else if (command == 'L')
                {
                    directionCol--;
                }
                else if (command == 'R')
                {
                    directionCol++;
                }

                if (!(directionRow >= 0 && directionRow < matrix.GetLength(0) && directionCol >= 0 && directionCol < matrix.GetLength(1)))
                {
                    // player wins
                    matrix[playerRow, playerCol] = '.';

                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }
                else if (directionRow >= 0 && directionRow < matrix.GetLength(0) && directionCol >= 0 && directionCol < matrix.GetLength(1) && matrix[directionRow,directionCol] == '.')
                {
                    // free move
                    Swap(matrix, playerRow, playerCol, directionRow, directionCol);
                    playerRow = directionRow;
                    playerCol = directionCol;
                }
                else if (directionRow >= 0 && directionRow < matrix.GetLength(0) && directionCol >= 0 && directionCol < matrix.GetLength(1) && matrix[directionRow, directionCol] == 'B')
                {
                    // game over
                    gameOver = true;

                    matrix[playerRow, playerCol] = 'B';

                    playerRow = directionRow;
                    playerCol = directionCol;
                }

                if (gameOver)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return;
                }
            }

        }

        static void Swap(char[,] matrix, int row1, int col1, int row2, int col2)
        {
            char temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;
        }

        static void SpreadBunnies(char[,] matrix)
        {
            List<Position> positions = new List<Position>();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        positions.Add(new Position(row, col));
                    }
                }
            }

            foreach (var position in positions)
            {
                int pRow = position.Row;
                int pCol = position.Col;

                // up
                if (IsValidPosition(matrix, pRow - 1, pCol))
                {
                    matrix[pRow - 1, pCol] = 'B';
                }
                // down
                if (IsValidPosition(matrix, pRow + 1, pCol))
                {
                    matrix[pRow + 1, pCol] = 'B';
                }
                // left
                if (IsValidPosition(matrix, pRow, pCol - 1))
                {
                    matrix[pRow, pCol - 1] = 'B';
                }
                // right
                if (IsValidPosition(matrix, pRow, pCol + 1))
                {
                    matrix[pRow, pCol + 1] = 'B';
                }
                
            }

        }

        static bool IsValidPosition(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                if (matrix[row, col] == '.')
                {
                    return true;
                }
                else if (matrix[row,col] == 'P')
                {
                    gameOver = true;
                }
            }
            return false;
        }


        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            return matrix;
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
