using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using BolloreTest.Utils;

namespace BolloreTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.BackgroundColor = "#C2B5B5";
            const string pattern = @"[js]|[ch]+";
            ViewBag.ResultExo1 = Regex.Replace("j'ai un cheveu sur la langue", pattern, "z");

            return View();
        }

        [Route("/PinkPower")]
        public ActionResult PinkPower()
        {
            ViewBag.BackgroundColor = "#FFC0CB";
        
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}