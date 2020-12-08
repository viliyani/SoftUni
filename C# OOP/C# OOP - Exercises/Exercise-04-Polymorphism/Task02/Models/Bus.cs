namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCR = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption + FUEL_CONSUMPTION_INCR;
            }
        }
    }
}
