namespace Facade
{
    public class CarAdressBuilder : CarBuilderFacade
    {
        public CarAdressBuilder(Car car)
        {
            this.Car = car;
        }

        public CarAdressBuilder InCity(string city)
        {
            this.Car.City = city;
            return this;
        }

        public CarAdressBuilder AtAdress(string address)
        {
            this.Car.Address = address;
            return this;
        }
    }
}
