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
    public class MoreLINQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MoreOne()
        {
            string[] girlsboys = { "siam", "taiyob", "ratul", "jerin", "zerin", "lubna", "Antor", "Mridula" };
            var result = from w in girlsboys
                         group w by w[0] into g
                         orderby g.Key
                         select new { FirstLetter = g.Key, Words = g };
            List<string> srtlist = new List<string>();
            foreach (var item in result)
            {
                srtlist.Add(item.FirstLetter.ToString());
                foreach (var strings in item.Words)
                {
                    srtlist.Add(strings);
                }
            }
            ViewBag.data = srtlist;
            return View("Index");
        }
        public IActionResult MoreTwo()
        {
            Ingredient[] ingredients =
            {
                new Ingredient { Name = "suger", Calories = 500 },
                new Ingredient { Name = "egg", Calories = 100 },
                new Ingredient { Name = "milk", Calories = 150 },
                new Ingredient { Name = "flour", Calories = 50 },
                new Ingredient { Name = "butter", Calories = 200 },
            };
            IEnumerable<string> HighCalorieIngredientNamesQuery = ingredients.Where(v => v.Calories >= 150)
                                                                             .OrderBy(v => v.Name)
                                                                             .Select(v => v.Name);

            ViewBag.data = HighCalorieIngredientNamesQuery;
            return View("Index");
        }
        public IActionResult MoreThree()
        {
            Ingredient[] ingredients =
            {
                new Ingredient { Name = "suger", Calories = 500 },
                new Ingredient { Name = "egg", Calories = 100 },
                new Ingredient { Name = "milk", Calories = 150 },
                new Ingredient { Name = "flour", Calories = 50 },
                new Ingredient { Name = "butter", Calories = 200 },
            };
            IEnumerable<string> HighCalorieIngredientNamesQuery =
                from i in ingredients
                where i.Calories >= 200
                orderby i.Name
                select i.Name;

            ViewBag.data = HighCalorieIngredientNamesQuery;
            return View("Index");
        }
        public IActionResult MoreFour()
        {
            Ingredient[] ingredients =
            {
                new Ingredient { Name = "suger", Calories = 500 },
                new Ingredient { Name = "egg", Calories = 100 },
                new Ingredient { Name = "milk", Calories = 150 },
                new Ingredient { Name = "flour", Calories = 50 },
                new Ingredient { Name = "butter", Calories = 200 },
            };
            IEnumerable<Ingredient> HighCalorieDairyQuery =
                from i in ingredients
                let isDairy = i.Name == "milk" || i.Name == "butter"
                where i.Calories >= 150 && isDairy
                orderby i.Name
                select i;
            
            ViewBag.data = HighCalorieDairyQuery;
            return View("Index");
        }
    }
}