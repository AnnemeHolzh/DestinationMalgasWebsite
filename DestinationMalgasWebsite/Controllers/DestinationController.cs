using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class DestinationController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DestinationController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Destination()
        {
            return View();
        }
    }
}
