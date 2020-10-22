using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            char[,] matrix = ReadMatrix(rows, cols);

            int knights = 0;

            while (true)
            {
                int maxCounter = 0;
                int rowIdx = 0;
                int colIdx = 0;


                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int counter = CheckForMove(matrix, row, col);

                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                                rowIdx = row;
                                colIdx = col;
                            }
                        }

                    }
                }

                if (maxCounter == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowIdx, colIdx] = '0';
                    knights++;
                }
            }

            Console.WriteLine(knights);
        }

        static int CheckForMove(char[,] matrix, int row, int col)
        {
            int counter = 0;

            if (IsValidPosition(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
            {
                counter += 1;
            }

            if (IsValidPosition(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
            {
                counter += 1;
            }

            return counter;
        }

        static bool IsValidPosition(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
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
    }
}
