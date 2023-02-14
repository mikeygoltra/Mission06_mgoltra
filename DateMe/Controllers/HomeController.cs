using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, Context someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            return View();
        }
        public IActionResult Baconsale()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse response)
        {
            blahContext.Add(response);
            blahContext.SaveChanges();
            return View("Confirmation", response);
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
