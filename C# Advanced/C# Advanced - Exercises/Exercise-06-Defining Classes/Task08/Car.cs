using System;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine) : this(model, engine, 0, "n/a")
        {
        }

        public Car(string model, Engine engine, double weight) : this(model, engine, weight, "n/a")
        {
        }

        public Car(string model, Engine engine, double weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
    }
}
