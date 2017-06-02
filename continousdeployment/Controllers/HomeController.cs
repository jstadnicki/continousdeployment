using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace continousdeployment.Controllers
{
    using NUnit.Framework;

    public class HomeController: Controller
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

            return View();
        }
    }

    [TestFixture]
    public class TestThatDoesNotPass
    {
        [Test]
        public void ImAFailure()
        {
            Assert.True(false);
        }
    }
}