using System;
using System.IO;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../file.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = 0;
                int marksCount = 0;

                for (int j = 0; j < lines[i].Length; j++)
                {
                    if ((lines[i][j] >= 'a' && lines[i][j] <= 'z') || (lines[i][j] >= 'A' && lines[i][j] <= 'Z'))
                    {
                        lettersCount++;
                    }
                    else if (lines[i][j] == '-' || lines[i][j] == '.' || lines[i][j] == '?' || lines[i][j] == '!' || lines[i][j] == '\'' || lines[i][j] == '"' || lines[i][j] == ',')
                    {
                        marksCount++;
                    }
                }

                lines[i] = $"Line {i + 1}: {lines[i]} ({lettersCount})({marksCount})";

                Console.WriteLine(lines[i]);
            }

            File.WriteAllLines("../../output.txt", lines);
        }
    }
}
