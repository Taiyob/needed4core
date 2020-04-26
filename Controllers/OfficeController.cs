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
    public class OfficeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "This is the Home page of Office";
            return View();
        }
        public IActionResult IT()
        {
            ViewBag.msg = "IT sector of University";
            return View("Index");
        }
        public IActionResult Sales()
        {
            ViewBag.msg = "Sales Department of UI";
            return View("Index");
        }
        public IActionResult Admin()
        {
            ViewBag.msg = "Admin Part of Office";
            return View("Index");
        }
        public IActionResult Account()
        {
            ViewBag.msg = "Accountant and Economical Department";
            return View("Index");
        }
        public IActionResult HR()
        {
            ViewBag.msg = "Human resources of UI";
            return View("Index");
        }
    }
}