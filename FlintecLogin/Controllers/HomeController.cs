using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlintecLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //Commited by Rohan
            //Please Remove this
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            var rohan = 6;
            Console.WriteLine(rohan);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}