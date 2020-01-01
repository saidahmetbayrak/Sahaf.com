using Sahaf.BLL.Abstract;
using Sahaf.Model.Entities;
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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _GetAdverts()
        {
            return PartialView(advertService.GetAll().OrderByDescending(a=>a.ID).Take(20).ToList());
        }

        public PartialViewResult _GetAdvertForModal(int? id)
        {
            if (id != null)
            {
                return PartialView("_GetAdvertForModal", advertService.Get(id.Value));
            }
            return PartialView();
        }
    }
}