using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<Dragon>>(); // color => name, points

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                string color = options[0];
                string name = options[1];
                int damage = 45;
                int health = 250;
                int armor = 10;

                if (options[2] != "null")
                {
                    damage = int.Parse(options[2]);
                }

                if (options[3] != "null")
                {
                    health = int.Parse(options[3]);
                }

                if (options[4] != "null")
                {
                    armor = int.Parse(options[4]);
                }

                if (dict.ContainsKey(color))
                {
                    if (dict[color].Exists(x => x.Name == name))
                    {
                        var dragon = dict[color].Find(x => x.Name == name);
                        dragon.Damage = damage;
                        dragon.Health = health;
                        dragon.Armor = armor;
                    }
                    else
                    {
                        dict[color].Add(new Dragon(name, damage, health, armor));
                    }
                }
                else
                {
                    dict.Add(color, new List<Dragon>() { new Dragon(name, damage, health, armor) });
                }
            }

            foreach (var type in dict)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(x => x.Damage):f2}/{type.Value.Average(x => x.Health):f2}/{type.Value.Average(x => x.Armor):f2})");

                foreach (var dragon in type.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
