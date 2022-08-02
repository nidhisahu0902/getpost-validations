using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFromViewToController.Models;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        //1 way to get data from view
        [HttpPost]
        public string PostUsingParameters(string firstName, string lastName)
        {
            return "from parameters - " + firstName + "," + lastName;
        }
        //second way to get data of view
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "From request -" + firstName + "," + lastName;
        }
        //3 way to get data of view
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "From form collection-" + firstName + "," + lastName;
        }
        //4 way to get data of view
        [HttpPost]
        public ActionResult PostUsingBinding(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return View();

            }
            return View("index");
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
    }
}