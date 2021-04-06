using Microsoft.EntityFrameworkCore;
using RealEstates.Data;
using RealEstates.Models;
using RealEstates.Services;
using RealEstates.Services.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RealEstates.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            var db = new ApplicationDbContext();
            db.Database.Migrate();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Property search");
                Console.WriteLine("2. Most expensive districts");
                Console.WriteLine("4. Add Tag");
                Console.WriteLine("5. Bulk Tag to Properties");
                Console.WriteLine("6. Export to XML");
                Console.WriteLine("0. EXIT");

                bool parsed = int.TryParse(Console.ReadLine(), out int option);

                if (parsed && option == 0)
                {
                    break;
                }

                if (parsed && option >= 1 && option <= 6)
                {
                    switch (option)
                    {
                        case 1:
                            PropertySearch(db);
                            break;
                        case 2:
                            MostExpensiveDistricts(db);
                            break;
                        case 4:
                            AddTag(db);
                            break;
                        case 5:
                            BulkTagToProperties(db);
                            break;
                        case 6:
                            PropertiesFullInfo(db);
                            break;
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            }
        }

        private static void PropertiesFullInfo(ApplicationDbContext db)
        {
            Console.WriteLine("Count of properties:");
            int count = int.Parse(Console.ReadLine());

            IPropertiesService propertiesService = new PropertiesService(db);
            var result = propertiesService.GetFullData(count).ToArray();

            var xmlSerializer = new XmlSerializer(typeof(PropertyInfoFullDataDto[]));
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, result);


            Console.WriteLine(stringWriter.ToString().TrimEnd());
        }

        private static void BulkTagToProperties(ApplicationDbContext db)
        {
            Console.WriteLine("Bulk operation started!");

            IPropertiesService propertiesService = new PropertiesService(db);
            ITagsService tagsService = new TagsService(db, propertiesService);
            tagsService.BulkTagToProperties();

            Console.WriteLine("Bulk operation finished!");
        }

        private static void AddTag(ApplicationDbContext db)
        {
            Console.WriteLine("Tag name:");
            string tagName = Console.ReadLine();

            Console.WriteLine("Importance:");
            int tagImportance = int.Parse(Console.ReadLine());

            IPropertiesService propertiesService = new PropertiesService(db);
            ITagsService tagsService = new TagsService(db, propertiesService);
            tagsService.Add(tagName, tagImportance);
        }

        private static void PropertySearch(ApplicationDbContext db)
        {
            Console.WriteLine("Min price:");
            int minPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Max price:");
            int maxPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Min size:");
            int minSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Max size:");
            int maxSize = int.Parse(Console.ReadLine());

            IPropertiesService service = new PropertiesService(db);
            var properties = service.Search(minPrice, maxPrice, minSize, maxSize);

            foreach (var property in properties)
            {
                Console.WriteLine($"{property.DistrictName}; {property.BuildingType}; {property.PropertyType}; => {property.Price} Euro => {property.Size} m^2");
            }
        }

        private static void MostExpensiveDistricts(ApplicationDbContext db)
        {
            IDistrictsService districtsService = new DistrictsService(db);

            Console.WriteLine("Count: ");
            int count = int.Parse(Console.ReadLine());

            var districts = districtsService.GetMostExpensiveDistricts(count);

            foreach (var district in districts)
            {
                Console.WriteLine($"{district.Name} => {district.AveragePricePerSquareMeter:f2} Euro ({district.PropertiesCount} properties)");
            }
        }


    }
}
