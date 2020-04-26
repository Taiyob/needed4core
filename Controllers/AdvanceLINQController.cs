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
    public class AdvanceLINQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Transformation()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strtext = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var txtnums = from n in numbers
                          select strtext[n];
            ViewBag.data = txtnums;
            return View();
        }
        public string SentenceCase(string word)
        {
            string matchine = "";
            if (string.IsNullOrEmpty(word)) { return ""; }
            matchine = word.Substring(0, 1).ToUpper();
            matchine = matchine + word.Substring(1).ToLower();
            return matchine;
        }
        public string FirstLastBig(string word)
        {
            string matchine = "";
            if (string.IsNullOrEmpty(word)) { return ""; }
            int LENGTH = word.Length;
            matchine = word.Substring(0, 1).ToUpper();
            matchine = matchine +  word.Substring(1, LENGTH-2).ToLower();
            matchine = matchine + word.Substring(LENGTH - 1).ToUpper();
            return matchine;
        }
        public IActionResult AdvanceOne()
        {
            string[] foods = { "BiRiaNi", "kacHHI", "teheri", "CHINES", "BURgeR" };
            var result = from w in foods
                         select new { Lower = w.ToLower(), Upper = w.ToUpper(), Sentence = SentenceCase(w), FirstLast = FirstLastBig(w) };

            ViewBag.food = result;
            return View();
        }
        public IActionResult AdvanceTwo()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numsInPlace = numbers.Select((num, index) => new { Num = num, Inplace = (num == index) });

            ViewBag.data = numsInPlace;
            return View();
        }
        public IActionResult AdvanceThree()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { a, b };
            ViewBag.data = pairs;
            return View("AdvanceTwo");
        }
        public IActionResult AdvanceFour()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = from n in numbers
                         group n by n % 5 into g
                         orderby g.Key
                         select new { Reminder = g.Key, Number = g };
            List<string> strlist = new List<string>();
            foreach (var item in result)
            {
                strlist.Add("Group By : " + item.Reminder);
                foreach (var values in item.Number)
                {
                    strlist.Add(values.ToString());
                }
            }

            ViewBag.data = strlist;
            return View("AdvanceTwo");
        }
    }
}