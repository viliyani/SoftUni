using RealEstates.Services.Models;
using System.Collections.Generic;

namespace RealEstates.Services
{
    public interface IPropertiesService
    {
        void Add(string district, int price,
            int floor, int maxFloors, int size, int yardSize, 
            int year, string propertyType, string buildingType);

        IEnumerable<PropertyInfoFullDataDto> GetFullData(int count = 10);

        IEnumerable<PropertyInfoDto> Search(int minPrice, int maxPrice, int minSize, int maxSize);

        decimal AveragePricePerSquareMeter(int districtId);

    }
}
