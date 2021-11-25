using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SHUberTrips.Models;

namespace SHUberTrips.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]

        public ActionResult LoginPage(SHUberTrips.Models.SHUberCustomer customer)
        {
            using(SHUberSpaceEntities db = new SHUberSpaceEntities())
            {
                var CustomerDetails = db.SHUberCustomers.Where(x => x.EmailAddress == customer.EmailAddress && x.Password == customer.Password).FirstOrDefault();
                if(CustomerDetails == null)
                {
                    customer.ErrorMessage = "Password or username is incorrect!!";
                    return View("LoginPage", customer);
                    //From the log in form filled out by "customer" which is being passed through database will be filtered to find a matching instance
                }
                else
                {
                    Session["CustomerID"] = customer.SHUberCustomerId;
                    Session["Name"] = customer.Firstname + " " + customer.Lastname;
                    return RedirectToAction("Dashboard", "SHUberDashboard");
                    //once a matching record has been found it will redirect to Dashboard 
                }
            }
        }
        [HttpGet]

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]

        public ActionResult SignUp(Models.SHUberCustomer customer)
        {
            using(SHUberSpaceEntities db = new SHUberSpaceEntities())
            {
                db.SHUberCustomers.Add(customer);
                try
                {
                    db.SaveChanges();
                }
                catch(System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting  
                            // the current instance as InnerException  
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
            ModelState.Clear();
            return View("SignUp", new SHUberCustomer());

        }

    }
}