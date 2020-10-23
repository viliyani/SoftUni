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

            string[] commands = Console.ReadLine().Split();

            int minerRow = 0;
            int minerCol = 0;
            int totalCoals = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(elements[col]);

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }

            int collected = 0;

            foreach (var command in commands)
            {
                if (command == "up")
                {
                    if (IsValidPosition(matrix, minerRow - 1, minerCol))
                    {
                        if (matrix[minerRow - 1, minerCol] == 'c')
                        {
                            collected++;
                            matrix[minerRow - 1, minerCol] = '*';

                            if (collected == totalCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow - 1}, {minerCol})");
                                return;
                            }
                        }
                        else if (matrix[minerRow - 1, minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow - 1}, {minerCol})");
                            return;
                        }

                        Swap(matrix, minerRow, minerCol, minerRow - 1, minerCol);
                        minerRow = minerRow - 1;
                    }
                }
                else if (command == "down")
                {
                    if (IsValidPosition(matrix, minerRow + 1, minerCol))
                    {
                        if (matrix[minerRow + 1, minerCol] == 'c')
                        {
                            collected++;
                            matrix[minerRow + 1, minerCol] = '*';

                            if (collected == totalCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow + 1}, {minerCol})");
                                return;
                            }
                        }
                        else if (matrix[minerRow + 1, minerCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow + 1}, {minerCol})");
                            return;
                        }

                        Swap(matrix, minerRow, minerCol, minerRow + 1, minerCol);
                        minerRow = minerRow + 1;
                    }
                }
                else if (command == "left")
                {
                    if (IsValidPosition(matrix, minerRow, minerCol - 1))
                    {
                        if (matrix[minerRow, minerCol - 1] == 'c')
                        {
                            collected++;
                            matrix[minerRow, minerCol - 1] = '*';

                            if (collected == totalCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol - 1})");
                                return;
                            }
                        }
                        else if (matrix[minerRow, minerCol - 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol - 1})");
                            return;
                        }

                        Swap(matrix, minerRow, minerCol, minerRow, minerCol - 1);
                        minerCol = minerCol - 1;
                    }
                }
                else if (command == "right")
                {
                    if (IsValidPosition(matrix, minerRow, minerCol + 1))
                    {
                        if (matrix[minerRow, minerCol + 1] == 'c')
                        {
                            collected++;
                            matrix[minerRow, minerCol + 1] = '*';

                            if (collected == totalCoals)
                            {
                                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol + 1})");
                                return;
                            }
                        }
                        else if (matrix[minerRow, minerCol + 1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({minerRow}, {minerCol + 1})");
                            return;
                        }

                        Swap(matrix, minerRow, minerCol, minerRow, minerCol + 1);
                        minerCol = minerCol + 1;
                    }
                }
            }

            Console.WriteLine($"{totalCoals - collected} coals left. ({minerRow}, {minerCol})");

        }

        static void Swap(char[,] matrix, int row1, int col1, int row2, int col2)
        {
            char temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;
        }

        static bool IsValidPosition(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
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
