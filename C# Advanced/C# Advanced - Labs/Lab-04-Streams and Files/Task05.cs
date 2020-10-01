using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new FileStream("../../TextFiles/input.txt", FileMode.Open, FileAccess.Read))
            {
                int length = (int)stream.Length;
                int step = length / 4;

                byte[] buffer = new byte[step];

                for (int i = 0; i < 4; i++)
                {
                    stream.Read(buffer, 0, step);

                    using (var writer = new FileStream($"../../TextFiles/Part{i + 1}.txt", FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        writer.Write(buffer, 0, step);
                    }
                }
            }

        }
    }
}
