namespace RealEstates.Services
{
    public interface IPropertiesService
    {
        void Add(string district, int floor, int maxFloors, int size, int yardSize, int year, string propertyType, string buildingType, int price);

    }
}
