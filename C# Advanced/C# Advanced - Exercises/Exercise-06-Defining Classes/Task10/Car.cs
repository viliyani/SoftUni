using System;
using System.Text;

namespace SoftuniParking
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Make: {Make}{Environment.NewLine}");
            sb.Append($"Model: {Model}{Environment.NewLine}");
            sb.Append($"HorsePower: {HorsePower}{Environment.NewLine}");
            sb.Append($"RegistrationNumber: {RegistrationNumber}{Environment.NewLine}");

            return sb.ToString();
        }

    }
}
