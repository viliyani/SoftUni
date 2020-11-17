using System;
using TeamGenerator.Common;

namespace TeamGenerator.Models
{
    public class Stats
    {
        private const int MIN_STAT = 0;
        private const int MAX_STAT = 100;
        private const int STATS_CNT = 5;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                ValidateStat(nameof(Endurance), value);

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                ValidateStat(nameof(Sprint), value);

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                ValidateStat(nameof(Dribble), value);

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                ValidateStat(nameof(Passing), value);

                this.passing = value;
            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                ValidateStat(nameof(Shooting), value);

                this.shooting = value;
            }
        }

        public double AverageStat => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) * 1.0 / STATS_CNT * 1.0;

        private void ValidateStat(string name, int value)
        {
            if (value < MIN_STAT || value > MAX_STAT)
            {
                throw new ArgumentException(String.Format(GlobalConstants.InvalidStatExcMsg, name, MIN_STAT, MAX_STAT));
            }
        }
    }
}
