using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roaster;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return roaster.Count;
            }
        }

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roaster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (roaster.Count < Capacity)
            {
                roaster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (roaster.Exists(x => x.Name == name))
            {
                roaster.Remove(roaster.Find(x => x.Name == name));
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            if (roaster.Exists(x => x.Name == name))
            {
                Player player = roaster.Find(x => x.Name == name);

                if (player.Rank != "Member")
                {
                    player.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            if (roaster.Exists(x => x.Name == name))
            {
                Player player = roaster.Find(x => x.Name == name);

                if (player.Rank != "Trial")
                {
                    player.Rank = "Trial";
                }
            }
        }

        public Player[] KickPlayersByClass(string classVar)
        {
            Player[] players = roaster.FindAll(x => x.Class == classVar).ToArray();
            roaster.RemoveAll(x => x.Class == classVar);
            return players;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Players in the guild: {this.Name}{Environment.NewLine}");

            for (int i = 0; i < roaster.Count; i++)
            {
                sb.Append(roaster[i].ToString());
                if (i != roaster.Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
    }
}
