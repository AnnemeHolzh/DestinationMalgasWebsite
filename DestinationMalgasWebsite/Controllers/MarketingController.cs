using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class MarketingController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MarketingController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Marketing()
        {
            return View();
        }
    }
}
