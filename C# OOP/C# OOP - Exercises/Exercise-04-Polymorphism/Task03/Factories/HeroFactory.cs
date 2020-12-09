using Raiding.Common;
using Raiding.Models;
using System;

namespace Raiding.Factories
{
    public class HeroFactory
    {
        public HeroFactory()
        {

        }

        public BaseHero CreateHero(string name, string type)
        {
            BaseHero hero;

            if (type == "Druid")
            {
                hero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidHeroTypeMsg);
            }

            return hero;
        }

    }
}
