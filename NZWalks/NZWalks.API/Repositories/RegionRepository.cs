using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbCoContext nZWalksDbCoContext;

        public RegionRepository(NZWalksDbCoContext nZWalksDbCoContext) 
        {
            this.nZWalksDbCoContext = nZWalksDbCoContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDbCoContext.Regions.ToListAsync();
        }
    }
}
