using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAdverts()
        {
            return View();
        }

        public ActionResult MyOrders()
        {
            return View();
        }

        public ActionResult MyInbox()
        {
            return View();
        }
        
        public ActionResult MyFavorites()
        {
            return View();
        }
        
        public ActionResult Sahaf()
        {
            return View();
        }
    }
}