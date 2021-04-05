namespace RealEstates.Services
{
    public interface ITagsService
    {
        void Add(string name, int importance = 0);

        void BulkTagToProperties();
    }
}
