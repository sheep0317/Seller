using Seller.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seller.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public LTWebEntities _db = new LTWebEntities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection Fields, Users u)
        {
                Seller.Models.GlobalVari.isNoti = true;
                var user = _db.Users.Find(Fields["Username"]);
                if (user is null)
                {

                }
                else
                {
                    if (String.Equals(user.Password, Fields["Password"]))
                    {
                    switch (user.Role) {
                        case "0":
                            GlobalVari.isLog = true;
                            GlobalVari.userLog = user.Username;
                            GlobalVari.isLogSuccess = true;
                            GlobalVari.publicInfo = new Users
                            {
                                Username = GlobalVari.userLog,
                                Role = user.Role
                            };               
                            return RedirectToAction("adminPage", "Login");
                        case "1":

                            //return View("~/Views/Home/Index.cshtml");
                            GlobalVari.isLog = true;
                            GlobalVari.userLog = user.Username;
                            GlobalVari.isLogSuccess = true;
                            GlobalVari.publicInfo = new Users
                            {
                                Username = GlobalVari.userLog,
                                Role = user.Role
                            };
                            return RedirectToAction("managerPage", "Login");
                     
                        case "2":
                            GlobalVari.isLog = true;
                            GlobalVari.userLog = user.Username;
                            GlobalVari.isLogSuccess = true;
                            GlobalVari.publicInfo = new Users
                            {
                                Username = GlobalVari.userLog,
                                Role = user.Role
                            };
                            return RedirectToAction("userPage", "Login");
                         
                    }

                    }
                }
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public ActionResult Signup(FormCollection Field)
        {
            if (Field["Password"] != Field["uRepass"])
            {
                return View();
            }
            Users user = new Users();
            user.Username = Field["Username"];
            user.Password = Field["Password"];
            user.nickname = Field["nickname"];
            user.email = Field["email"];
            if (Field["type"] == "User")
            {
                user.Role = "2";
            }
            else if (Field["type"] == "Seller")
            {
                user.Role = "1";
            }
            else return View();
            _db.Users.Add(user);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult userPage()
        {
            
            return View();
        }
        public ActionResult managerPage()
        {
            return View();
        }
        public ActionResult adminPage()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Seller.Models.GlobalVari.userLog = "";
            Seller.Models.GlobalVari.isLog = false;
            GlobalVari.publicInfo = null;
            return RedirectToAction("Index", "Home");
        }

    }
}