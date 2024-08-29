using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class DestinationController : Controller
    {
        private readonly ILogger<DestinationController> _logger;

        public DestinationController(ILogger<DestinationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Destination()
        {
            return View();
        }

        public IActionResult Malgas()
        {
            return View();
        }

        public IActionResult MalgasFerry()
        {
            return View();
        }

        public IActionResult BoathousePizzaAndPub()
        {
            return View();
        }

        public IActionResult BushPub()
        {
            return View();
        }
        public IActionResult SijnnWineEstate()
        {
            return View();
        }

        public IActionResult Grunters()
        {
            return View();
        }

        public IActionResult DeHoop()
        {
            return View();
        }

        public IActionResult TheFigTree()
        {
            return View();
        }

        public IActionResult Bites()
        {
            return View();
        }

        public IActionResult TheTradingPost()
        {
            return View();
        }
    }
}
