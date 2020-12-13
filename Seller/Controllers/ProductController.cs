using Seller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seller.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public LTWebEntities _db = new LTWebEntities();
       
        [HttpPost]
        public ActionResult addProduct(FormCollection Fields, Product model)
        {
            if(ModelState.IsValid)
            {
                ModelState.AddModelError("", "Upload Product Complete");
                Seller.Models.Product Product = new Models.Product();
                Product.pID = Fields["pID"];
                Product.pName = Fields["pName"];
                Product.pGia = Int32.Parse(Fields["pGia"]);
                Product.pSoLuong = Int32.Parse(Fields["pSoLuong"]);
                Product.pURL = Fields["pImg"];
                _db.Product.Add(Product);
                _db.SaveChanges();
                return View("addProduct");
            }
            return View();
        }
        [HttpGet]
        public ActionResult addProduct()
        {
            return View();
        }
        public ActionResult editProduct()
        {

            return View();
        }
        
        
    }
}