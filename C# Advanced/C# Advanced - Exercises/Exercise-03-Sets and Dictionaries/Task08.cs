using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] options = input.Split(':');

                string contest = options[0];
                string password = options[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] options = input.Split(new string[] { "=>" }, StringSplitOptions.None);

                string contest = options[0];
                string password = options[1];
                string user = options[2];
                int points = int.Parse(options[3]);

                if (!(contests.ContainsKey(contest) && contests[contest] == password))
                {
                    continue;
                }

                if (!users.ContainsKey(user))
                {
                    users.Add(user, new Dictionary<string, int>());
                }

                if (users[user].ContainsKey(contest))
                {
                    if (users[user][contest] < points)
                    {
                        users[user][contest] = points;
                    }
                }
                else
                {
                    users[user].Add(contest, points);
                }

            }

            Dictionary<string, int> scores = new Dictionary<string, int>();

            foreach (var item in users)
            {
                string user = item.Key;
                int points = item.Value.Sum(x => x.Value);
                scores.Add(user, points);
            }

            foreach (var item in scores.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
                break;
            }

            Console.WriteLine("Ranking:");

            foreach (var item in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var info in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {info.Key} -> {info.Value}");
                }

            }
        }
    }
}
