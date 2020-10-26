using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../words.txt");
            string text = File.ReadAllText("../../text.txt");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            text = text.ToLower();

            foreach (var word in words)
            {
                string pattern = $@"\b{word}\b";

                var matches = Regex.Matches(text, pattern);

                dict.Add(word, matches.Count);
            }

            List<string> actualResult = new List<string>();
            List<string> expectedResult = new List<string>();

            foreach (var item in dict)
            {
                actualResult.Add($"{item.Key} - {item.Value}");
            }

            foreach (var item in dict.OrderByDescending(kvp => kvp.Value))
            {
                expectedResult.Add($"{item.Key} - {item.Value}");
            }

            File.WriteAllLines("../../actualResult.txt", actualResult.ToArray());
            File.WriteAllLines("../../expectedResult.txt", expectedResult.ToArray());
        }
    }
}
