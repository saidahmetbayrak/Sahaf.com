using Sahaf.BLL.Abstract;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class BooksController : Controller
    {
        ICategoryService categoryService;
        IAdvertService advertService;
        public BooksController(ICategoryService category,IAdvertService advert)
        {
            categoryService = category;
            advertService = advert;
        }
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _CategoryMenu()
        {
            return PartialView(categoryService.GetAll());
        }

        public PartialViewResult _CategoryOfAdvertsGrid(int? id)
        {
            if (id != null)
            {
                return PartialView("_CategoryOfAdverts", advertService.GetAdvertsByCategory(id.Value).ToList());
            }

            return PartialView("_CategoryOfAdverts", advertService.GetAll());
        }

        public PartialViewResult _CategoryOfAdvertsList(int? id)
        {
            if (id != null)
            {
                return PartialView("_CategoryOfAdvertsList", advertService.GetAdvertsByCategory(id.Value).ToList());
            }

            return PartialView("_CategoryOfAdvertsList", advertService.GetAll());
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