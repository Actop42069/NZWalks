using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
	public class SQLRegionRepository : IRegionRepository
	{
		private readonly NZWalksDbContext dbContext;
        public SQLRegionRepository(NZWalksDbContext dbContext)
        {
			this.dbContext = dbContext;
        }
        public async Task<List<Region>> GetAllAsync()
		{
			return await dbContext.Regions.ToListAsync(); 
		}
	}
}
