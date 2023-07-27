﻿using Carriage.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Carriage.Web.Controllers
{
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

       // [HttpGet("Dummy")]
        public IActionResult Dummy()
        {
            return new JsonResult("Dummy Carriage Proyect");
        }
    }
}