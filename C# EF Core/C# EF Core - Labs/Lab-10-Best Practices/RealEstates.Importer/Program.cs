using RealEstates.Data;
using RealEstates.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace RealEstates.Importer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new ApplicationDbContext();
            
            // ImportJsonFile(dbContext, "imot.bg-raw-data-2021-03-18.json");

            Console.WriteLine();

            int count = dbContext.Properties.Count();
            Console.WriteLine($"Count: {count}");

        }

        private static void ImportJsonFile(ApplicationDbContext dbContext, string jsonFileName)
        {
            IPropertiesService propertiesService = new PropertiesService(dbContext);

            var properties =
                            JsonSerializer.Deserialize<IEnumerable
                            <PropertyAsJson>>(File.ReadAllText(jsonFileName));

            foreach (var jsonProperty in properties)
            {
                propertiesService.Add(jsonProperty.District, jsonProperty.Price, jsonProperty.Floor, jsonProperty.TotalFloors, jsonProperty.Size, jsonProperty.YardSize, jsonProperty.Year, jsonProperty.Type, jsonProperty.BuildingType);
                Console.Write(".");
            }
        }
    }
}
