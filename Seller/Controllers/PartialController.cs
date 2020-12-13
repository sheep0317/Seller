using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seller.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        [ChildActionOnly]
        public ActionResult Left()
        {
            return PartialView("Left");
        }
        
        //public ActionResult  IndexPartial()
        //{
        //    return PartialView("~/Views/Category/Index.cshtml");
        //}
        [ChildActionOnly]
        public ActionResult managerbill()
        {
            return View();
        }
    }
}