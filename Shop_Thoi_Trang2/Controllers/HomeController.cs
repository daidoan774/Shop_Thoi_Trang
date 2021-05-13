using Shop_Thoi_Trang2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_Thoi_Trang2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = new MessageModel1();
            message.Welcome = "Hello come to Shop";
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
}