using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlintecLogin.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
       /* public ActionResult Index()
        {
            return View();
        }
        */
        public string Index()
        {
            return "This is calling <h1>Index<h1> Method ";
        }
        public string Welcome()
        {
            return "This is calling <h1>Welcome<h1> Method ";
        }
    }
}