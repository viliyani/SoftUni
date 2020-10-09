using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }

                string[] options = input.Split();

                Tire[] current = new Tire[4]
                {
                    new Tire(int.Parse(options[0]),double.Parse(options[1])),
                    new Tire(int.Parse(options[2]),double.Parse(options[3])),
                    new Tire(int.Parse(options[4]),double.Parse(options[5])),
                    new Tire(int.Parse(options[6]),double.Parse(options[7]))
                };

                tires.Add(current);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                string[] options = input.Split();

                Engine current = new Engine(int.Parse(options[0]), double.Parse(options[1]));

                engines.Add(current);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }

                string[] options = input.Split();

                string make = options[0];
                string model = options[1];
                int year = int.Parse(options[2]);
                double fuelQuantity = double.Parse(options[3]);
                double fuelConsumption = double.Parse(options[4]);
                int engineIndex = int.Parse(options[5]);
                int tiresIndex = int.Parse(options[6]);

                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                newCar.Drive(20);

                cars.Add(newCar);

            }

            foreach (var car in cars)
            {
                double pressure = car.CalcPressure();
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && pressure > 9 && pressure < 10)
                {
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePower: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }

        }
    }
}
