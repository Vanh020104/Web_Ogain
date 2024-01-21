using Microsoft.AspNetCore.Mvc;

namespace OgainShop.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Details()

        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Favourite()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Thankyou()
        {
            return View();
        }
    }
}