using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.None);

                string color = input[0];
                string[] items = input[1].Split(',');

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in items)
                {
                    if (!dict[color].ContainsKey(item))
                    {
                        dict[color].Add(item, 0);
                    }

                    dict[color][item]++;
                }

            }

            string[] needed = Console.ReadLine().Split();
            string neededColor = needed[0];
            string neededDress = needed[1];

            foreach (var color in dict)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {
                    if (color.Key == neededColor && neededDress == dress.Key)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                }

            }


        }
    }
}
