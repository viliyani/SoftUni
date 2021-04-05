using RealEstates.Data;
using RealEstates.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace RealEstates.Services
{
    public class DistrictsService : IDistrictsService
    {
        private readonly ApplicationDbContext dbContext;

        public DistrictsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<DistrictInfoDto> GetMostExpensiveDistricts(int count)
        {
            var districts = dbContext.Districts.Select(x => new DistrictInfoDto
            {
                Name = x.Name,
                PropertiesCount = x.Properties.Count(),
                AveragePricePerSquareMeter =
                    x.Properties.Where(y => y.Price.HasValue)
                        .Average(y => y.Price / (decimal)y.Size) ?? 0,
            })
            .OrderByDescending(x => x.AveragePricePerSquareMeter)
            .Take(count)
            .ToList();

            return districts;
        }
    }
}
