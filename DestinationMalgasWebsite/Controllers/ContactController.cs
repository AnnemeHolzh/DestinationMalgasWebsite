using DestinationMalgasWebsite.BackEndServices.Prog7311_POE_ST10071737.Services;
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

        [HttpPost]
        public async Task<IActionResult> SendEmail(string name, string email, string phoneNumber, string subject, string message)
        {
            var emailService = new EmailService
            {
                name = name,
                email = email,
                phoneNumber = phoneNumber,
                subject = subject,
                body = message
            };

            emailService.Sender();

            return RedirectToAction("ContactUs");
        }

    }
}
