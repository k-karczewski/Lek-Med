﻿using Microsoft.AspNetCore.Mvc;

namespace LekMed.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index()
        {
            return View();
        }

    }
}
