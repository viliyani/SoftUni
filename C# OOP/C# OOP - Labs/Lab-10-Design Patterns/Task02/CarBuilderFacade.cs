namespace Facade
{
    public class CarBuilderFacade
    {
        protected Car Car { get; set; }

        public CarBuilderFacade()
        {
            Car = new Car();
        }

        public Car Build()
        {
            return Car;
        }

        public CarInfoBuilder Info => new CarInfoBuilder(this.Car);

        public CarAdressBuilder Built => new CarAdressBuilder(Car);
    }
}
