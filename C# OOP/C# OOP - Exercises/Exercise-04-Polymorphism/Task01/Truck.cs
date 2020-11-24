namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQty, double consumption) : base(fuelQty, consumption)
        {
            FuelQuantity *= 0.95;
            ConsumptionPerKm += 1.6;
        }
    }
}
