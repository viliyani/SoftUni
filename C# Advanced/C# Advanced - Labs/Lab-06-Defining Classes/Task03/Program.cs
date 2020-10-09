using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Polo";
            car.Year = 2003;

            Console.WriteLine($"{car.Make} - {car.Model} - {car.Year}");
        }
    }
}
