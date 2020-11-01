using System;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = FuelConsumptionPerKilometer;
        }

        public bool CanMove(double amountOfKm)
        {
            double neededFuel = FuelConsumptionPerKilometer * amountOfKm;

            if (neededFuel < FuelAmount)
            {
                return true;
            }

            return false;
        }

        public void Drive(double amountOfKm)
        {
            double neededFuel = FuelConsumptionPerKilometer * amountOfKm;

            FuelAmount -= neededFuel;
            TravelledDistance += amountOfKm;
        }
    }
}
