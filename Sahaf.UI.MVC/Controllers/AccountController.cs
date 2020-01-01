﻿using Sahaf.BLL.Abstract;
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
            try
            {
                var gelenKullanici = userService.CheckUser(user.Username,user.EMail);
                if (gelenKullanici.Count == 0)
                {
                    userService.Insert(user);
                }
                else
                {
                    ViewBag.Error = "Böyle bir kullanıcı kayıtlı!";
                    return View();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ViewBag.Error = "Veritabanı ekleme hatası!";
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Logout()
        {
            Session["Kullanici"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Error()
        {
            return View();
        }
        [AuthorizeAttr]
        public ActionResult MyAdverts()
        {
            return View();
        }
        [AuthorizeAttr]
        public ActionResult MyOrders()
        {
            return View();
        }
        [AuthorizeAttr]
        public ActionResult MyInbox()
        {
            return View();
        }
        [AuthorizeAttr]
        public ActionResult MyFavorites()
        {
            return View();
        }
        [AuthorizeAttr]
        public ActionResult Sahaf()
        {
            return View();
        }
    }
}