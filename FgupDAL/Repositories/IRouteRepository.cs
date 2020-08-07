using FgupDAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FgupDAL.Repositories
{
    public interface IRouteRepository
    {
        Task<List<Route>> GetAllRoutesAsync();
    }
}
