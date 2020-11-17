using System;
using System.Collections.Generic;
using System.Linq;
using TeamGenerator.Common;

namespace TeamGenerator.Models
{
    public class Team
    {

        private string name;
        private readonly List<Player> players;

        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExcMsg);
                }

                this.name = value;
            }
        }

        public int Rating => this.players.Count > 0 ? (int)Math.Round(this.players.Average(p => p.OverAllSkill)) : 0;

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = this.players
                .FirstOrDefault(p => p.Name == playerName);

            if (player == null)
            {
                throw new InvalidOperationException(String.Format(GlobalConstants.MissingPlayerExcMsg, playerName, this.name));
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
