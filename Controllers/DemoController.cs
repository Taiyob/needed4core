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
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewTestOne()
        {
            return View("ViewTestThree");
        }
        public IActionResult ViewTestTwo()
        {
            return View("ViewTestOne");
        }
        public IActionResult ViewTestThree()
        {
            return View("ViewTestTwo");
        }
        public IActionResult MethodTestOne()
        {
            string pass = "";
            if (TempData["pass_data"] != null) {
                pass = TempData["pass_data"].ToString();
            }

            Person objects = new Person();
            if (TempData["val"] != null) {
                objects = TempData.Get<Person>("val");
            }


            string data = "It is method one";



            ViewBag.things = data;   
            ViewBag.passingTemp = pass;
            ViewBag.tempexten = objects;
            //return RedirectToAction("MethodTestTwo");   
            return View();
        }
        public IActionResult MethodTestTwo()
        {
            TempData["pass_data"] = "I am passing with temp data from Method test two";

            Person obj = new Person { Id = 201, Name = "Jerin", Age = 17, Phone = "01966534127", Country = "Bangladesh" };
            TempData.Put("val",obj);

            string data = "It is method two";
            ViewBag.things = data;

            return RedirectToAction("MethodTestOne");    
        }
        public IActionResult MethodTestThree()
        {
            //TempData["pass_data"] = "I am passing with temp data from Method test three";
            string data = "It is method three";
            ViewBag.things = data;
            return View();
        }
    }
}