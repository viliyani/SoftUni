using System;

namespace DefiningClasses
{
    public class Engine
    {
        public double Speed { get; set; }
        public double Power { get; set; }
        public double Weight { get; set; }

        public Engine(double speed, double power, double weight)
        {
            this.Speed = speed;
            this.Power = power;
            this.Weight = weight;
        }
    }
}
