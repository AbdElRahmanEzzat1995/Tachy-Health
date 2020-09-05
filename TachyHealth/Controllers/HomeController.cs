using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TachyHealth.Models;

namespace TachyHealth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            RegisterViewModel R = new RegisterViewModel();
            if (val1)
            {
                try
                {
                    AccountController Ac = new AccountController();
                    var signedUser = (User.Identity.GetUserId());
                    var SU = Ac._Context.Users.SingleOrDefault(c => c.Id.Equals(signedUser));
                    R.FullName = SU.UserName;
                    R.MobileNumber = SU.PhoneNumber;
                    R.Email = SU.Email;
                }
                catch (NullReferenceException ex)
                {
                    return View(R);
                }
            }
            return View(R);
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