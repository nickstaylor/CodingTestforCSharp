using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Wassup Dogg";
            return View();
        }

        public IActionResult Data()
        {
            ViewData["Message"] = "Wassup Dogg";
            return PartialView();
        }
    }
}