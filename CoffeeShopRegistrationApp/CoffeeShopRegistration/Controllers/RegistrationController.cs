using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        /* private readonly ILogger<HomeController> _logger;

         public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         }
        */
        [HttpPost]
        public IActionResult HandleSubmit(UserProfile userProfile)
        {
            if (!ModelState.IsValid)    // very handy tool
            {
                return RedirectToAction("Index");
            }
            // We can process the UserProfile object now!
            // For example, we can save it to a database.

            return RedirectToAction("Welcome", userProfile);
        }

        public IActionResult Register(UserProfile userProfile) 
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(UserProfile userProfile)
        {
            return View(userProfile);
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