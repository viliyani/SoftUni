using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] options = input.Split();

                string trainerName = options[0];
                string pokemonName = options[1];
                string pokemonElement = options[2];
                double pokemonHealth = double.Parse(options[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.Exists(t => t.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                trainers.Find(t => t.Name == trainerName).Pokemons.Add(pokemon);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                trainers.FindAll(x => x.Pokemons.FindAll(y => y.Element == input).Count > 0).ForEach(x => x.BadgesCount++);

                trainers.FindAll(x => x.Pokemons.FindAll(y => y.Element == input).Count == 0)
                    .ForEach(x => x.Pokemons.ForEach(y => y.Health -= 10));

                trainers.FindAll(x => x.Pokemons.FindAll(y => y.Health <= 0).Count > 0)
                    .ForEach(x => x.Pokemons.RemoveAll(y => y.Health <= 0));
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.BadgesCount))
            {
                Console.WriteLine($"{trainer.Name} {trainer.BadgesCount} {trainer.Pokemons.Count}");
            }

        }
    }
}
