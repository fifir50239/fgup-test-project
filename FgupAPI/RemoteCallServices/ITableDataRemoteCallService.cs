using FgupAPI.Models.TableData;
using System.Threading.Tasks;

namespace FgupAPI.RemoteCallServices
{
    public interface ITableDataRemoteCallService
    {
        Task<TableDataResponse> GetTableDataAsync();
    }
}
