using System.Threading.Tasks;
using FgupAPI.Models.TableData;
using FgupBL.Services;
using Microsoft.AspNetCore.Mvc;

namespace FgupTestWebApi.Controllers
{
    [ApiController]    
    [Route("table")]
    public class TableController : Controller
    {
        private readonly ITableDataService _tableDataService;
        public TableController(ITableDataService tableDataService)
        {
            _tableDataService = tableDataService;
        }

        [HttpGet("get-data")]
        public async Task<TableDataResponse> GetTableData()
        {
            return await _tableDataService.GenerateTableDataAsync();
        }
    }
}
