using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using System.IO;
using App11_Controller;

namespace WebApplication1.Controllers
{
    public class UniversityController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "This is the Home page of University";
            return View();
        }
        public IActionResult Department()
        {
            ViewBag.msg = "Department list of University";
            return View("Index");
        }
        public IActionResult Fecaulty()
        {
            ViewBag.msg = "Fecaulty list of University";
            return View("Index");
        }
        public IActionResult Course()
        {
            ViewBag.msg = "Courses list of University";
            return View("Index");
        }
        public IActionResult Student()
        {
            ViewBag.msg = "Students list of University";
            return View("Index");
        }
        public IActionResult Teacher()
        {
            ViewBag.msg = "Teachers list of University";
            return View("Index");
        }
    }
}