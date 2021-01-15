using System;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private const int fireRate = 1;

        public Rifle(string name, int bulletsCount)
            : base(name, bulletsCount)
        {
        }

        protected override int FireRate
        {
            get
            {
                return fireRate;
            }
        }
    }
}
