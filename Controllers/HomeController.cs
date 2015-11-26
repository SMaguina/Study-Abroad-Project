using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudyAbroad.DAL;
using StudyAbroad.Models;
using StudyAbroad.ViewModels;

namespace StudyAbroad.Controllers
{
    public class HomeController : Controller
    {
        Results data = new Results();
        LocationIndex displayData = new LocationIndex();
        public ActionResult Index()
        {
            displayData = data.Result("Index");

            return View(displayData);
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
       
        public ActionResult Country(int? countryId)
        {
            countryId = Convert.ToInt32(RouteData.Values["id"]);
            displayData = data.Result("Country", countryId);

            return View(displayData);
        }
        public ActionResult State(int? stateID)
        {
            stateID = Convert.ToInt32(RouteData.Values["id"]);
            displayData = data.Result("State", stateID);

            return View(displayData);
        }

        public ActionResult City(int? cityID)
        {
            cityID = Convert.ToInt32(RouteData.Values["id"]);
            displayData = data.Result("City", cityID);

            return View(displayData);
        }

        public ActionResult WriteReview()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }
    }
}