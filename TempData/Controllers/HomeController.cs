using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save_Data()
        {
            int S_Reg_Id = Convert.ToInt32(Request.Form["Reg_Id"]);
            string S_Candiadate_Name = Request.Form["Candiadate_Name"];
            string S_Email = Request.Form["Email"];
            string S_Password = Request.Form["Password"];
            ViewBag.S_Reg_Id = S_Reg_Id;
            ViewBag.S_Candiadate_Name = S_Candiadate_Name;
            ViewBag.S_Email = S_Email;
            ViewBag.S_Password = S_Password;
            Session["Email"] = S_Email;
            Session["Password"] = S_Password;
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult login_Page()
        {
            string lEmail = Request.Form["Email"];
            string lPassword = Request.Form["Password"];
            string S_Email = Session["Email"].ToString();
            string S_Password = Session["Password"].ToString();
            if (string.Compare(S_Email, lEmail) == 0 && string.Compare(S_Password, lPassword) == 0)
                ViewBag.Message  = "Login Success";
            else
                ViewBag.Message = "Login Fail";
            return View();
        }
    }
}