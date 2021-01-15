using System;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Utilities.Messages;

namespace CounterStrike.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsCount;

        protected Gun(string name, int bulletsCount)
        {
            Name = name;
            BulletsCount = bulletsCount;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunName);
                }

                name = value;
            }
        }

        public int BulletsCount
        {
            get
            {
                return bulletsCount;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunBulletsCount);
                }

                bulletsCount = value;
            }
        }

        protected abstract int FireRate { get; }

        public int Fire()
        {
            if (BulletsCount >= FireRate)
            {
                BulletsCount -= FireRate;
                return FireRate;
            }
            else
            {
                return 0;
            }
        }
    }
}
