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

                cars.Add(new Car(options[0], double.Parse(options[1]), double.Parse(options[2]),
                    double.Parse(options[3]), options[4], double.Parse(options[5]), double.Parse(options[6]),
                    double.Parse(options[7]), double.Parse(options[8]),
                    double.Parse(options[9]), double.Parse(options[10]),
                    double.Parse(options[11]), double.Parse(options[11])));
            }

            string input = Console.ReadLine();

            List<Car> resultCars = new List<Car>();

            if (input == "fragile")
            {
                resultCars = cars.FindAll(c => c.Cargo.Type == "fragile" && c.tires.Where(t => t.Pressure < 1).ToList().Count > 1).ToList();
            }
            else if (input == "flamable")
            {
                resultCars = cars.FindAll(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250);
            }

            foreach (var car in resultCars)
            {
                Console.WriteLine($"{car.Model}");
            }

        }
    }
}
