using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        private Context daContext { get; set; }
        //constructor
        public HomeController(Context someName)
        {
           
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            ViewBag.Categories = daContext.Categories.ToList();
            return View();
        }
        public IActionResult Baconsale()
        {
            return View();
        }


        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse response)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(response);
                daContext.SaveChanges();
                return View("Confirmation", response);
            }
            else 
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View();
            }

 
        }

        public IActionResult MovieList()
        {
            var applications = daContext.Entries
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var application = daContext.Entries.Single(x => x.MovieId == movieid);

            return View("DatingApplication", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            
            daContext.Update(blah);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var application = daContext.Entries.Single(x => x.MovieId == movieid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.Entries.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
