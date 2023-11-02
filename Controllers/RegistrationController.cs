using CoffeeShopLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopLab.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                   
                return View("Result", user);
            }
            return View();
        }
    }
}