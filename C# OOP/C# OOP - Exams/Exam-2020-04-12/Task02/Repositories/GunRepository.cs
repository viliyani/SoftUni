using System;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Models.Guns.Contracts;
using System.Collections.Generic;
using CounterStrike.Utilities.Messages;
using System.Linq;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly ICollection<IGun> guns;

        public GunRepository()
        {
            guns = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models
        {
            get
            {
                return guns.ToList().AsReadOnly();
            }
        }

        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }

            guns.Add(model);
        }

        public IGun FindByName(string name)
        {
            return guns.FirstOrDefault(g => g.Name == name);
        }

        public bool Remove(IGun model)
        {
            return guns.Remove(model);
        }

    }
}
