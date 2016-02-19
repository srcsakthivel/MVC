using MVC.GetStarted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.GetStarted.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "src";
            ViewBag.Email = "src@test.com";
            return View();
        }

        public ActionResult IndexViewData()
        {
            ViewData["Name"] = "src";
            ViewData["Email"] = "src@test.com";
            return View();
        }

        public ActionResult IndexTempData()
        {
            TempData["Name"] = "src";
            TempData["Email"] = "src@test.com";
            return View();
        }

        public ActionResult IndexViewModel()
        {
            var person = new Person() { Name = "src", Email = "src@test.com" };
            return View(person);
        }

        public string MyIndex()
        {
            return "String returned from the controller";
        }



    }
}