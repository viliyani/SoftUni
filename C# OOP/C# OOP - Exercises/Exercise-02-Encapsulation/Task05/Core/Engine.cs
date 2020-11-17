using System;
using System.Collections.Generic;
using System.Linq;
using TeamGenerator.Common;
using TeamGenerator.Models;

namespace TeamGenerator.Core
{
    public class Engine
    {
        private readonly ICollection<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command
                    .Split(';');

                string cmdType = cmdArgs[0];

                try
                {
                    List<string> cmdParams = cmdArgs.Skip(1).ToList();

                    if (cmdType == "Team")
                    {
                        this.CreateTeam(cmdParams);
                    }
                    else if (cmdType == "Add")
                    {
                        this.AddPlayerToTeam(cmdParams);
                    }
                    else if (cmdType == "Remove")
                    {
                        this.RemovePlayerFromTeam(cmdParams);
                    }
                    else if (cmdType == "Rating")
                    {
                        this.RateTeam(cmdParams);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void CreateTeam(List<string> cmdArgs)
        {
            string teamName = cmdArgs[0];

            Team team = new Team(teamName);

            this.teams.Add(team);
        }

        private void AddPlayerToTeam(List<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            string playerName = cmdArgs[1];
            Stats stats = this.BuildStats(cmdArgs.Skip(2).ToArray());

            Player player = new Player(playerName, stats);

            this.ValidateTeamExists(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            team.AddPlayer(player);
        }

        private void RemovePlayerFromTeam(List<string> cmdArgs)
        {
            string teamName = cmdArgs[0];
            string playerName = cmdArgs[1];

            this.ValidateTeamExists(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            team.RemovePlayer(playerName);
        }

        private void RateTeam(List<string> cmdArgs)
        {
            string teamName = cmdArgs[0];

            this.ValidateTeamExists(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            Console.WriteLine(team);
        }

        private Stats BuildStats(string[] statsArgs)
        {
            int endurance = int.Parse(statsArgs[0]);
            int sprint = int.Parse(statsArgs[1]);
            int dribble = int.Parse(statsArgs[2]);
            int passing = int.Parse(statsArgs[3]);
            int shooting = int.Parse(statsArgs[4]);

            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

            return stats;
        }

        private void ValidateTeamExists(string teamName)
        {
            Team team = this.teams
                .FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                throw new InvalidOperationException(String.Format(GlobalConstants.MissingTeamExcMsg, teamName));
            }
        }
    }
}
