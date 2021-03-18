using System.Collections.Generic;

namespace FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            Teams = new HashSet<Team>();
        }

        public int TownId { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Coutry { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
