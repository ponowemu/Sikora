using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SikoraDrop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SikoraDrop.Controllers
{
    // Wordpress 
    // Klient kod = ck_70b38752919aea3e1f2ee6657f8815b48987367f
    // Klucz prywatny = cs_2e622b410e030b04322273b1c458fd0833afe93e
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
