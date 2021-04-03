using IGTI.ModuloOCR.Model;
using IGTI.ModuloOCR.Models;
using IGTI.ModuloOCR.UI.HttpClients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;

namespace IGTI.ModuloOCR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MostQIApiClient _api;

        public HomeController(ILogger<HomeController> logger, MostQIApiClient api)
        {
            _logger = logger;
            _api = api;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var objMostQI = new MostQIApi();
            return View(objMostQI);
        }

        [HttpPost]
        public async Task<IActionResult> ReadImage()
        {
            var objMostQI = await _api.PostContentExtraction();
            return View(objMostQI);
        }

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
