using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlintecLogin.Controllers
{
    public class RohanController : Controller
    {
        // GET: Rohan
        public ActionResult Index()
        {
            return View();
            //Commited by Rohan
            //Please Remove this
        }
        public int sum(int x, int y)
        {
            
            return (x+y);
        }
    }
}