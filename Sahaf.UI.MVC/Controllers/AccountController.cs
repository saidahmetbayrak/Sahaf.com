using Sahaf.BLL.Abstract;
using Sahaf.Model.Entities;
using Sahaf.UI.MVC.FiltersCustom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService userService;
        IAdvertService advertService;
        ICategoryService categoryService;
        IOrderService orderService;
        public AccountController(IUserService user,IAdvertService advert,ICategoryService category,IOrderService order)
        {
            userService = user;
            advertService = advert;
            categoryService = category;
            orderService = order;
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
        public ActionResult Register(User user, HttpPostedFileBase ImageFile)
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
            User currentUser = Session["Kullanici"] as User;
            var adverts = advertService.GetAdvertsByUser(currentUser.ID);
            return View(adverts);
        }

        [AuthorizeAttr]
        public ActionResult AddAdvert()
        {
            int categoryCount = categoryService.GetAll().Count;
            ViewBag.CatCount = categoryCount;
            return View();
        }
        [AuthorizeAttr,HttpPost]
        public ActionResult AddAdvert(Advert advert, HttpPostedFileBase ImageFile)
        {

            try
            {
                advert.UserID = (Session["Kullanici"] as User).ID;
                string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                string extension = Path.GetExtension(ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                advert.AdvertİmgUrl = "~/Images/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                ImageFile.SaveAs(fileName);
                advertService.Insert(advert);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                throw;
            }
            return View();
        }

        [AuthorizeAttr]
        public ActionResult MyOrders()
        {
            User currentUser = Session["Kullanici"] as User;

            var orders = orderService.GetOrdersByUser(currentUser.ID);

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