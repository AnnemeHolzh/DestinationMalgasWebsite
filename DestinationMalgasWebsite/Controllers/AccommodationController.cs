using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class AccommodationController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccommodationController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Accommodation()
        {
            return View();
        }
    }
}
