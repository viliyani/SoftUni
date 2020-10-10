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

                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains(" vs "))
                {
                    string[] options = input.Split(new string[] { " vs " }, StringSplitOptions.RemoveEmptyEntries);

                    string player1 = options[0];
                    string player2 = options[1];

                    if (dict.ContainsKey(player1) && dict.ContainsKey(player2))
                    {
                        foreach (var player1Seasons in dict[player1])
                        {
                            foreach (var player2Season in dict[player2])
                            {
                                if (player1Seasons.Key == player2Season.Key)
                                {
                                    if (dict[player1].Sum(x => x.Value) > dict[player2].Sum(x => x.Value))
                                    {
                                        // player 1 win
                                        dict.Remove(player2);
                                        break;
                                    }
                                    else if (dict[player1].Sum(x => x.Value) < dict[player2].Sum(x => x.Value))
                                    {
                                        // player 2 win
                                        dict.Remove(player1);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    string[] options = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                    string player = options[0];
                    string season = options[1];
                    int skill = int.Parse(options[2]);

                    if (dict.ContainsKey(player))
                    {
                        if (dict[player].ContainsKey(season))
                        {
                            if (dict[player][season] < skill)
                            {
                                dict[player][season] = skill;
                            }
                        }
                        else
                        {
                            dict[player].Add(season, skill);
                        }
                    }
                    else
                    {
                        var temp = new Dictionary<string, int>();
                        temp.Add(season, skill);

                        dict.Add(player, temp);
                    }
                }
            }

            foreach (var player in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum(x => x.Value)} skill");

                foreach (var item in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }

        }
    }
}
