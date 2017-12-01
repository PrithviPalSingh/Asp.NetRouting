using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingConcepts.Areas.Dashboard.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/Dashboard/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPost()
        {
            return View();
        }

        public ActionResult EditPost()
        {
            return View();
        }
    }
}