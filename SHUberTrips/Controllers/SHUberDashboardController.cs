using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHUberTrips.Models;


namespace SHUberTrips.Controllers
{
    public class SHUberDashboardController : Controller
    {
        // GET: SHUberDashboard
        public ActionResult Dashboard(SHUberCustomer CurrentUser)
        {
            return View();
        }
       public ActionResult BookTrip()
        {
            return View();
        }
    }
    
}