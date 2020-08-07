using FgupDAL.Context.Implementation;
using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FgupDAL.Repositories.Implementation
{
    public class FederalDistrictRepository : IFederalDistrictRepository
    {
        private readonly TestDbContext _context;
        public FederalDistrictRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<List<FederalDistrict>> GetAllFederalDistrictsAsync() => await _context.FederalDistricts.ToListAsync();

        public async Task<List<FederalDistrict>> GetDistrictsByIdsAsync(List<long> ids) =>                    
            await _context.FederalDistricts.Where(x => ids.Contains(x.Id)).ToListAsync();
        
    }
}
