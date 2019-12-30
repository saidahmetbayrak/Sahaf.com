using Sahaf.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IAdvertService advertService;
        public HomeController(IAdvertService advert)
        {
            advertService = advert;
        }
        // GET: Home
        public ActionResult Index()
        {
            var deneme = advertService.GetAll();
            return View();
        }
    }
}