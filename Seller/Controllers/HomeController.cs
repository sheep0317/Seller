using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seller.Models;


namespace Seller.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public LTWebEntities _db = new LTWebEntities();

        public ActionResult Index()
        {

            //var data = (from s in _db.Users select s).ToList();
            //ViewBag.users = data;
            return View();

        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}