using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ImageSharingWithUpload.Controllers
{
    public class AccountController : Controller
    {
        protected void CheckAda()
        {
            var cookie = Request.Cookies["ADA"];
            if (cookie != null && "true".Equals(cookie))
            {
                ViewBag.isADA = true;
            }
            else
            {
                ViewBag.isADA = false;
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            CheckAda();
            return View();
        }

        [HttpPost]
        public ActionResult Register(String Userid, String ADA)
        {
            CheckAda();
            var options = new CookieOptions() { IsEssential = true, Expires = DateTime.Now.AddMonths(3)  };

            //add cookies for "Userid" and "ADA"
            Response.Cookies.Append("Userid", Userid, options);

            string ada = (ADA == "on") ? "true" : "false";
            Response.Cookies.Append("ADA", ada, options);
            //
            
            ViewBag.Userid = Userid;
            return View("RegisterSuccess");
        }

    }
}