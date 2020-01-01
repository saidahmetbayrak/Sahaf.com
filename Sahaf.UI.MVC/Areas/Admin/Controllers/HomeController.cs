using Sahaf.UI.MVC.FiltersCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [AdminAuthorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PendingApprovals()
        {
            return View();
        }
        
        public ActionResult Users()
        {
            return View();
        }
        
        public ActionResult Categorys()
        {
            return View();
        }

        public ActionResult Admins()
        {
            return View();
        }
    }
}