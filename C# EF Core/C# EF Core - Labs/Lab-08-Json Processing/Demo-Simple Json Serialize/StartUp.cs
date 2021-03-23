using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonDemo
{

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car
            {
                Extras = new List<string> { "Klimatronik", "4x4", "Turbo" },
                ManufacturedOn = DateTime.Now,
                Model = "Golf",
                Vendor = "VW",
                Price = 1230.40m,
                Engine = new Engine { Volume = 1.6f, HorsePower = 80 }
            };

            Console.WriteLine(JsonSerializer.Serialize(car, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
