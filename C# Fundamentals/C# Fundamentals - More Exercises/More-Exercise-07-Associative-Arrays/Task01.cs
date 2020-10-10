using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        public class Contest
        {
            public string Name { get; set; }
            public string Password { get; set; }
            public int Points { get; set; }

            public Contest(string name, string password)
            {
                this.Name = name;
                this.Password = password;
            }

            public Contest(string name, string password, int points) : this(name, password)
            {
                this.Points = points;
            }
        }

        static void Main(string[] args)
        {
            List<Contest> contests = new List<Contest>();
            Dictionary<string, List<Contest>> users = new Dictionary<string, List<Contest>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] options = input.Split(new[] { ':' }, StringSplitOptions.None);

                contests.Add(new Contest(options[0], options[1]));
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] options = input.Split(new string[] { "=>" }, StringSplitOptions.None);

                string contest = options[0];
                string password = options[1];
                string name = options[2];
                int points = int.Parse(options[3]);

                if (contests.Exists(c => c.Name == contest && c.Password == password))
                {
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, new List<Contest>() { new Contest(contest, password, points) });
                    }
                    else
                    {
                        Contest found = users[name].Find(x => x.Name == contest);

                        if (found != null)
                        {
                            if (found.Points < points)
                            {
                                found.Points = points;
                            }
                        }
                        else
                        {
                            users[name].Add(new Contest(contest, password, points));
                        }
                    }
                }

            }

            string bestUser = String.Empty;
            int bestPoints = 0;

            foreach (var user in users)
            {
                List<int> nums = new List<int>();

                int a = nums.Sum();

                int currentPoints = user.Value.Sum(x => x.Points);
                if (currentPoints > bestPoints)
                {
                    bestPoints = currentPoints;
                    bestUser = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");

                foreach (var item in user.Value.OrderByDescending(x => x.Points))
                {
                    Console.WriteLine($"#  {item.Name} -> {item.Points}");
                }
            }
        }
    }
}
