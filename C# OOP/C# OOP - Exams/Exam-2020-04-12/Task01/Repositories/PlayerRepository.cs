using System;
using System.Collections.Generic;
using CounterStrike.Repositories.Contracts;
using Shooter.Models.Players;
using System.Linq;
using CounterStrike.Utilities.Messages;

namespace Shooter.Repositories
{
    public class PlayerRepository : IRepository<Player>
    {
        private readonly ICollection<Player> players;

        public PlayerRepository()
        {
            players = new List<Player>();
        }

        public IReadOnlyCollection<Player> Models
        {
            get
            {
                return players.ToList().AsReadOnly();
            }
        }

        public void Add(Player model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }

            players.Add(model);
        }

        public Player FindByName(string name)
        {
            return players.FirstOrDefault(p => p.Username == name);
        }

        public bool Remove(Player model)
        {
            return players.Remove(model);
        }
    }
}
