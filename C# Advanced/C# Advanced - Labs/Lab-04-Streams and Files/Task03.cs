using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../TextFiles/input.txt").ToLower();
            string wordsFile = File.ReadAllText("../../TextFiles/words.txt").ToLower();

            var charsToRemove = new string[] { "-", ",", ".", ";", "'" , "!", "?"};
            foreach (var c in charsToRemove)
            {
                input = input.Replace(c, string.Empty);
            }

            string[] words = wordsFile.Split();
            string[] arr = input.Split();

            for (int i = 0; i < words.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (words[i] == arr[j])
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"{words[i]} - {counter}");
            }
        }
    }
}
