using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntegrateElmah.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            try
            {
                //int a = 0;
                //int b;
                //b = 1 / a;
                TestMethod(null, null);
            }
            catch (Exception exc)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(exc);
            }
            return View();
        }

        public static void TestMethod(int? x = 10, int? y = 20)
        {
            var message = $"The value of x is {x.Value} and y is {y.Value}";
        }
    }
}