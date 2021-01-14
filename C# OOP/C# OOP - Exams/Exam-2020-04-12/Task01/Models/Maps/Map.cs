using System;
using System.Collections.Generic;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;
using System.Linq;
using Shooter.Models.Players;

namespace Shooter.Models.Maps
{
    public class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            var terrorists = players.Where(p => p.GetType().Name == nameof(Terrorist));

            var counterTerrorists = players.Where(p => p.GetType().Name == nameof(CounterTerrorist));

            while (terrorists.Any(t => t.IsAlive) && counterTerrorists.Any(c => c.IsAlive))
            {
                foreach (var terrorist in terrorists)
                {
                    foreach (var counterTerrorist in counterTerrorists)
                    {
                        counterTerrorist.TakeDamage(terrorist.Gun.Fire());
                    }
                }

                foreach (var counterTerrorist in counterTerrorists)
                {
                    foreach (var terrorist in terrorists)
                    {
                        terrorist.TakeDamage(counterTerrorist.Gun.Fire());
                    }
                }
            }

            return counterTerrorists.Any(c => c.IsAlive) ? "Counter Terrorist wins!" : "Terrorist wins!";
        }
    }
}
