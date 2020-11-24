using System;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] options = Console.ReadLine().Split();
            var carFuelQuantity = double.Parse(options[1]);
            var carConsumptionPerKm = double.Parse(options[2]);

            options = Console.ReadLine().Split();
            var truckFuelQuantity = double.Parse(options[1]);
            var truckConsumptionPerKm = double.Parse(options[2]);

            Vehicle car = new Car(carFuelQuantity, carConsumptionPerKm);
            Vehicle truck = new Truck(truckFuelQuantity, truckConsumptionPerKm);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                options = Console.ReadLine().Split();

                if (options[0] == "Drive")
                {
                    double kms = double.Parse(options[2]);

                    if (options[1] == "Car")
                    {
                        car.Drive(kms);
                    }
                    else if (options[1] == "Truck")
                    {
                        truck.Drive(kms);
                    }
                }
                else if (options[0] == "Refuel")
                {
                    double liters = double.Parse(options[2]);

                    if (options[1] == "Car")
                    {
                        car.AddFuel(liters);
                    }
                    else if (options[1] == "Truck")
                    {
                        truck.AddFuel(liters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
