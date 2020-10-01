using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../TextFiles/input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../TextFiles/output.txt"))
                {
                    string input = reader.ReadLine();
                    int k = 1;
                    while (input != null)
                    {
                        writer.WriteLine($"{k++}. {input}");
                        input = reader.ReadLine();
                    }
                }
            }

        }
    }
}
