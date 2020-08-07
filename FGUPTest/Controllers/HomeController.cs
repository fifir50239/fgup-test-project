using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FGUPTest.Models;
using FgupAPI.RemoteCallServices;
using FgupAPI.Models.TableData;

namespace FGUPTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITableDataRemoteCallService _remoteCall;
        public HomeController(ILogger<HomeController> logger,
            ITableDataRemoteCallService tableDataRemoteCallService)
        {
            _logger = logger;
            _remoteCall = tableDataRemoteCallService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-table-data")]
        public async Task<TableDataResponse> GetTableData()
            => await _remoteCall.GetTableDataAsync();

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
