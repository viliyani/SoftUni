using System;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] tires;

        public Car(string model, double engineSpeed, double enginePower, double engineWeight, string cargoType,
            double tire1Pressure, double tire1Age, double tire2Pressure, double tire2Age,
            double tire3Pressure, double tire3Age, double tire4Pressure, double tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower, engineWeight);
            this.Cargo = new Cargo(cargoType);

            tires = new Tire[4]
            {
                new Tire(tire1Pressure, tire1Age),
                new Tire(tire2Pressure, tire2Age),
                new Tire(tire3Pressure, tire3Age),
                new Tire(tire4Pressure, tire4Age)
            };
        }

    }
}
