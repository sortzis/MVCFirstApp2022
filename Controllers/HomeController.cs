using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;
using System.Diagnostics;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //GET: Home
        public string myIndex()
        {
            return "Sammi's Awesome Index";
        }

        public IActionResult Index(string ID)
        {
            string seeView = ID;
            if (seeView == "cit")
                return View("cit218");
            else
                return View();
        }

        public IActionResult cit218()
        {
            return View();
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