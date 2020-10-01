using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = CalculateDirSize("../../TestFolder");
            double result = total * 1.0 / 1048576.0;
            Console.WriteLine(result);
        }

        static long CalculateDirSize(string dirName)
        {
            string[] files = Directory.GetFiles("../../TestFolder");
            return CalculateFilesSize(files);
        }

        static long CalculateFilesSize(string[] files)
        {
            long total = 0;

            foreach (var item in files)
            {
                var fInfo = new FileInfo(item).Length;
                total += fInfo;
            }

            return total;
        }
    }
}
