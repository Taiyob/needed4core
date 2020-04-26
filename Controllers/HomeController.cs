using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LinkOne()
        {
            ViewBag.txt = "Something is coming.";
            int[] grp = { 2, 5, 4, 7, 5, 6, 5 };
            ViewBag.arr = grp;
            string[] team = {"Siam","Taiyob","Antor","Razu" };
            ViewBag.t = team;
            return View();
        }
        public IActionResult Files()
        {
            string folder = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(folder);
            ViewBag.f = files;
            return View();
        }
        public IActionResult FileDetails()
        {
            string folder = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(folder);
            List<FileDetail> fileList = new List<FileDetail>();

            int i = 1;
            foreach (var f in files) {
                FileDetail fd = new FileDetail();
                fd.Id = i;
                fd.Name = Path.GetFileNameWithoutExtension(f);
                fd.Extension = Path.GetExtension(f);
                fd.Path = f;
                //fd.Size = new FileInfo(f).Length;

                fileList.Add(fd);
                i++;
            }
            ViewBag.data = fileList;
            return View();
        }
        public IActionResult ViewDataList()
        {
            string folder = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(folder);
            List<FileDetail> fileList = new List<FileDetail>();

            int i = 1;
            foreach (var f in files)
            {
                FileDetail fd = new FileDetail();
                fd.Id = i;
                fd.Name = Path.GetFileNameWithoutExtension(f);
                fd.Extension = Path.GetExtension(f);
                fd.Path = f;
                //fd.Size = new FileInfo(f).Length;

                fileList.Add(fd);
                i++;
            }
            //ViewBag.data = fileList;
            ViewData["data"] = fileList;
            return View();
        }

        public IActionResult ModelDataList()
        {
            string[] arr = {"Taiyob","Oli","Siam" };
            return View(arr);
        }
        public IActionResult FileListModels()
        {
            string folder = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(folder);
            List<FileDetail> fileList = new List<FileDetail>();

            int i = 1;
            foreach (var f in files)
            {
                FileDetail fd = new FileDetail();
                fd.Id = i;
                fd.Name = Path.GetFileNameWithoutExtension(f);
                fd.Extension = Path.GetExtension(f);
                fd.Path = f;
                //fd.Size = new FileInfo(f).Length;

                fileList.Add(fd);
                i++;
            }
            return View(fileList);
        }
        public IActionResult SinglePerson()
        {
            Person p = new Person();
            p.Id = 101;
            p.Name = "siam ahamed";
            p.Age = 15;
            p.Phone = "01966534721";
            p.Country = "Bangladesh";
            return View(p);
        }
        public IActionResult AllEmployeePerson()
        {
            List<Person> persons = new List<Person>();
            Person p = new Person();
            p.Id = 101;
            p.Name = "siam ahamed";
            p.Age = 15;
            p.Phone = "01966534721";
            p.Country = "Bangladesh";

            persons.Add(p);
            persons.Add(new Person {Id=102, Name="Taiyob", Age=24, Phone="01645871664", Country="Bangladesh" });
            persons.Add(new Person {Id=103, Name="Siam", Age=15, Phone="01966534721", Country="Bangladesh" });
            persons.Add(new Person {Id=104, Name="Oli", Age=25, Phone="01710991692", Country="Bangladesh" });
            persons.Add(new Person {Id=105, Name="Safi", Age=8, Phone="01676364436", Country="Bangladesh" });
            persons.Add(new Person {Id=106, Name="Sufi", Age=17, Phone="01676522568", Country="Bangladesh" });

            return View(persons);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
