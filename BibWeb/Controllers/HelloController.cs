using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibWeb.Controllers
{
    public class HelloController : Controller
    {
        //GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "This is my default page";
        //}

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        
        public string Welcome2(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }

        public string Welcome3(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }

        [Route("WelcomeYou/{name}/{numTimes:int}")]
        public string WelcomeYou(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }

        public ActionResult Welcome5(string name, int numTimes = 15)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}