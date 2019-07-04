using PoliciesApp.Entities.Context;
using System.Web.Mvc;

namespace PoliciesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
