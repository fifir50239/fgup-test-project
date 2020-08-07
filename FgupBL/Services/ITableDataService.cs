using FgupAPI.Models.TableData;
using System.Threading.Tasks;

namespace FgupBL.Services
{
    public interface ITableDataService
    {
        Task<TableDataResponse> GenerateTableDataAsync();
    }
}
