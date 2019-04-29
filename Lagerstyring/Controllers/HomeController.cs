﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lagerstyring.Models;

namespace Lagerstyring.Controllers{
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Merchandise(){
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Sale(){
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Purchase()
        {
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