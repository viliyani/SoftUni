using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo = new DirectoryInfo("../../");

            FileInfo[] files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new Dictionary<string, double>());
                }

                fileInfo[file.Extension].Add(file.Name, file.Length);
            }

            using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/Task05.txt"))
            {
                foreach (var item in fileInfo.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
                {
                    Console.WriteLine($"- {item.Key}");
                    writer.WriteLine($"- {item.Key}");

                    foreach (var file in item.Value.OrderBy(kvp => kvp.Value))
                    {
                        Console.WriteLine($"--{file.Key} - {file.Value / 1024.00:f3}kb");
                        writer.WriteLine($"--{file.Key} - {file.Value / 1024.00:f3}kb");
                    }
                }
            }

        }
    }
}
