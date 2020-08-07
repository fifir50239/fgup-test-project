using FgupAPI.Models.TableData;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace FgupAPI.RemoteCallServices.Implementation
{
    public class TableDataRemoteCallService : RemoteCall, ITableDataRemoteCallService
    {
        protected override string Host { get; set; } //"http://localhost:50186"; 

        public TableDataRemoteCallService(IConfiguration config)
        {
            Host = config["FgupTestWebApiUrl"];
        }

        public async Task<TableDataResponse> GetTableDataAsync() =>
            await GetRequestAsync<TableDataResponse>("/table/get-data");
    }
}
