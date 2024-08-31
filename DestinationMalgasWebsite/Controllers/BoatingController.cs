using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class BoatingController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BoatingController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Boating()
        {
            return View();
        }

        public IActionResult Charters()
        {
            return View();
        }

        public IActionResult Rentals()
        {
            return View();
        }

        public IActionResult BaitAndTackle()
        {
            return View();
        }
    }
}
