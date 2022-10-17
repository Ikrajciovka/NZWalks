using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Data;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDBContext nzWalksDBContext;
        public RegionRepository(NZWalksDBContext nzWalkDbContext)
        {
            this.nzWalksDBContext = nzWalkDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            //return nzWalksDBContext.Regions.ToList();
            return await nzWalksDBContext.Regions.ToListAsync();
        }
    }
}
