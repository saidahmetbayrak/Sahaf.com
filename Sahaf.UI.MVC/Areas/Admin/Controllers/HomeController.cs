using Sahaf.BLL.Abstract;
using Sahaf.Model.Entities;
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
        IUserService userService;
        public HomeController(IUserService user)
        {
            userService = user;
        }

        // GET: Admin/Home
        [AdminAuthorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var gelenKullanici = userService.GetUserByLogin(user.Username, user.Password);
            if (gelenKullanici != null)
            {
                Session["Kullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Kullanıcı bulunamadı";
            return View();
        }

        public ActionResult Logout()
        {
            Session["Kullanici"] = null;
            return RedirectToAction("Index", "Home");
        }

        [AdminAuthorize]
        public ActionResult PendingApprovals()
        {
            return View();
        }
        [AdminAuthorize]
        public ActionResult Users()
        {
            return View();
        }
        [AdminAuthorize]
        public ActionResult Categorys()
        {
            return View();
        }
        [AdminAuthorize]
        public ActionResult Admins()
        {
            return View();
        }
    }
}