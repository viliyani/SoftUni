using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int idx = 0;
            List<string> strings = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "find")
                {
                    break;
                }

                strings.Add(input);
            }

            Console.WriteLine();

            for (int i = 0; i < strings.Count; i++)
            {
                StringBuilder sb = new StringBuilder();

                string current = strings[i];
                idx = 0;

                for (int j = 0; j < current.Length; j++)
                {
                    sb.Append(((char)(current[j] - numbers[idx++])).ToString());

                    if (idx == numbers.Length)
                    {
                        idx = 0;
                    }
                }

                string result = sb.ToString();

                int idxTypeStart = result.IndexOf('&');
                int idxTypeEnd = result.IndexOf('&', idxTypeStart + 1);
                string type = result.Substring(idxTypeStart + 1, idxTypeEnd - idxTypeStart - 1);

                int idxCodeStart = result.IndexOf('<');
                int idxCodeEnd = result.IndexOf('>');
                string code = result.Substring(idxCodeStart + 1, idxCodeEnd - idxCodeStart - 1);

                Console.WriteLine($"Found {type} at {code}");
            }

        }
    }
}
