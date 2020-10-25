using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            char[,] matrix = new char[rows, cols];

            int bCounter = 0;
            int rowIdx = 0;
            int colIdx = 0;
            int b1Row = 0;
            int b1Col = 0;
            int b2Row = 0;
            int b2Col = 0;
            int foodQty = 0;

            for (int row = 0; row < rows; row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];

                    if (matrix[row, col] == 'S')
                    {
                        rowIdx = row;
                        colIdx = col;
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        if (bCounter == 0)
                        {
                            b1Row = row;
                            b1Col = col;
                        }
                        else
                        {
                            b2Row = row;
                            b2Col = col;
                        }
                        bCounter++;
                    }
                }
            }

            matrix[rowIdx, colIdx] = '.';

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    rowIdx--;
                }
                else if (command == "down")
                {
                    rowIdx++;
                }
                else if (command == "left")
                {
                    colIdx--;
                }
                else if (command == "right")
                {
                    colIdx++;
                }

                if (!IsValid(matrix, rowIdx, colIdx))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[rowIdx, colIdx] == '*')
                {
                    foodQty++;
                }
                else if (matrix[rowIdx, colIdx] == 'B')
                {
                    matrix[rowIdx, colIdx] = '.';
                    if (rowIdx == b1Row && colIdx == b1Col)
                    {
                        rowIdx = b2Row;
                        colIdx = b2Col;
                    }
                    else
                    {
                        rowIdx = b1Row;
                        colIdx = b1Col;
                    }
                }

                matrix[rowIdx, colIdx] = '.';

                if (foodQty >= 10)
                {
                    matrix[rowIdx, colIdx] = 'S';
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }

            }

            Console.WriteLine($"Food eaten: {foodQty}");
            PrintMatrix(matrix);
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
