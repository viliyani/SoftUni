using System;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public Player(string name, string classVar)
        {
            this.Name = name;
            this.Class = classVar;
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Player {this.Name}: {this.Class}{Environment.NewLine}");
            sb.Append($"Rank: {this.Rank}{Environment.NewLine}");
            sb.Append($"Description: {this.Description}");

            return sb.ToString();
        }
    }
}
