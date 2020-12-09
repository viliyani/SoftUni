using System;
using Raiding.Core.Contracts;
using Raiding.Factories;
using System.Collections.Generic;
using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly HeroFactory heroFactory;

        public Engine()
        {
            heroFactory = new HeroFactory();
        }

        public void Run()
        {
            List<BaseHero> heroes = new List<BaseHero>();

            try
            {
                CreateAllHeroes(heroes);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }

            int bossPower = int.Parse(Console.ReadLine());

            int totalHeroesPower = 0;

            foreach (var hero in heroes)
            {
                totalHeroesPower += hero.Power;

                Console.WriteLine(hero.CastAbility());
            }

            if (totalHeroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private void CreateAllHeroes(List<BaseHero> heroes)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                heroes.Add(heroFactory.CreateHero(heroName, heroType));
            }
        }
    }
}
