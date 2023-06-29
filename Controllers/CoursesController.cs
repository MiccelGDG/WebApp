using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail con codice {id}");
        }

        public IActionResult Search(string title)
        {
            return Content($"Hai cercato {title}");
        }
    }
}