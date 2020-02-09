using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sandromic.DAL;
using Sandromic.Model;

namespace Sandromic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = Data.GetData();
            var output = Json(
                new
                {
                    Data = list,
                    Total = list.Count
                },
                JsonRequestBehavior.AllowGet);

            return output;
        }
        public ActionResult Search(UserModel searchModel, int skip = 0, int take = 10)
        {
            var list = Data.GetData();
            var output = Json(
                new
                {
                    Data = list,
                    Total = list.Count
                },
                JsonRequestBehavior.AllowGet);

            return output;
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