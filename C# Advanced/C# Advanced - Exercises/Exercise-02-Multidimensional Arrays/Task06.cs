using System;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[5][];

            // Read jagged array
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                if (row != rows - 1 && jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                    }
                    for (int i = 0; i < jagged[row + 1].Length; i++)
                    {
                        jagged[row + 1][i] *= 2;
                    }
                }
                else if (row != rows - 1 && jagged[row + 1].Length != jagged[row].Length)
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;
                    }
                    for (int i = 0; i < jagged[row + 1].Length; i++)
                    {
                        jagged[row + 1][i] /= 2;
                    }
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] options = input.Split();

                if (options[0] == "Add")
                {
                    int row = int.Parse(options[1]);
                    int col = int.Parse(options[2]);
                    int value = int.Parse(options[3]);

                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (options[0] == "Subtract")
                {
                    int row = int.Parse(options[1]);
                    int col = int.Parse(options[2]);
                    int value = int.Parse(options[3]);

                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
