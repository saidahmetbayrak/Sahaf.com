using Sahaf.BLL.Abstract;
using Sahaf.Model.Entities;
using Sahaf.UI.MVC.FiltersCustom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService userService;
        public AccountController(IUserService user)
        {
            userService = user;
        }
        [AuthorizeAttr]
        // GET: Account
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

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            //try
            //{
            //    userService.Insert(user);
            //    bool sonuc = MailHelper.SendConfirmationMail(user.UserName, user.Password, user.Email, user.ID);
            //    if (!sonuc)
            //    {
            //        return View();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Error = "Veritabanı ekleme hatası!";
            //    return View();
            //}
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Error()
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