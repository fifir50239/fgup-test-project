using FgupDAL.Context.Implementation;
using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FgupDAL.Repositories.Implementation
{
    public class RouteRepository : IRouteRepository
    {
        private readonly TestDbContext _context;
        public RouteRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Route>> GetAllRoutesAsync() => await _context.Routes.ToListAsync();
    }
}
