using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Vlogger
    {
        public string Name { get; set; }
        public List<Vlogger> Followers { get; set; }
        public List<Vlogger> Following { get; set; }

        public Vlogger(string name)
        {
            this.Name = name;
            this.Followers = new List<Vlogger>();
            this.Following = new List<Vlogger>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vlogger> vloggers = new List<Vlogger>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] options = input.Split();

                string name = options[0];
                string operation = options[1];

                if (operation == "joined")
                {
                    if (!vloggers.Exists(kvp => kvp.Name == name))
                    {
                        vloggers.Add(new Vlogger(name));
                    }
                }
                else if (operation == "followed")
                {
                    string followedUser = options[2];

                    if (vloggers.Exists(kvp => kvp.Name == name) && vloggers.Exists(kvp => kvp.Name == followedUser) && name != followedUser)
                    {
                        Vlogger vlogger1 = vloggers.First(kvp => kvp.Name == name);
                        Vlogger vlogger2 = vloggers.First(kvp => kvp.Name == followedUser);

                        if (!vlogger2.Followers.Exists(kvp => kvp.Name == name))
                        {
                            vlogger2.Followers.Add(vlogger1);
                        }

                        if (!vlogger1.Following.Exists(kvp => kvp.Name == followedUser))
                        {
                            vlogger1.Following.Add(vlogger2);
                        }
                    }

                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int num = 1;

            foreach (var item in vloggers.OrderByDescending(kvp => kvp.Followers.Count).ThenBy(kvp => kvp.Following.Count))
            {
                Console.WriteLine($"{num}. {item.Name} : {item.Followers.Count} followers, {item.Following.Count} following");

                if (num == 1)
                {
                    foreach (var follower in item.Followers.OrderBy(v => v.Name))
                    {
                        Console.WriteLine($"*  {follower.Name}");
                    }
                }

                num++;
            }

        }
    }
}
