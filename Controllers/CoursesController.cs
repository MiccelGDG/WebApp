using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Courses.Models.Services.Applications;

namespace WebApp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courseServices = new CourseServices();
            return View();
        }

        public IActionResult Detail(string id)
        {
            return View();
        }

        public IActionResult Search(string title)
        {
            return View();
        }
    }
}