using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../InputFiles/input.txt");

            using (reader)
            {
                string input = reader.ReadLine();
                int k = 1;
                while (input != null)
                {
                    if (k++ % 2 == 0)
                    {
                        Console.WriteLine(input);
                    }
                    
                    input = reader.ReadLine();
                }
            }

        }
    }
}
