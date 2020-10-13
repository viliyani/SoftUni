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
            string input = Console.ReadLine();

            string pattern = @"([^0-9]+[0-9]+)";

            var matches = Regex.Matches(input, pattern);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string current = match.Value;
                string text = current.Substring(0, current.Length - 1);
                int num = int.Parse(current.Substring(current.Length - 1, 1));

                var match1 = Regex.Match(current, @"[^0-9]+");
                string text1 = match1.Value;

                var match2 = Regex.Match(current, @"[0-9]+");
                int num1 = int.Parse(match2.Value);

                for (int i = 0; i < num1; i++)
                {
                    sb.Append(text1.ToUpper());
                }
            }

            List<char> list = new List<char>();

            string result = sb.ToString();

            for (int i = 0; i < result.Length; i++)
            {
                if (!list.Contains(result[i]))
                {
                    list.Add(result[i]);
                }
            }

            Console.WriteLine($"Unique symbols used: {list.Count}");
            Console.WriteLine(result);
        }
    }
}
