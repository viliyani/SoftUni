using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            string part1 = input[0];
            string part2 = input[1];
            string part3 = input[2];

            string pattern1 = @"(?<sim>[#$%*&])(?<content>[A-Z]+)\k<sim>";
            var match1 = Regex.Match(part1, pattern1);

            char[] letters = match1.Groups["content"].Value.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < letters.Length; i++)
            {
                char c = letters[i];
                int code = c;

                string pattern2 = @"(?<info>" + code + ":[0-9]{2})";
                var match2 = Regex.Match(part2, pattern2);

                string[] info = match2.Groups["info"].Value.Split(':');
                dict.Add(c, int.Parse(info[1]));
            }

            foreach (var item in dict)
            {
                char c = item.Key;
                int len = item.Value;

                string pattern3 = $@"(?<=\s|^){c}[^\s]{{{len}}}(?=\s|$)";
                var match3 = Regex.Match(part3, pattern3);

                Console.WriteLine(match3.Value);
            }
        }
    }
}
