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
    public class LINQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Example(int searchnum)
        {
            int[] number = { 2, 4, 7, 4, 9, 8, 1, 3, 6, 5, 0, 8 };
            if (searchnum >= 0)
            {
                var result = from n in number
                             where n > searchnum
                             select n;

                List<string> strlist = new List<string>();
                foreach (var item in result)
                {
                    strlist.Add(item.ToString());
                }
                ViewBag.srh = strlist;
            }
            return View();
        }
        public IActionResult ExampleOne()
        {
            int[] number = { 2, 4, 7, 4, 9, 8, 1, 3, 6, 5, 0, 8 };
            var result = from n in number
                         where n > 3
                         select n;
            List<string> strlist = new List<string>();
            foreach (var item in result)
            {
                strlist.Add(item.ToString());
            }
            ViewBag.number = strlist;
            return View("Index");
        }
        public IActionResult ExampleTwo()
        {
            int[] number = { 2, 4, 7, 4, 9, 8, 1, 3, 6, 5, 0, 8 };
            var result = from n in number
                         where n > 6
                         select n*10;
            List<string> strlist = new List<string>();
            foreach (var item in result)
            {
                strlist.Add(item.ToString());
            }
            ViewBag.number = strlist;
            return View("Index");
        }
        public IActionResult ExampleThree(string usertxt)
        {
            string msg = "";
            int reccount = 0;
            List<string> courses = new List<string>()
            {
                "C# Programming Tutorial",
                "C++ Programming",
                "Java Programming Tutorial",
                "JavaScript Programming Tutorial",
                "Python Programming",
                "Ruby Programming",
                "PHP Programming Tutorial",
                "Angular",
                "React Programming",
                "Jquery",
                "Network Essentials",
                "Database Management",
            };
            if (!string.IsNullOrEmpty(usertxt)) 
            {
                var result = from c in courses
                             where c.ToLower().Contains(usertxt.ToLower())
                             select c;
                if (result.Count() == 0)
                {
                    msg = "Data not Found";
                }
                reccount = result.Count();

                ViewBag.count = reccount;
                ViewBag.msg = msg;
                ViewBag.courses = result;
                ViewBag.show = usertxt;
            }
            return View();
        }
        public IActionResult ExampleFour()
        {
            List<Novice> student = new List<Novice>()
            {
                new Novice  {Id = 1, Name = "Taiyob", Depertment = "CSE", AcademicSession = "2010" },
                new Novice  {Id = 2, Name = "Siam Ahamed", Depertment = "CSE", AcademicSession = "2016" },
                new Novice  {Id = 3, Name = "Oli Ullam", Depertment = "Admin", AcademicSession = "2010" },
                new Novice  {Id = 4, Name = "Ratul Khan", Depertment = "CSE", AcademicSession = "2016" },
                new Novice  {Id = 5, Name = "Antor Mahmud", Depertment = "EEE", AcademicSession = "2014" },
                new Novice  {Id = 6, Name = "Emam Babu", Depertment = "BBA", AcademicSession = "2011" },
                new Novice  {Id = 7, Name = "Shahadat Tushar", Depertment = "BBA", AcademicSession = "2014" },
                new Novice  {Id = 8, Name = "Shakil", Depertment = "IP", AcademicSession = "2015" },
                new Novice  {Id = 9, Name = "Shofik", Depertment = "IP", AcademicSession = "2015" },
                new Novice  {Id = 10, Name = "Tamim", Depertment = "EEE", AcademicSession = "2016" },
            };
            var result = from s in student
                         where s.Depertment.ToLower().Contains("cse")
                         select s;

            ViewBag.data = result;
            return View();
        }
        public IActionResult ExampleFive(string usersearch, int chk)
        {
            List<Novice> student = new List<Novice>()
            {
                new Novice  {Id = 1, Name = "Taiyob", Depertment = "CSE", AcademicSession = "2010" },
                new Novice  {Id = 2, Name = "Siam Ahamed", Depertment = "CSE", AcademicSession = "2016" },
                new Novice  {Id = 3, Name = "Oli Ullam", Depertment = "Admin", AcademicSession = "2010" },
                new Novice  {Id = 4, Name = "Ratul Khan", Depertment = "cse", AcademicSession = "2016" },
                new Novice  {Id = 5, Name = "Antor Mahmud", Depertment = "EEE", AcademicSession = "2014" },
                new Novice  {Id = 6, Name = "Emam Babu", Depertment = "BBA", AcademicSession = "2011" },
                new Novice  {Id = 7, Name = "Shahadat Tushar", Depertment = "BBA", AcademicSession = "2014" },
                new Novice  {Id = 8, Name = "Shakil", Depertment = "IP", AcademicSession = "2015" },
                new Novice  {Id = 9, Name = "Shofik", Depertment = "IP", AcademicSession = "2015" },
                new Novice  {Id = 10, Name = "Tamim", Depertment = "EEE", AcademicSession = "2016" },
            };
            if (!string.IsNullOrEmpty(usersearch))
            {
                if(chk == 1)
                {
                    var result = from s in student
                                 where s.Depertment == usersearch || s.Name == usersearch || s.AcademicSession == usersearch
                                 select s;
                    return View(result);
                }
                else
                {
                    var result = from s in student
                                 where s.Depertment.ToLower().Contains(usersearch.ToLower()) || s.Name.ToLower().Contains(usersearch.ToLower()) || s.AcademicSession.ToLower().Contains(usersearch.ToLower())
                                 select s;
                    return View(result);
                }
            }
            return View();
            
        }
    }
}