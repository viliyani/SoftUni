using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            List<string> strings = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    sb.Append((char)(input[i] - k));
                }

                strings.Add(sb.ToString());

            }

            foreach (var item in strings)
            {
                string pattern = @"\@(?<name>[a-zA-Z]+)[^@!:>\-]*(?<sep>[!])(?<type>[G|N])\k<sep>";
                var match = Regex.Match(item, pattern);

                string name = match.Groups["name"].Value;
                string type = match.Groups["type"].Value;

                if (type=="G")
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
