using FgupDAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FgupDAL.Repositories
{
    public interface IFederalDistrictRepository
    {
        Task<List<FederalDistrict>> GetAllFederalDistrictsAsync();
        Task<List<FederalDistrict>> GetDistrictsByIdsAsync(List<long> ids);
    }
}
