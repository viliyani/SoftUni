using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQty, double consumption)
        {
            FuelQuantity = fuelQty;
            ConsumptionPerKm = consumption;
        }

        public double FuelQuantity { get; set; }
        public double ConsumptionPerKm { get; set; }

        public virtual void Drive(double kms)
        {
            double neededFuel = kms * ConsumptionPerKm;

            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"{this.GetType().Name} travelled {kms} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void AddFuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}
