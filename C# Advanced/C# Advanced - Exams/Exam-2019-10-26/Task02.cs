using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Position
    {
        public int rowIdx { get; set; }

        public int colIdx { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> text = new Stack<char>(Console.ReadLine().ToCharArray());
            int n = int.Parse(Console.ReadLine());

            Position playerPosition = new Position();

            char[,] matrix = ReadMatrix(n, ref playerPosition);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                Position nextPlayerPosition = new Position();

                // Get Coordinates of the next position for the player
                if (command == "right")
                {
                    nextPlayerPosition.rowIdx = playerPosition.rowIdx;
                    nextPlayerPosition.colIdx = playerPosition.colIdx + 1;
                }
                else if (command == "left")
                {
                    nextPlayerPosition.rowIdx = playerPosition.rowIdx;
                    nextPlayerPosition.colIdx = playerPosition.colIdx - 1;
                }
                else if (command == "up")
                {
                    nextPlayerPosition.rowIdx = playerPosition.rowIdx - 1;
                    nextPlayerPosition.colIdx = playerPosition.colIdx;
                }
                else if (command == "down")
                {
                    nextPlayerPosition.rowIdx = playerPosition.rowIdx + 1;
                    nextPlayerPosition.colIdx = playerPosition.colIdx;
                }

                // Check if it is a valid move in that direction
                if (IsValidMove(matrix, nextPlayerPosition))
                {
                    // It is a valid move, so if there is a letter - get it
                    if (matrix[nextPlayerPosition.rowIdx, nextPlayerPosition.colIdx] != '-')
                    {
                        text.Push(matrix[nextPlayerPosition.rowIdx, nextPlayerPosition.colIdx]);
                    }

                    matrix[nextPlayerPosition.rowIdx, nextPlayerPosition.colIdx] = 'P';
                    matrix[playerPosition.rowIdx, playerPosition.colIdx] = '-';
                    
                    playerPosition.rowIdx = nextPlayerPosition.rowIdx;
                    playerPosition.colIdx = nextPlayerPosition.colIdx;
                }
                else
                {
                    // It is not a valid move, so remove a letter from the text
                    if (text.Count > 0)
                    {
                        text.Pop();
                    }
                }
            }

            List<char> final = text.ToList();
            final.Reverse();
            Console.WriteLine(String.Join("", final));
            PrintMatrix(matrix);
        }

        public static bool IsValidMove(char[,] matrix, Position position)
        {
            if (
                (position.rowIdx >= 0 && position.rowIdx < matrix.GetLength(0)) &&
                (position.colIdx >= 0 && position.colIdx < matrix.GetLength(1))
                )
            {
                return true;
            }

            return false;
        }

        public static char[,] ReadMatrix(int n, ref Position playerPosition)
        {
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'P')
                    {
                        playerPosition.rowIdx = row;
                        playerPosition.colIdx = col;
                    }
                }
            }

            return matrix;
        }

        public static void PrintMatrix(char[,] matrix)
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
