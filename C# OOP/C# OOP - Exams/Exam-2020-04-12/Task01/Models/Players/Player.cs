using System;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;

namespace Shooter.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        public Player(string username, int health, int armor, IGun gun)
        {
            Username = username;
            Health = health;
            Armor = armor;
            Gun = gun;
        }

        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }

                username = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }

                health = value;
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }

                armor = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return health > 0;
            }
        }

        public IGun Gun
        {
            get
            {
                return gun;
            }
            private set
            {
                if (gun == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunType);
                }
            }
        }

        public void TakeDamage(int points)
        {
            // arm = 100, points = 50
            // arm = 60, points = 80
            // arm = 22, points = 22

            // Armor
            if (points >= Armor)
            {
                points -= Armor;
                Armor = 0;
            }
            else
            {
                Armor -= points;
                points = 0;
            }

            // Health
            if (points > 0)
            {
                Health -= points;

                if (Health > points)
                {
                    Health -= points;
                }
                else
                {
                    Health = 0;
                }
            }
        }


    }
}
