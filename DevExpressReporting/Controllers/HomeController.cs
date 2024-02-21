using DevExpressReporting.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevExpressReporting.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly DataTransformDbContext _db;

        public HomeController(ILogger<HomeController> logger,
            DataTransformDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdcCore()
        {
            List<AdcCoreSummary> core = _db.AdcCoreSummary.ToList();
            return View(core);
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







