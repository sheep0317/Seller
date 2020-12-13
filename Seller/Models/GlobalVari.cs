using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seller.Models
{
    public class GlobalVari
    {
        public static bool isLog = false;
        public static string userLog;
        public static bool isLogSuccess = false;
        public static bool isNoti = false;
        public static Cart publicCart;
        public static Users publicInfo = new Users { Username = userLog };
    }

}