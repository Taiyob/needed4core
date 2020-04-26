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
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.txt = "This is the news portal side.";
            return View();
        }
        public IActionResult NewsPaper(int y, int m, int d, int p, int a)
        {
            if (p <= 0) p = 1;
            if (a <= 0) a = 1;
            string s = d + "-" + m + "-" + y;
            s += "\n" + "page: " + p + " article " + a;
            ViewBag.txt = s;
            return View("Index");
        }
        public IActionResult LatestNews()
        {
            int py = DateTime.Now.Year;
            int pm = DateTime.Now.Month;
            int pd = DateTime.Now.Day;
            int pp = 1;
            int pa = 1;

            return RedirectToAction("NewsPaper", "News", new {y = py, m = pm, d = pd, p = pp, a = pa });
        }

        public IActionResult Link()
        {
            string[] team = { "Siam", "Taiyob", "Ratul", "Sofik" };
            var result = from s in team
                             //where s.Contains("i") || s.Contains("I")
                             //where s.ToLower().Contains("i")
                             //where s.ToUpper().Contains("I")
                         where s.Contains("i")
                         select s;
            ViewBag.msg = result;
            return View();
        }
    }
}