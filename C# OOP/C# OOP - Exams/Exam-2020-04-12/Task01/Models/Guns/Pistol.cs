using System;

namespace Shooter.Models.Guns
{
    public class Pistol : Gun
    {
        private const int fireRate = 1;

        public Pistol(string name, int bulletsCount)
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
