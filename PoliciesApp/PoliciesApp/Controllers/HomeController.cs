using PoliciesApp.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoliciesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new PoliciesContext())
            {
                db.Customers.Add(new Entities.Entities.Customer { Name = "Heider", Policies = null });
                db.SaveChanges();
            }

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
