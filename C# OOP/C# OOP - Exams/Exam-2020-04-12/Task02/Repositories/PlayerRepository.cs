﻿using System;
using System.Collections.Generic;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Models.Players;
using System.Linq;
using CounterStrike.Utilities.Messages;
using CounterStrike.Models.Players.Contracts;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private readonly ICollection<IPlayer> players;

        public PlayerRepository()
        {
            players = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models
        {
            get
            {
                return players.ToList().AsReadOnly();
            }
        }

        public void Add(IPlayer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }

            players.Add(model);
        }

        public IPlayer FindByName(string name)
        {
            return players.FirstOrDefault(p => p.Username == name);
        }

        public bool Remove(IPlayer model)
        {
            return players.Remove(model);
        }
    }
}
