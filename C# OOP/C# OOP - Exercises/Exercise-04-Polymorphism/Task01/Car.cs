namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQty, double consumption) : base(fuelQty, consumption)
        {
            ConsumptionPerKm += 0.9;
        }
    }
}
