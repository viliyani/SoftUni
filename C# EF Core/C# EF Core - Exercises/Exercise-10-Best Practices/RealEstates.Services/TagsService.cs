using RealEstates.Data;
using RealEstates.Models;
using System;
using System.Linq;

namespace RealEstates.Services
{
    public class TagsService : BaseService, ITagsService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IPropertiesService propertiesService;

        public TagsService(ApplicationDbContext dbContext, IPropertiesService propertiesService)
        {
            this.dbContext = dbContext;
            this.propertiesService = propertiesService;
        }

        public void Add(string name, int importance = 0)
        {
            Tag tag = new Tag
            {
                Name = name,
                Importance = importance
            };

            dbContext.Tags.Add(tag);
            dbContext.SaveChanges();
        }

        public void BulkTagToProperties()
        {
            var allProperties = dbContext.Properties.Take(10).ToList();

            foreach (var property in allProperties)
            {
                var averagePriceForDistrict = this.propertiesService
                    .AveragePricePerSquareMeter(property.DistrictId);

                // expensive/cheap property tags

                if (property.Price > averagePriceForDistrict)
                {
                    var tag = GetTag("скъп-имот");
                    property.Tags.Add(tag);
                }
                else if (property.Price < averagePriceForDistrict)
                {
                    var tag = GetTag("евтин-имот");
                    property.Tags.Add(tag);
                }

                // old/new property tags
                var date15YearsAgo = DateTime.Now.AddYears(-15);

                if (property.Year.HasValue && property.Year <= date15YearsAgo.Year)
                {
                    Tag tag = GetTag("стар-имот");
                    property.Tags.Add(tag);
                }
                else if (property.Year.HasValue && property.Year > date15YearsAgo.Year)
                {
                    Tag tag = GetTag("нов-имот");
                    property.Tags.Add(tag);
                }
            }

            dbContext.SaveChanges();

        }

        private Tag GetTag(string tagName)
        {
            return dbContext.Tags.FirstOrDefault(x => x.Name == tagName);
        }
    }
}
