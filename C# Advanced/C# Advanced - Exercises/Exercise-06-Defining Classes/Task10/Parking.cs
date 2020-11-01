using System;
using System.Collections.Generic;

namespace SoftuniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public int Count
        {
            get
            {
                return cars.Count;
            }
        }

        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }

        public string AddCar(Car car)
        {
            if (cars.Exists(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return $"Car with that registration number, already exists!";
            }
            else if (this.Count >= this.capacity)
            {
                return $"Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Exists(x => x.RegistrationNumber == registrationNumber))
            {
               return $"Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            if (!cars.Exists(x => x.RegistrationNumber == registrationNumber))
            {
                return null;
            }

            return cars.Find(x => x.RegistrationNumber == registrationNumber);
        }
    }
}
