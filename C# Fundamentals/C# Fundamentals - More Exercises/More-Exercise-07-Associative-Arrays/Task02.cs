using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }

                string[] options = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string username = options[0];
                string contest = options[1];
                int points = int.Parse(options[2]);

                if (dict.ContainsKey(contest))
                {
                    if (dict[contest].ContainsKey(username))
                    {
                        if (dict[contest][username] < points)
                        {
                            dict[contest][username] = points;
                        }
                    }
                    else
                    {
                        dict[contest].Add(username, points);
                    }
                }
                else
                {
                    var temp = new Dictionary<string, int>();
                    temp.Add(username, points);

                    dict.Add(contest, temp);
                }

            }

            Dictionary<string, int> individual = new Dictionary<string, int>();

            foreach (var contest in dict)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int idx = 1;
                foreach (var item in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{idx++}. {item.Key} <::> {item.Value}");

                    if (individual.ContainsKey(item.Key))
                    {
                        individual[item.Key] += item.Value;
                    }
                    else
                    {
                        individual.Add(item.Key, item.Value);
                    }
                }
            }

            Console.WriteLine("Individual standings:");
            int idx2 = 1;
            foreach (var item in individual.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{idx2++}. {item.Key} -> {item.Value}");
            }
        }
    }
}
