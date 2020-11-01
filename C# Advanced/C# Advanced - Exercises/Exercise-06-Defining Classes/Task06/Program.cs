using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                cars.Add(new Car(options[0], double.Parse(options[1]), double.Parse(options[2])));
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] options = input.Split();

                string model = options[1];
                double amountOfKm = double.Parse(options[2]);

                Car car = cars.Find(x => x.Model == model);

                if (car.CanMove(amountOfKm))
                {
                    car.Drive(amountOfKm);
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance:f0}");
            }

        }
    }
}
