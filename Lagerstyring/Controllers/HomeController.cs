using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lagerstyring.Models;

namespace Lagerstyring.Controllers{
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Merchandise(int id){
            //Test data
            Boolean[] test2 = new Boolean[10];
            test2[0] = false;
            test2[1] = false;
            test2[2] = false;
            test2[3] = true;
            test2[4] = true;
            test2[5] = true;
            test2[6] = false;
            test2[7] = false;
            test2[8] = false;
            test2[9] = false;
            Merchandise test = new Merchandise("Løbsmærker", 25, test2);
            //Test data slut

            if (id == 1){
                ViewData["Message"] = test.Name;
            }
            else{
                ViewData["Message"] = test.SalePrice;
            }

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