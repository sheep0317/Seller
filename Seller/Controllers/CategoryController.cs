using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Seller.Models;
using PagedList;

namespace Seller.Controllers
{
    public class CategoryController : Controller
    {
        private LTWebEntities db = new LTWebEntities();

        // GET: Category
        [ChildActionOnly]
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var links = (from l in db.Product select l).OrderBy(x => x.pID);
            int pageSize = 15;
            int pagenum = (page ?? 1);

            return View(links.ToPagedList(pagenum, pageSize));
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult shopcart()
        {
            return View();
        }

    }
}
