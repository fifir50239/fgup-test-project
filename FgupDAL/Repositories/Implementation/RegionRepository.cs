using FgupDAL.Context.Implementation;
using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FgupDAL.Repositories.Implementation
{
    public class RegionRepository : IRegionRepository
    {
        private readonly TestDbContext _context;
        public RegionRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Region>> GetAllRegionsAsync() => await _context.Regions.ToListAsync();
    }
}
