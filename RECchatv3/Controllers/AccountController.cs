using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace RECchatv3.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            if(returnUrl!=null)
            {
                ViewBag.isReturnUrl = true; ;
            }
            ViewBag.Msg = "";
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
        [HttpPost]
        public ActionResult Login(string Username, string Password )
        {               
            bool isAuthenticated = WebSecurity.Login(Username, Password);
            if(isAuthenticated)
            {
                return RedirectToAction("Dashboard", "Account");
            }
            else
            {
                ViewBag.Msg = "Wrong Credentials, Please Contact Admin !";
            }
            return View();
        }
        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }
        [Authorize]
        public ActionResult Logout()
        {
            WebSecurity.Logout();
            TempData["Logoutmsg"] = "You have been successfully logged out";
            
            return RedirectToAction("Login");
        }

        [Authorize]
        public ActionResult ITCR()
        {   
            return View();
        }

        [Authorize]
        public ActionResult Chat()
        {
            return View();
        }
    }
}