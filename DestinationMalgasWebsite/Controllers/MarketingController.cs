using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class MarketingController : Controller
    {
        private readonly ILogger<MarketingController> _logger;

        public MarketingController(ILogger<MarketingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Marketing()
        {
            return View();
        }

        public IActionResult Website()
        {
            return View();
        }

        public IActionResult SocialMedia()
        {
            return View();
        }

        public IActionResult DirectMarketing()
        {
            return View();
        }
    }
}
