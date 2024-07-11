using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ContactController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
