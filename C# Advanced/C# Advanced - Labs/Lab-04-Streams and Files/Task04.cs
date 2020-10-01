using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = File.ReadAllText("../../TextFiles/input1.txt");
            string input2 = File.ReadAllText("../../TextFiles/input2.txt");

            string result = input1 + input2;

            File.WriteAllText("output.txt", result);
        }

    }
}
