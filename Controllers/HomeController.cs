using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string word1, string word2, string word3, string word4, string word5)
        {
            ViewBag.message = $"{word1} {word2} {word3} {word4} {word5}";
            return View("Concat");
        }

    }
}