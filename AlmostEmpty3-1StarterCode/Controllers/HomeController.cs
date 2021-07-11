﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "About";
            return View();
        }
        public IActionResult Content()
        {
            ViewData["Title"] = "Content";
            return View();
        }


    }
}
