using FgupDAL.Context.Implementation;
using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FgupDAL.Repositories.Implementation
{
    public class CityRepository : ICityRepository
    {
        private readonly TestDbContext _context;
        public CityRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllCitiesAsync() => await _context.Cities.ToListAsync();

        public async Task<Dictionary<long, string>> GetNamesDictByIdsAsync(IEnumerable<long> ids) =>
            await _context.Cities.Where(x => ids.Contains(x.OkatoId)).ToDictionaryAsync(k => k.OkatoId, v => v.Name);        
    }
}
