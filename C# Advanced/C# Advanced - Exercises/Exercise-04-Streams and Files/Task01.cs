using System;
using System.IO;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../file.txt");

            for (int i = 1; i < lines.Length; i += 2)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}
