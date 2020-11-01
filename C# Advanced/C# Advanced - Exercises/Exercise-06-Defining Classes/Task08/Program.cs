using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] options = Console.ReadLine().Split();

                if (options.Length == 2)
                {
                    engines.Add(new Engine(options[0], double.Parse(options[1])));
                }
                else if (options.Length == 3)
                {
                    engines.Add(new Engine(options[0], double.Parse(options[1]), double.Parse(options[2])));
                }
                else if (options.Length == 4)
                {
                    engines.Add(new Engine(options[0], double.Parse(options[1]), double.Parse(options[2]), options[3]));
                }
            }

            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] options = Console.ReadLine().Split();

                Engine foundEngine = engines.Find(x => x.Model == options[1]);

                if (options.Length == 2)
                {
                    cars.Add(new Car(options[0], foundEngine));
                }
                else if (options.Length == 3)
                {
                    cars.Add(new Car(options[0], foundEngine, double.Parse(options[2])));
                }
                else if (options.Length == 4)
                {
                    cars.Add(new Car(options[0], foundEngine, double.Parse(options[2]), options[3]));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"\t{car.Engine.Model}:");
                Console.WriteLine($"\t\t Power: {car.Engine.Power}:");
                Console.WriteLine($"\t\t Displacement: {car.Engine.Displacement}:");
                Console.WriteLine($"\t\t Efficiency: {car.Engine.Efficiency}:");
                Console.WriteLine($"\t Weight: {car.Weight}:");
                Console.WriteLine($"\t Color: {car.Weight}:");
            }

        }
    }
}
