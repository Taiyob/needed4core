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
    public class DataModelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Checking(string username, string password)
        {
            string msg = "";
            int usrclr = 0;
            int usrpass = 0;
            if (string.IsNullOrEmpty(username))
            {
                msg += "Username is empty!!!</span>";
            }
            else {
                if (username == "siam")
                {
                    msg += "You are welcome Siam!!!";
                    usrclr = 1;
                }
                else {
                    msg += "Invalaid usename!!!";
                }
            }

            if (string.IsNullOrEmpty(password))
            {
                msg += "Password is empty!!!";
            }
            else
            {
                if (password == "siam")
                {
                    msg += "Correct password!!!";
                    usrpass = 1;
                }
                else
                {
                    msg += "Invalaid password!!!";
                }
            }
            ViewBag.msg = msg;
            ViewBag.color = usrclr + usrpass;
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Check(string username, string fname, string present, string parmanent, string phone, string email)
        {
            ViewBag.username = username;
            ViewBag.fname = fname;
            ViewBag.present = present;
            ViewBag.parmanent = parmanent;
            ViewBag.phone = phone;
            ViewBag.email = email;
            return View();
        }
        public IActionResult ApplicantRegister()
        {
            return View();
        }
        public IActionResult ApplicantCheck(Applicant objects)
        {
            return View(objects);
            //return Content($"Name:{objects.Name}, Father:{objects.FatherName}, Phone:{objects.Phone}");
        }
        public IActionResult GoAnotherController()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Employeers()
        {
            string txt = "";
            if (TempData["msg"] != null) {
                txt = TempData["msg"].ToString();
            }
            ViewBag.msg = txt;
            return View();
        }
        public IActionResult SaveEmployeers(Employee e)
        {
            if (ModelState.IsValid)
            {
                TempData["msg"] = "Data is correct.";
            }
            else
            {
                TempData["msg"] = "Data is not correct.";
            }
            return RedirectToAction("Employeers");
        }
    }
}