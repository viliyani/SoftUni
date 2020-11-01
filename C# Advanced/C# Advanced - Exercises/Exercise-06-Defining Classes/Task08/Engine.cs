using System;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public double Power { get; set; }
        public double Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, double power) : this(model, power, 0, "n/a")
        {
        }

        public Engine(string model, double power, double displacement) : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, double power, double displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
