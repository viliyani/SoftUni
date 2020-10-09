using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
            };

            var engine = new Engine(560, 6300);

            var car = new Car("VW", "Polo", 1995, 3, 3, engine, tires);
        }
    }
}
