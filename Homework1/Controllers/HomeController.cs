using BirthdayCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Rsvp");
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

        [HttpGet]
        public IActionResult Rsvp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Rsvp(Card card)
        {
            if (ModelState.IsValid)
                return View("Thanks", card);
            else
                return View();
        }
    }
}