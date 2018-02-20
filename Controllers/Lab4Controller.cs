using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime today = DateTime.Now;
            ViewData["hour"] = today.Hour;
            ViewData["shortTime"] = today.ToShortTimeString();
            ViewData["longDate"] = today.ToLongDateString();
            ViewData["days"] = (new DateTime(today.Year+1, 1, 1)).Subtract(today).Days;
            ViewData["year"] = today.Year;
            return View();
        }

        public IActionResult Page2(int id)
        {
            return View(id);
        }

        public IActionResult Page3()
        {
            ViewData["header"] = "Beverages";
            String[] list = { "Tea", "Coffee", "Soda", "Beer", "Wine" };
            return View(list);
        }
    }
}