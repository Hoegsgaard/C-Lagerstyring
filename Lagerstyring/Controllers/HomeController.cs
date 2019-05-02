using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lagerstyring.Models;

namespace Lagerstyring.Controllers{
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Merchandise(){
            Boolean[] test2 = new Boolean[0];
            Merchandise test = new Merchandise("Løbsmærker", 25, test2);
            ViewData["Message"] = test.Name;

            return View();
        }

        public IActionResult Sale(){
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult NewMerch()
        {
            ViewData["Message"] = "Welcome to new item";
            return View();
        }

        public IActionResult Purchase(){
            return View();
        }

        public IActionResult Privacy(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel{RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}