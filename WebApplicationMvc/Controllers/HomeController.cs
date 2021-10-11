using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMvc.Models;
using WebApplicationMvc.Request;

namespace WebApplicationMvc.Controllers
{
    public class HomeController : Controller
    {
        private const string url = "https://tproger.ru/";
        private readonly ILogger<HomeController> _logger;
        private readonly ParserHref _parserHref;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _parserHref = new ParserHref();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Tab()
        {
            await _parserHref.GetDataAsync(url);
            var data = _parserHref.DataTable;
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
