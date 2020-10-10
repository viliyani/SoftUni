using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>(); // color => name, points

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                string[] options = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = options[0];
                string color = options[1];
                int points = int.Parse(options[2]);

                if (dict.ContainsKey(color))
                {
                    if (dict[color].ContainsKey(name))
                    {
                        if (dict[color][name] < points)
                        {
                            dict[color][name] = points;
                        }
                    }
                    else
                    {
                        dict[color].Add(name, points);
                    }
                }
                else
                {
                    var temp = new Dictionary<string, int>();
                    temp.Add(name, points);

                    dict.Add(color, temp);
                }
            }

            foreach (var player in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)).ThenBy(x => x.Value.Count))
            {
                foreach (var item in player.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"({player.Key}) {item.Key} <-> {item.Value}");
                }
            }

        }
    }
}
