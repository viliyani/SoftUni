using System;
using CounterStrike.Core.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Guns;
using CounterStrike.Utilities.Messages;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Models.Players;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private readonly GunRepository guns;
        private readonly PlayerRepository players;
        private readonly IMap map;

        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun;

            if (type == nameof(Pistol))
            {
                gun = new Pistol(name, bulletsCount);
            }
            else if (type == nameof(Rifle))
            {
                gun = new Rifle(name, bulletsCount);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

            guns.Add(gun);

            return string.Format(OutputMessages.SuccessfullyAddedGun, name);

        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun gun = guns.FindByName(gunName);

            if (gun == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }

            Player player;

            if (type == nameof(Terrorist))
            {
                player = new Terrorist(username, health, armor, gun);
            }
            else if (type == nameof(CounterTerrorist))
            {
                player = new CounterTerrorist(username, health, armor, gun);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }

            players.Add(player);

            return string.Format(OutputMessages.SuccessfullyAddedPlayer, username);
        }

        public string Report()
        {
            var resultPlayers = players.Models
                                    .OrderBy(p => p.GetType().Name)
                                    .ThenByDescending(p => p.Health)
                                    .ThenBy(p => p.Username)
                                    .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var player in resultPlayers)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string StartGame()
        {
            return map.Start(players.Models.ToList());
        }
    }
}
