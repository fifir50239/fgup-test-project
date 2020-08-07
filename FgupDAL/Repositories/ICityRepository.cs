using FgupDAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FgupDAL.Repositories
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllCitiesAsync();
        Task<Dictionary<long, string>> GetNamesDictByIdsAsync(IEnumerable<long> ids);
    }
}
