using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Courses.Models.Services.Applications;
using Courses.Models.ViewModels;

namespace WebApp.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            var courseServices = new CourseServices();
            List<CoursesViewModel> courses =  courseServices.GetServices();
            return View(courses);
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